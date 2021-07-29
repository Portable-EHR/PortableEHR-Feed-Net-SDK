// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Network.Server.Response.Privatemessage
{
    public class PrivateMessageContentResponse : FeedApiResponse
    {
        [JsonPropertyName("responseContent")]
        public new PrivateMessageContentResponseContent responseContent { get; set; }
    }
}