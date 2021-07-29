// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Privatemessage
{
    public class PrivateMessageContentRequest : FeedHubRequest
    {
        [JsonPropertyName("parameters")] public new PrivateMessageContentParameters parameters { get; set; }
    }
}