// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Privatemessage
{
    public class PrivateMessageStatusRequest : FeedHubRequest
    {
        [JsonPropertyName("parameters")] public new PrivateMessageStatusParameters parameters { get; set; }
    }
}