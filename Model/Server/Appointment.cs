// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class Appointment
    {
        [JsonPropertyName("feedAlias")] public string feedAlias { get; set; }

        [JsonPropertyName("feedItemId")] public Guid feedItemId { get; set; }

        [JsonPropertyName("backendItemId")] public Guid backendItemId { get; set; }

        [JsonPropertyName("lastUpdated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime lastUpdated { get; set; }

        [JsonPropertyName("feedItemVersion")] public int feedItemVersion { get; set; }

        [JsonPropertyName("id")] public string id { get; set; }

        [JsonPropertyName("patientId")] public string patientId { get; set; }

        [JsonPropertyName("practitionerId")] public string practitionerId { get; set; }

        [JsonPropertyName("location")] public AppointmentLocationEnum location { get; set; }

        [JsonPropertyName("with")] public string with { get; set; }

        [JsonPropertyName("startTime")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime startTime { get; set; }

        [JsonPropertyName("endTime")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime endTime { get; set; }

        [JsonPropertyName("description")] public string description { get; set; }

        [JsonPropertyName("notes")] public string notes { get; set; }

        [JsonPropertyName("patientMustConfirm")]
        public bool patientMustConfirm { get; set; }

        [JsonPropertyName("confirmationStatus")]
        public AppointmentConfirmationStatusEnum confirmationStatus { get; set; }
    }
}