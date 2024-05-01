using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.Model
{
    public class PopularityModel
    {
        [JsonProperty("popularity")]
        public int Popularity {  get; set; }
    }
}
