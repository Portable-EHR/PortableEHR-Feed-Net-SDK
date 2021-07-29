// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Server
{
    public class DemographicsName
    {
        [JsonPropertyName("familyName")] public string familyName { get; set; }

        [JsonPropertyName("firstName")] public string firstName { get; set; }

        [JsonPropertyName("middleName")] public string middleName { get; set; }
    }
}