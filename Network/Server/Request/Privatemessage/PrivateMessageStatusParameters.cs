// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Request.Privatemessage
{
    public class PrivateMessageStatusParameters : FeedHubRequestParameters
    {
        [JsonPropertyName("messageId")] public string messageId { get; set; }

        [JsonPropertyName("status")] public PrivateMessageStatusEnum status { get; set; }

        [JsonPropertyName("statusDate")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime statusDate { get; set; }
    }
}