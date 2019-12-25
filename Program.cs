using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace c_sharp_channels
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var response in GitHubIssues
            .GetIssues(GetMyRepos
                (
                    "migraine-tracker"
                    // "json-conversion-tool",
                    // "json-csv-tool"
                ))
            .ReadAllAsync())
                Console.WriteLine(response);
        }

        static IEnumerable<GithubIssuesRequest> GetMyRepos(params string[] repoNames)
        {
            foreach (var repoName in repoNames)
                yield return new GithubIssuesRequest("rogue-elephant", repoName);
        }
    }
}
