// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Request.Patient
{
    public class PatientReachabilityRequest : FeedBackendRequest
    {
        [JsonPropertyName("parameters")] public new PatientReachabilityParameters parameters { get; set; }
    }
}