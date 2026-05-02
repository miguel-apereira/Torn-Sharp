using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TornSharp.API.Classes {
    public class ApiUserMoney {
        [JsonProperty("points")]
        public int? Points { get; set; }
        [JsonProperty("wallet")]
        public int? Wallet { get; set; }
        [JsonProperty("company")]
        public int? Company { get; set; }
        [JsonProperty("vault")]
        public int? Vault { get; set; }
        [JsonProperty("cayman_bank")]
        public int? CaymanBank { get; set; }
        [JsonProperty("daily_networth")]
        public int? DailyNetworth { get; set; }
        [JsonProperty("city_bank")]
        public ApiUserMoneyCityBank? CityBank { get; set; }
        [JsonProperty("faction")]
        public ApiUserMoneyFaction? Faction { get; set; }
    }
    public class ApiUserMoneyCityBank {
        [JsonProperty("amount")]
        public int? Amount { get; set; }
        [JsonProperty("profit")]
        public int? Profit { get; set; }
        [JsonProperty("duration")]
        public int? Duration { get; set; }
        [JsonProperty("interest_rate")]
        public float? InterestRate { get; set; }
        [JsonProperty("until")]
        public int? Until { get; set; }
        [JsonProperty("invested_at")]
        public int? InvestedDate { get; set; }
    }

    public class ApiUserMoneyFaction {
        [JsonProperty("money")]
        public int? Money { get; set; }
        [JsonProperty("points")]
        public int? Points { get; set; }
    }
}
