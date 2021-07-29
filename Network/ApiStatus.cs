// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network
{
    public class ApiStatus
    {
        [JsonPropertyName("status")] public ApiStatusEnum status { get; set; }

        [JsonPropertyName("message")] public string message { get; set; }
    }
}