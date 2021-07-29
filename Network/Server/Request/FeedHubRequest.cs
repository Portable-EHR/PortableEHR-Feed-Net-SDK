// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request
{
    public class FeedHubRequest
    {
        [JsonPropertyName("feedAlias")] public string feedAlias { get; set; }

        [JsonPropertyName("command")] public string command { get; set; }

        [JsonPropertyName("parameters")] public FeedHubRequestParameters parameters { get; set; }
    }
}