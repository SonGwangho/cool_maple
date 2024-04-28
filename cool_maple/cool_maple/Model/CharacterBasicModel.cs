using Newtonsoft.Json;

namespace cool_maple.Model
{
    public class CharacterBasicModel
    {
        [JsonProperty("character_name")]
        public string CharacterName { get; set; }

        [JsonProperty("world_name")]
        public string WorldName { get; set; }

        [JsonProperty("character_gender")]
        public string CharacterGender { get; set; }

        [JsonProperty("character_class")]
        public string CharacterClass { get; set; }

        [JsonProperty("character_class_level")]
        public uint CharacterClassLevel { get; set; }

        [JsonProperty("character_level")]
        public uint CharacterLevel { get; set; }

        [JsonProperty("character_exp")]
        public ulong CharacterExp { get; set; }

        [JsonProperty("character_exp_rate")]
        public float CharacterExpRate { get; set; }

        [JsonProperty("character_guild_name")]
        public string CharacterGuildName { get; set; }

        [JsonProperty("character_image")]
        public string CharacterImageUrl { get; set; }

    }
}
