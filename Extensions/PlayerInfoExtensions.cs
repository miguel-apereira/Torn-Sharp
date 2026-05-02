using System.Globalization;


namespace TornSharp.Extensions {
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
