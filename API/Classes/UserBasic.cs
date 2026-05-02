using Newtonsoft.Json;

namespace TornSharp.API.Classes {
    public class ApiUserBasic {
        [JsonProperty("id")]
        public int? ID { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("level")]
        public int? Level { get; set; }
        [JsonProperty("gender")]
        public string? Gender { get; set; }
        [JsonProperty("status")]
        public ApiUserBasicStatus? Status { get; set; }
    }
    public class ApiUserBasicStatus {
        [JsonProperty("description")]
        public string? Description { get; set; }
        [JsonProperty("details")]
        public string? Details { get; set; }
        [JsonProperty("state")]
        public string? State { get; set; }
        [JsonProperty("color")]
        public string? Color { get; set; }
        [JsonProperty("until")]
        public int? Until { get; set; }
    }
}
