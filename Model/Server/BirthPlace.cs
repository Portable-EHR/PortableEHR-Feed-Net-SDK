// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Server
{
    public class BirthPlace
    {
        [JsonPropertyName("street1")] public string street1 { get; set; }

        [JsonPropertyName("street2")] public string street2 { get; set; }

        [JsonPropertyName("city")] public string city { get; set; }

        [JsonPropertyName("state")] public string state { get; set; }

        [JsonPropertyName("zip")] public string zip { get; set; }

        [JsonPropertyName("country")] public CountryEnum country { get; set; }
    }
}