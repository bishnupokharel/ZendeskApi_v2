﻿// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZendeskApi_v2.Models.Topics
{

    public class TopicSubscription
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("topic_id")]
        public long TopicId { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
