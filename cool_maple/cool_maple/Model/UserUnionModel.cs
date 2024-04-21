using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.Model
{
    public class UserUnionModel
    {
        [JsonProperty("union_level")]
        public uint UnionLevel { get; set; }

        [JsonProperty("union_grade")]
        public string UnionGrade { get; set; }

        [JsonProperty("union_artifact_level")]
        public uint UnionArtifactLevel { get; set; }

        [JsonProperty("union_artifact_exp")]
        public uint UnionArtifactExp { get; set; }

        [JsonProperty("union_artifact_point")]
        public uint UnionArtifactPoint { get; set; }
    }
}
