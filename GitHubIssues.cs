using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Channels;
using System.Threading.Tasks;

internal static class GitHubIssues
{
    private static string BuildUrl (GithubIssuesRequest request) => 
        $"https://api.github.com/repos/{request.Username}/{request.RepoName}/issues?state=open";
    internal static ChannelReader<string> GetIssues(IEnumerable<GithubIssuesRequest> requests)
    {
        var channel = Channel.CreateUnbounded<string>();
        var httpClient = new HttpClient();

        foreach (var request in requests)
            Task.Run(async() => {
                await channel.Writer.WriteAsync(await httpClient.GetStringAsync(BuildUrl(request)));
                channel.Writer.Complete();
            });

        return channel.Reader;
    }
}