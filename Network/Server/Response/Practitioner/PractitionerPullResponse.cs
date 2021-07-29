// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Practitioner
{
    public class PractitionerPullResponse : FeedApiResponse
    {
        [JsonPropertyName("responseContent")] public new PractitionerPullResponseContent responseContent { get; set; }
    }
}