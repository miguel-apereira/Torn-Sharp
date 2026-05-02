using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornSharp.Classes;

namespace TornSharp.Extensions {
    internal static class PlayerBarsExtensions {
        /// <summary>
        /// Set/Update the Tooltip text of a Player Bar.
        /// </summary>
        /// <returns>A formatted string containing the current value, max value, increment details, and time until full.</returns>
        internal static string SetTooltip(this PlayerBar bar, string barType) {
            TimeSpan incrementEvery = TimeSpan.FromSeconds((int)bar.IncrementCooldownSeconds);
            TimeSpan fullIn = DateTime.Now.AddSeconds((int)bar.FullAtSeconds) - DateTime.Now;

            string fullInString = fullIn.TotalSeconds > 0 ? $"Full in: {fullIn.Hours:D2}:{fullIn.Minutes:D2}:{fullIn.Seconds:D2}" : "Already full!";

            return $"{barType}: {bar.CurrentValue}/{bar.MaxValue}\n" +
                   $"Receive {bar.Increment} every {incrementEvery.Minutes} minutes\n" + 
                   fullInString;
        }

        /// <summary>
        /// Get the percentage of the Player Bar based on its current value and max value.
        /// </summary>
        /// <returns>An integer representing the percentage of the bar filled.</returns>
        internal static int GetBarPercentage(this PlayerBar bar) {
            return (int)((bar.CurrentValue * 100) / bar.MaxValue);
        }
    }
}
