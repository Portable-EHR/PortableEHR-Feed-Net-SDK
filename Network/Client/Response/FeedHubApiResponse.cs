// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Response
{
    public class FeedHubApiResponse
    {
        [JsonPropertyName("requestStatus")] public ApiStatus requestStatus { get; set; }

        [JsonPropertyName("responseContent")] public FeedHubApiResponseContent responseContent { get; set; }
    }
}