// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class Demographics
    {
        [JsonPropertyName("dateOfBirth")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime dateOfBirth { get; set; }

        [JsonPropertyName("gender")] public GenderEnum gender { get; set; }

        [JsonPropertyName("genderAtBirth")] public GenderEnum genderAtBirth { get; set; }

        [JsonPropertyName("name")] public DemographicsName name { get; set; }

        [JsonPropertyName("nameAtBirth")] public DemographicsName nameAtBirth { get; set; }

        [JsonPropertyName("placeOfBirth")] public BirthPlace placeOfBirth { get; set; }

        [JsonPropertyName("motherNameAtBirth")]
        public DemographicsName motherNameAtBirth { get; set; }

        [JsonPropertyName("motherDateOfBirth")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime motherDateOfBirth { get; set; }

        [JsonPropertyName("motherPlaceOfBirth")]
        public BirthPlace motherPlaceOfBirth { get; set; }

        [JsonPropertyName("dateOfDeath")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime dateOfDeath { get; set; }
    }
}