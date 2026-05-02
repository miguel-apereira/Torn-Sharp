using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TornSharp.API.Classes {
    public class ApiUserBars {
        [JsonProperty("energy")]
        public ApiUserBarsEnergy? Energy { get; set; }
        [JsonProperty("nerve")]
        public ApiUserBarsNerve? Nerve { get; set; }
        [JsonProperty("happy")]
        public ApiUserBarsHappy? Happy { get; set; }
        [JsonProperty("life")]
        public ApiUserBarsLife? Life { get; set; }
    }


    public class ApiUserBarsEnergy {
        [JsonProperty("current")]
        public int? Current { get; set; }
        [JsonProperty("maximum")]
        public int? Maximum { get; set; }
        [JsonProperty("increment")]
        public int? Increment { get; set; }
        [JsonProperty("interval")]
        public int? Interval { get; set; }
        [JsonProperty("tick_time")]
        public int? TickTime { get; set; }
        [JsonProperty("full_time")]
        public int? FullTime { get; set; }
    }
    public class ApiUserBarsNerve {
        [JsonProperty("current")]
        public int? Current { get; set; }
        [JsonProperty("maximum")]
        public int? Maximum { get; set; }
        [JsonProperty("increment")]
        public int? Increment { get; set; }
        [JsonProperty("interval")]
        public int? Interval { get; set; }
        [JsonProperty("tick_time")]
        public int? TickTime { get; set; }
        [JsonProperty("full_time")]
        public int? FullTime { get; set; }
    }
    public class ApiUserBarsHappy {
        [JsonProperty("current")]
        public int? Current { get; set; }
        [JsonProperty("maximum")]
        public int? Maximum { get; set; }
        [JsonProperty("increment")]
        public int? Increment { get; set; }
        [JsonProperty("interval")]
        public int? Interval { get; set; }
        [JsonProperty("tick_time")]
        public int? TickTime { get; set; }
        [JsonProperty("full_time")]
        public int? FullTime { get; set; }
    }
    public class ApiUserBarsLife {
        [JsonProperty("current")]
        public int? Current { get; set; }
        [JsonProperty("maximum")]
        public int? Maximum { get; set; }
        [JsonProperty("increment")]
        public int? Increment { get; set; }
        [JsonProperty("interval")]
        public int? Interval { get; set; }
        [JsonProperty("tick_time")]
        public int? TickTime { get; set; }
        [JsonProperty("full_time")]
        public int? FullTime { get; set; }
    }
}
