// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Response.Idissuers
{
    public class IdIssuersResponse : FeedHubApiResponse
    {
        [JsonPropertyName("responseContent")] public new IdIssuersResponseContent responseContent { get; set; }
    }
}