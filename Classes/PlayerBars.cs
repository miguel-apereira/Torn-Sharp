
namespace TornSharp.Classes {
    internal abstract class PlayerBar {
        internal int? Percentage { get; set; }
        internal int? CurrentValue { get; set; }
        internal int? MaxValue { get; set; }
        internal int? Increment { get; set; }
        internal int? IncrementCooldownSeconds { get; set; }
        internal int? ReceiveIncrementInSeconds { get; set; }
        internal int? FullAtSeconds { get; set; }
    }
    internal class EnergyBar : PlayerBar { internal string Type { get; } = "Energy"; }
    internal class NerveBar : PlayerBar { internal string Type { get; } = "Nerve"; }
    internal class HappyBar : PlayerBar { internal string Type { get; } = "Happy"; }
    internal class LifeBar : PlayerBar { internal string Type { get; } = "Life"; }
}
