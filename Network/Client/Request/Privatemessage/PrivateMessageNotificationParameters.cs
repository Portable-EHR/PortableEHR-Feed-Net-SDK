// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network.Client.Request.Privatemessage
{
    [JsonConverter(typeof(PrivateMessageNotificationParametersConverter))]
    public class PrivateMessageNotificationParameters : FeedBackendRequestParameters
    {
        [JsonPropertyName("messageId")] public string messageId { get; set; }

        [JsonPropertyName("patientId")] public string patientId { get; set; }

        [JsonPropertyName("dateCreated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime dateCreated { get; set; }
    }
}