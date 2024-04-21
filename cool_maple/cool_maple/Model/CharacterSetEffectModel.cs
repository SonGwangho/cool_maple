using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.Model
{
    public class CharacterSetEffectModel
    {
        [JsonProperty("set_effect")]
        public SetEffectModel[] SetEffect { get; set; }
    }

    public class SetEffectModel
    {
        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("total_set_count")]
        public uint TotalSetCount { get; set; }

        [JsonProperty("set_effect_info")]
        public SetEffectInfoModel[] SetEffectInfo { get; set; }
    }

    public class SetEffectInfoModel
    {
        [JsonProperty("set_count")]
        public uint SetCount { get; set; }

        [JsonProperty("set_option")]
        public string SetOption { get; set; }
    }
}
