using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

internal static class GitHubIssues
{
    private static string BuildUrl(GithubIssuesRequest request) =>
        $"https://api.github.com/repos/{request.Username}/{request.RepoName}/issues?state=open";
    internal static async IAsyncEnumerable<GithubIssue> GetIssues(IEnumerable<GithubIssuesRequest> requests, [EnumeratorCancellation]CancellationToken cancellationToken = default)
    {
        var asyncWebClient = new AsyncWebClient();
        var httpRequests = requests.Select(async request => await asyncWebClient.Get<GithubIssue[]>(BuildUrl(request), cancellationToken));

        // Fires all tasks, no requirement for parallel firing, since the thread overhead outweights the sequential http triggering
        var httpRequestsRunning = httpRequests.ToList();
        var httpRequestsCompleted = new List<Task<GithubIssue[]>>();

        while (httpRequestsRunning.Count > 0 && !cancellationToken.IsCancellationRequested)
        { // Yield the return values one by one in whichever order the http requests complete
            // Wait for any of the responses to complete, and remove from the running list
            Task<GithubIssue[]> httpResponse = await Task.WhenAny(httpRequestsRunning);
            httpRequestsCompleted.Add(httpResponse);
            httpRequestsRunning.Remove(httpResponse);
            // Yield the results one by one
            foreach (var gitHubIssue in await httpResponse)
            {
                if (cancellationToken.IsCancellationRequested)
                    break;
                else
                    yield return gitHubIssue;
            }
        }
    }
}