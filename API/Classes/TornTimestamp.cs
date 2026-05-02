using Newtonsoft.Json;

namespace TornSharp.API.Classes {
    public class ApiTornTimestamp {
        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }
    }
}
