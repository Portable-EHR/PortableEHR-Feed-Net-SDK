// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Request.Privatemessage
{
    public class PrivateMessageNotificationRequest : FeedBackendRequest
    {
        [JsonPropertyName("parameters")] public new PrivateMessageNotificationParameters parameters { get; set; }
    }
}