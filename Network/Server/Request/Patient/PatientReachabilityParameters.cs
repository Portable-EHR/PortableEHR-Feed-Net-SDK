// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Patient
{
    public class PatientReachabilityParameters : FeedHubRequestParameters
    {
        [JsonPropertyName("patientId")] public string patientId { get; set; }

        [JsonPropertyName("isReachable")] public bool isReachable { get; set; }
    }
}