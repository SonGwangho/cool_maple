using Newtonsoft.Json;

namespace cool_maple.Model
{
    public class CharacterStatModel
    {
        [JsonProperty("character_class")]
        public string CharacterClass { get; set; }

        [JsonProperty("final_stat")]
        public FinalStatModel[] FinalStat { get; set; }

        [JsonProperty("remain_ap")]
        public uint RemainAp { get; set; }
    }

    public class FinalStatModel
    {
        [JsonProperty("stat_name")]
        public string StatName { get; set; }

        [JsonProperty("stat_value")]
        public decimal StatValue { get; set; }
    }
}
