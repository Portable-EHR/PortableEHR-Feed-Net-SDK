// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model.Client;

namespace PortableEHRNetSDK.Network.Client.Response.Idissuers
{
    public class IdIssuersResponseContent : FeedHubApiResponseContent
    {
        [JsonPropertyName("results")] public List<JurisdictionIdIssuer> result { get; set; }
    }
}