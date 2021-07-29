// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network.Server.Request.Appointment
{
    [JsonConverter(typeof(AppointmentPullParametersConverter))]
    public class AppointmentPullParameters : FeedHubRequestParameters
    {
    }
}