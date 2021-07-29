// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model.Client;

namespace PortableEHRNetSDK.Network.Client.Response.Patient
{
    public class PatientReachabilityResponseContent : FeedHubApiResponseContent
    {
        [JsonIgnore] public PatientReachability patientReachability { get; set; }

        [JsonPropertyName("patientId")]
        public string? patientId
        {
            get => patientReachability == null ? null : patientReachability.patientId;
            set
            {
                if (value == null)
                {
                    patientReachability = null;
                }
                else
                {
                    if (patientReachability == null)
                        patientReachability = new PatientReachability();
                    patientReachability.patientId = value;
                }
            }
        }

        [JsonPropertyName("isReachable")]
        public bool? isReachable
        {
            get => patientReachability == null ? null : patientReachability.isReachable;
            set
            {
                if (value == null)
                {
                    patientReachability = null;
                }
                else
                {
                    if (patientReachability == null)
                        patientReachability = new PatientReachability();
                    patientReachability.isReachable = value.Value;
                }
            }
        }
    }
}