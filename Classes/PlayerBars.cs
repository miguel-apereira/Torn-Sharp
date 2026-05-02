
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
    internal class EnergyBar : PlayerBar { }
    internal class NerveBar : PlayerBar { }
    internal class HappyBar : PlayerBar { }
    internal class LifeBar : PlayerBar { }
}
