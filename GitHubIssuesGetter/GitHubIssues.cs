using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

internal static class GitHubIssues
{
    private static string BuildUrl(GithubIssuesRequest request) =>
        $"https://api.github.com/repos/{request.Username}/{request.RepoName}/issues?state=open";
    internal static ChannelReader<GithubIssue[]> GetIssues(IEnumerable<GithubIssuesRequest> requests, CancellationToken cancellationToken)
    {
        var channel = Channel.CreateUnbounded<GithubIssue[]>();

        foreach (var request in requests)
            Task.Run(async () =>
            {
                using (var client = new AsyncWebClient())
                {
                    await channel.Writer.WriteAsync(await client.Get<GithubIssue[]>(BuildUrl(request), cancellationToken));
                    channel.Writer.Complete();
                }
            });

        return channel.Reader;
    }
}