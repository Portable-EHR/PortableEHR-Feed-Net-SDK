// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Response.Patient
{
    public class PatientPullSingleResponseContent : PatientPullResponseContent
    {
        [JsonIgnore] public Model.Server.Patient result { get; set; }

        [JsonPropertyName("feedAlias")]
        public string? feedAlias
        {
            get => result == null ? null : result.feedAlias;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.feedAlias = value;
                }
            }
        }

        [JsonPropertyName("feedItemId")]
        public Guid? feedItemId
        {
            get => result == null ? null : result.feedItemId;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.feedItemId = value.Value;
                }
            }
        }

        [JsonPropertyName("backendItemId")]
        public Guid? backendItemId
        {
            get => result == null ? null : result.backendItemId;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.backendItemId = value.Value;
                }
            }
        }

        [JsonPropertyName("lastUpdated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime? lastUpdated
        {
            get => result == null ? null : result.lastUpdated;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.lastUpdated = value.Value;
                }
            }
        }

        [JsonPropertyName("feedItemVersion")]
        public int? feedItemVersion
        {
            get => result == null ? null : result.feedItemVersion;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.feedItemVersion = value.Value;
                }
            }
        }

        [JsonPropertyName("chartNumber")]
        public string? chartNumber
        {
            get => result == null ? null : result.chartNumber;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.chartNumber = value;
                }
            }
        }

        [JsonPropertyName("primaryFeedPractitionerId")]
        public string? primaryFeedPractitionerId
        {
            get => result == null ? null : result.primaryFeedPractitionerId;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.primaryFeedPractitionerId = value;
                }
            }
        }

        [JsonPropertyName("demographics")]
        public Demographics? demographics
        {
            get => result == null ? null : result.demographics;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.demographics = value;
                }
            }
        }

        [JsonPropertyName("identifiedBy")]
        public List<PatientLegitId>? identifiedBy
        {
            get => result == null ? null : result.identifiedBy;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.identifiedBy = value;
                }
            }
        }

        [JsonPropertyName("locatedWith")]
        public PatientLocatedWith? locatedWith
        {
            get => result == null ? null : result.locatedWith;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Patient();
                    result.locatedWith = value;
                }
            }
        }
    }
}