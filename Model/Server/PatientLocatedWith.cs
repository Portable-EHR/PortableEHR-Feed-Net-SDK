// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Server
{
    public class PatientLocatedWith
    {
        [JsonPropertyName("contact")] public Contact contact { get; set; }

        [JsonPropertyName("address")] public CivicAddress address { get; set; }

        [JsonPropertyName("emergencyContact")] public Contact emergencyContact { get; set; }
    }
}