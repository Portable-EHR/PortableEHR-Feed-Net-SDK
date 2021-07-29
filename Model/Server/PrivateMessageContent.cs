// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Server
{
    public class PrivateMessageContent
    {
        [JsonPropertyName("messageContext")] public string messageContext { get; set; }

        [JsonPropertyName("subject")] public string subject { get; set; }

        [JsonPropertyName("text")] public string text { get; set; }

        [JsonPropertyName("attachments")] public List<PrivateMessageAttachment> attachments { get; set; }
    }
}