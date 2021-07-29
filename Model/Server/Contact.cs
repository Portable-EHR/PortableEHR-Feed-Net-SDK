// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Server
{
    public class Contact
    {
        [JsonPropertyName("feedItemId")] public Guid feedItemId { get; set; }

        [JsonPropertyName("backendItemId")] public Guid backendItemId { get; set; }

        [JsonPropertyName("lastName")] public string lastName { get; set; }

        [JsonPropertyName("firstName")] public string firstName { get; set; }

        [JsonPropertyName("middleName")] public string middleName { get; set; }

        [JsonPropertyName("preferredGender")] public GenderEnum preferredGender { get; set; }

        [JsonPropertyName("preferredLanguage")]
        public PreferredLanguageEnum preferredLanguage { get; set; }

        [JsonPropertyName("email")] public string email { get; set; }

        [JsonPropertyName("alternateEmail")] public string alternateEmail { get; set; }

        [JsonPropertyName("mobilePhone")] public string mobilePhone { get; set; }

        [JsonPropertyName("landPhone")] public string landPhone { get; set; }

        [JsonPropertyName("fax")] public string fax { get; set; }

        [JsonPropertyName("professionalSalutation")]
        public string professionalSalutation { get; set; }

        [JsonPropertyName("salutation")] public string salutation { get; set; }

        [JsonPropertyName("titles")] public string titles { get; set; }
    }
}