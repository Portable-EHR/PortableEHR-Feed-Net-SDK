// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Patient
{
    public class PatientPullRequest : FeedHubRequest
    {
        [JsonPropertyName("parameters")] public new PatientPullParameters parameters { get; set; }
    }
}