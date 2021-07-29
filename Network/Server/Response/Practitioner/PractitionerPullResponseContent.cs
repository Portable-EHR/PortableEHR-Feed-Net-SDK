// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network.Server.Response.Practitioner
{
    [JsonConverter(typeof(PractitionerPullResponseContentConverter))]
    public class PractitionerPullResponseContent : FeedApiResponseContent
    {
    }
}