// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Request.Privatemessage
{
    public class PrivateMessageNotificationParametersWithAuthor : PrivateMessageNotificationParameters
    {
        [JsonPropertyName("author")] public string author { get; set; }
    }
}