// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Request
{
    public class FeedBackendRequest
    {
        [JsonPropertyName("feedAlias")] public string feedAlias { get; set; }

        [JsonPropertyName("command")] public string command { get; set; }

        [JsonPropertyName("parameters")] public FeedBackendRequestParameters parameters { get; set; }
    }
}