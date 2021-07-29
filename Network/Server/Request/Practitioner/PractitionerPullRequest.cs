// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Request.Practitioner
{
    public class PractitionerPullRequest : FeedHubRequest
    {
        [JsonPropertyName("parameters")] public new PractitionerPullParameters parameters { get; set; }
    }
}