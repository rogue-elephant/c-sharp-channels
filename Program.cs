using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_channels
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationToken = new CancellationToken();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var getGithubIssuesAsync = GitHubIssues.GetIssues(
                GetMyRepos(
                    "migraine-tracker",
                    "json-conversion-tool",
                    // "json-csv-tool",
                    "json-schema-to-markdown-tool"
                )
            );

            await foreach (var issue in getGithubIssuesAsync.WithCancellation(cancellationToken))
                Console.WriteLine(
                    $@"
                    ---------------------------------------------
                    REPO: {issue.Repository_Url}
                    From User: {issue.User.Login} (Is Site Admin: {issue.User.Site_Admin})
                    Issue:
                    {issue.Title}
                    
                    {issue.Body}"
                );
            stopwatch.Stop();
            Console.WriteLine($"Acquisition Took {stopwatch.ElapsedMilliseconds}ms");
        }

        static IEnumerable<GithubIssuesRequest> GetMyRepos(params string[] repoNames)
        {
            foreach (var repoName in repoNames)
                yield return new GithubIssuesRequest("rogue-elephant", repoName);
        }
    }
}
