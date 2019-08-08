using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RegularSeasonResults2018
{
    public class Team
    {
        [JsonProperty("team")]
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        [JsonProperty("league")]
        [JsonConverter(typeof(StringEnumConverter))]
        public League League { get; set; }

        [JsonProperty("division")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Division Division { get; set; }
    }
}
