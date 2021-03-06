﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets
{
    public class TicketForm
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("end_user_visible")]
        public bool EndUserVisible { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("ticket_field_ids")]
        public IList<long> TicketFieldIds { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}