using TornSharp.Classes;

namespace TornSharp.Functions {
    internal class PlayerBarsFunctions {
        internal static int UpdateBarPercentage(PlayerBar bar) { 
            return (int)((bar.CurrentValue * 100) / bar.MaxValue);
        }
    }
}
