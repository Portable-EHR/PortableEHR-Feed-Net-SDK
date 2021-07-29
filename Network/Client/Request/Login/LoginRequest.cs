// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Client.Request.Login
{
    public class LoginRequest
    {
        [JsonPropertyName("username")] public string username { get; set; }

        [JsonPropertyName("password")] public string password { get; set; }
    }
}