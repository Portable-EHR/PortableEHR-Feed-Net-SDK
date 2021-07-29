// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Patient
{
    public class PatientPullResponse : FeedApiResponse
    {
        [JsonPropertyName("responseContent")] public new PatientPullResponseContent responseContent { get; set; }
    }
}