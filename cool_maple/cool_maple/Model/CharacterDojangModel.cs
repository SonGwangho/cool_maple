using Newtonsoft.Json;

namespace cool_maple.Model
{
    public class CharacterDojangModel
    {
        [JsonProperty("character_class")]
        public string CharacterClass { get; set; }

        [JsonProperty("world_name")]
        public string WorldName { get; set; }

        [JsonProperty("dojang_best_floor")]
        public int DojangBestFloor { get; set; }

        [JsonProperty("date_dojang_record")]
        public DateTime DateDojangRecord { get; set; }

        [JsonProperty("dojang_best_time")]
        public int DojangBestTime { get; set; }
    }
}
