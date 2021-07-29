// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Patient
{
    public class PatientPullBundleResponseContent : PatientPullResponseContent
    {
        [JsonPropertyName("offset")] public int offset { get; set; }

        [JsonPropertyName("hasMore")] public bool hasMore { get; set; }

        [JsonPropertyName("results")] public List<Model.Server.Patient> results { get; set; }
    }
}