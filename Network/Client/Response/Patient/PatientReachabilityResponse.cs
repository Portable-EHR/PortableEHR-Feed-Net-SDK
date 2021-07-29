// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Response.Patient
{
    public class PatientReachabilityResponse : FeedHubApiResponse
    {
        [JsonPropertyName("responseContent")]
        public new PatientReachabilityResponseContent responseContent { get; set; }
    }
}