// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Response.Practitioner
{
    public class PractitionerPullSingleResponseContent : PractitionerPullResponseContent
    {
        [JsonIgnore] public Model.Server.Practitioner result { get; set; }

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
                        result = new Model.Server.Practitioner();
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
                        result = new Model.Server.Practitioner();
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
                        result = new Model.Server.Practitioner();
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
                        result = new Model.Server.Practitioner();
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
                        result = new Model.Server.Practitioner();
                    result.feedItemVersion = value.Value;
                }
            }
        }

        [JsonPropertyName("id")]
        public Guid? id
        {
            get => result == null ? null : result.id;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Practitioner();
                    result.id = value.Value;
                }
            }
        }

        [JsonPropertyName("firstName")]
        public string? firstName
        {
            get => result == null ? null : result.firstName;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Practitioner();
                    result.firstName = value;
                }
            }
        }

        [JsonPropertyName("lastName")]
        public string? lastName
        {
            get => result == null ? null : result.lastName;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Practitioner();
                    result.lastName = value;
                }
            }
        }

        [JsonPropertyName("middleName")]
        public string? middleName
        {
            get => result == null ? null : result.middleName;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Practitioner();
                    result.middleName = value;
                }
            }
        }

        [JsonPropertyName("practices")]
        public List<Practice>? practices
        {
            get => result == null ? null : result.practices;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Practitioner();
                    result.practices = value;
                }
            }
        }
    }
}