// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response
{
    public class FeedApiResponse
    {
        [JsonPropertyName("requestStatus")] public ApiStatus requestStatus { get; set; }

        [JsonPropertyName("responseContent")] public FeedApiResponseContent responseContent { get; set; }
    }
}