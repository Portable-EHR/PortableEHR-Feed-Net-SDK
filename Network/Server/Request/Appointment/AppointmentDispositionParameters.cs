// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Request.Appointment
{
    public class AppointmentDispositionParameters : FeedHubRequestParameters
    {
        [JsonPropertyName("id")] public string id { get; set; }

        [JsonPropertyName("status")] public AppointmentDispositionEnum status { get; set; }

        [JsonPropertyName("lastUpdated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime lastUpdated { get; set; }
    }
}