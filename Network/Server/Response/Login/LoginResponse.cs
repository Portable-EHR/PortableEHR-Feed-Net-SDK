// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Login
{
    public class LoginResponse : FeedApiResponse
    {
        [JsonPropertyName("responseContent")] public new LoginResponseContent responseContent { get; set; }
    }
}