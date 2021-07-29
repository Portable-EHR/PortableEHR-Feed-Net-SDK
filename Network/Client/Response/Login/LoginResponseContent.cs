// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Response.Login
{
    public class LoginResponseContent : FeedHubApiResponseContent
    {
        [JsonPropertyName("token")] public string token { get; set; }
    }
}