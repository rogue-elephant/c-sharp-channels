using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_channels
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationToken = new CancellationToken();
            await foreach (var repoIssues in GitHubIssues
            .GetIssues(GetMyRepos
                (
                    "migraine-tracker",
                    "json-conversion-tool",
                    // "json-csv-tool",
                    "json-schema-to-markdown-tool"
                ), cancellationToken)
            .ReadAllAsync())
                foreach (var issue in repoIssues)
                    Console
                        .WriteLine(
                            $@"
                            ---------------------------------------------
                            REPO: {issue.Repository_Url}
                            From User: {issue.User.Login} (Is Site Admin: {issue.User.Site_Admin})
                            Issue:
                            {issue.Title}
                            
                            {issue.Body}"
                        );
        }

        static IEnumerable<GithubIssuesRequest> GetMyRepos(params string[] repoNames)
        {
            foreach (var repoName in repoNames)
                yield return new GithubIssuesRequest("rogue-elephant", repoName);
        }
    }
}
