// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Network.Server.Response.Privatemessage
{
    public class PrivateMessageContentResponseContent : FeedApiResponseContent
    {
        [JsonIgnore] public PrivateMessageContent privateMessageContent { get; set; }

        [JsonPropertyName("messageContext")]
        public string? messageContext
        {
            get => privateMessageContent == null ? null : privateMessageContent.messageContext;
            set
            {
                if (value == null)
                {
                    privateMessageContent = null;
                }
                else
                {
                    if (privateMessageContent == null)
                        privateMessageContent = new PrivateMessageContent();
                    privateMessageContent.messageContext = value;
                }
            }
        }

        [JsonPropertyName("subject")]
        public string? subject
        {
            get => privateMessageContent == null ? null : privateMessageContent.subject;
            set
            {
                if (value == null)
                {
                    privateMessageContent = null;
                }
                else
                {
                    if (privateMessageContent == null)
                        privateMessageContent = new PrivateMessageContent();
                    privateMessageContent.subject = value;
                }
            }
        }

        [JsonPropertyName("text")]
        public string? text
        {
            get => privateMessageContent == null ? null : privateMessageContent.text;
            set
            {
                if (value == null)
                {
                    privateMessageContent = null;
                }
                else
                {
                    if (privateMessageContent == null)
                        privateMessageContent = new PrivateMessageContent();
                    privateMessageContent.text = value;
                }
            }
        }

        [JsonPropertyName("attachments")]
        public List<PrivateMessageAttachment>? attachments
        {
            get => privateMessageContent == null ? null : privateMessageContent.attachments;
            set
            {
                if (value == null)
                {
                    privateMessageContent = null;
                }
                else
                {
                    if (privateMessageContent == null)
                        privateMessageContent = new PrivateMessageContent();
                    privateMessageContent.attachments = value;
                }
            }
        }
    }
}