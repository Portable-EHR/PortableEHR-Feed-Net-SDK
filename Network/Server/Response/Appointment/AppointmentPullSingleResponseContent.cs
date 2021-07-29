// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Response.Appointment
{
    public class AppointmentPullSingleResponseContent : AppointmentPullResponseContent
    {
        [JsonIgnore] public Model.Server.Appointment result { get; set; }

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
                        result = new Model.Server.Appointment();
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
                        result = new Model.Server.Appointment();
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
                        result = new Model.Server.Appointment();
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
                        result = new Model.Server.Appointment();
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
                        result = new Model.Server.Appointment();
                    result.feedItemVersion = value.Value;
                }
            }
        }

        [JsonPropertyName("id")]
        public string? id
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
                        result = new Model.Server.Appointment();
                    result.id = value;
                }
            }
        }

        [JsonPropertyName("patientId")]
        public string? patientId
        {
            get => result == null ? null : result.patientId;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.patientId = value;
                }
            }
        }

        [JsonPropertyName("practitionerId")]
        public string? practitionerId
        {
            get => result == null ? null : result.practitionerId;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.practitionerId = value;
                }
            }
        }

        [JsonPropertyName("location")]
        public AppointmentLocationEnum? location
        {
            get => result == null ? null : result.location;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.location = value;
                }
            }
        }

        [JsonPropertyName("with")]
        public string? with
        {
            get => result == null ? null : result.with;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.with = value;
                }
            }
        }

        [JsonPropertyName("startTime")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime? startTime
        {
            get => result == null ? null : result.startTime;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.startTime = value.Value;
                }
            }
        }

        [JsonPropertyName("endTime")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime? endTime
        {
            get => result == null ? null : result.endTime;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.endTime = value.Value;
                }
            }
        }

        [JsonPropertyName("description")]
        public string? description
        {
            get => result == null ? null : result.description;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.description = value;
                }
            }
        }

        [JsonPropertyName("notes")]
        public string? notes
        {
            get => result == null ? null : result.notes;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.notes = value;
                }
            }
        }

        [JsonPropertyName("patientMustConfirm")]
        public bool? patientMustConfirm
        {
            get => result == null ? null : result.patientMustConfirm;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.patientMustConfirm = value.Value;
                }
            }
        }

        [JsonPropertyName("confirmationStatus")]
        public AppointmentConfirmationStatusEnum? confirmationStatus
        {
            get => result == null ? null : result.confirmationStatus;
            set
            {
                if (value == null)
                {
                    result = null;
                }
                else
                {
                    if (result == null)
                        result = new Model.Server.Appointment();
                    result.confirmationStatus = value;
                }
            }
        }
    }
}