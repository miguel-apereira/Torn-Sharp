using System.Globalization;
using System.Runtime.CompilerServices;

namespace TornSharp.Classes {
    internal class PlayerInfo {
        internal int? ID { get; set; }
        internal string? Name { get; set; }
        internal int? Level { get; set; }
        internal string? Gender { get; set; }
        internal string? State { get; set; }
        internal PlayerInfoMoney? Money { get; set; } = new PlayerInfoMoney();
    }

    internal class PlayerInfoMoney { 
        internal int? Points { get; set; }
        internal int? Wallet { get; set; }
        internal int? CaymanBank { get; set; }
        internal int? Company { get; set; }
        internal int? DailyNetworth { get; set; }
        internal int? Vault { get; set; }
        internal PlayerInfoCityBank? CityBank { get; set; } = new PlayerInfoCityBank();
    }

    internal class PlayerInfoCityBank {
        internal int? Amount { get; set; }
        internal int? InvestDuration { get; set; }
        internal float? InvestRate { get; set; }
        internal int? Profit { get; set; }
        internal long? InvestedAt { get; set; }
        internal long? InvestDueDate { get; set; }
    }

    internal static class PlayerInfoExtensions {
        /// <summary>
        /// Converts an Int number to Torn's currency.
        /// </summary>
        /// <returns>String formatted currency (ex: $1,234).</returns>
        internal static string? ConvertToCurrency(this int? amount) {
            return amount?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
        }

        /// <summary>
        /// Converts an Int number to Bank Duration string.
        /// </summary>
        /// <returns>String formatted Bank investment duration (ex: 1 day / 7 days).</returns>
        internal static string? ToStringBankDuration(this int? days) {
            string result = days > 1 ? "days" : "day";
            return $"{days.ToString()} {result}";
        }

        /// <summary>
        /// Converts a Unix timestamp to a DateTime object.
        /// </summary>
        /// <returns>DateTime object.</returns>
        internal static DateTime TimestampToDateTime(this long? timestamp) {
            DateTime result = DateTimeOffset.FromUnixTimeSeconds((long)timestamp).DateTime;
            return result;
        }
    }


}