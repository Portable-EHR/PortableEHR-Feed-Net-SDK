// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Appointment
{
    public class AppointmentPullResponse : FeedApiResponse
    {
        [JsonPropertyName("responseContent")] public new AppointmentPullResponseContent responseContent { get; set; }
    }
}