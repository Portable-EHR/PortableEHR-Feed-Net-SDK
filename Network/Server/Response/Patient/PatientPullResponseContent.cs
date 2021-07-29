// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network.Server.Response.Patient
{
    [JsonConverter(typeof(PatientPullResponseContentConverter))]
    public class PatientPullResponseContent : FeedApiResponseContent
    {
    }
}