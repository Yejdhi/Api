﻿using Newtonsoft.Json;

namespace ProjectEarthServerAPI.Models
{
    public class Rewards
    {
        [JsonProperty("experiencePoints")]
        public int? ExperiencePoints { get; set; }
        [JsonProperty("inventory")]
        public RewardComponent[] Inventory { get; set; }
        [JsonProperty("buildplates")]
        public RewardComponent[] Buildplates { get; set; }
        [JsonProperty("challenges")]
        public RewardComponent[] Challenges { get; set; }
        [JsonProperty("personaItems")]
        public RewardComponent[] PersonaItems { get; set; }
        [JsonProperty("utilityBlocks")]
        public RewardComponent[] UtilityBlocks { get; set; }
    }

    public class RewardComponent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}