using System.Globalization;

using TornSharp.API.Classes;
using TornSharp.Classes;
using TornSharp.Functions;

namespace TornSharp.Forms {
    public partial class MainWindow : Form {
        // This variable will hold the initial server timestamp we get from the API, we will use it
        // to calculate the server time withoutmaking an API call every second
        static long ServerTimestamp;
        // This variable will hold the due date of the City Bank Investment, we will use it to calculate the time remaining for the investment
        static DateTime CityBankInvestmentDueDate;

        static PlayerInfo playerInfo = new PlayerInfo();

        static EnergyBar playerEnergyBar = new EnergyBar();
        static NerveBar playerNerveBar = new NerveBar();
        static HappyBar playerHappyBar = new HappyBar();
        static LifeBar playerLifeBar = new LifeBar();

        public MainWindow() {
            InitializeComponent();
        }

        internal void LoadData() {

        }

        internal async void GetBasicInfo() {

            ApiUserBasic userBasicInfo = await API.User.GetUserBasic();

            playerInfo.Name = userBasicInfo.Name;
            playerInfo.ID = userBasicInfo.ID;
            playerInfo.Level = userBasicInfo.Level;
            playerInfo.State = userBasicInfo.Status.State;
            playerInfo.Gender = userBasicInfo.Gender;


            ApiUserBars userBars = await API.User.GetUserBars();

            playerEnergyBar.CurrentValue = userBars.Energy.Current;
            playerEnergyBar.MaxValue = userBars.Energy.Maximum;
            playerEnergyBar.Increment = userBars.Energy.Increment;
            playerEnergyBar.IncrementCooldownSeconds = userBars.Energy.Interval;
            playerEnergyBar.ReceiveIncrementInSeconds = userBars.Energy.TickTime;
            playerEnergyBar.FullAtSeconds = userBars.Energy.FullTime;
            playerEnergyBar.Percentage = (int)((userBars.Energy.Current * 100) / userBars.Energy.Maximum);

            playerNerveBar.CurrentValue = userBars.Nerve.Current;
            playerNerveBar.MaxValue = userBars.Nerve.Maximum;
            playerNerveBar.Increment = userBars.Nerve.Increment;
            playerNerveBar.IncrementCooldownSeconds = userBars.Nerve.Interval;
            playerNerveBar.ReceiveIncrementInSeconds = userBars.Nerve.TickTime;
            playerNerveBar.FullAtSeconds = userBars.Nerve.FullTime;
            playerNerveBar.Percentage = (int)((userBars.Nerve.Current * 100) / userBars.Nerve.Maximum);

            playerHappyBar.CurrentValue = userBars.Happy.Current;
            playerHappyBar.MaxValue = userBars.Happy.Maximum;
            playerHappyBar.Increment = userBars.Happy.Increment;
            playerHappyBar.IncrementCooldownSeconds = userBars.Happy.Interval;
            playerHappyBar.ReceiveIncrementInSeconds = userBars.Happy.TickTime;
            playerHappyBar.FullAtSeconds = userBars.Happy.FullTime;
            playerHappyBar.Percentage = (int)((userBars.Happy.Current * 100) / userBars.Happy.Maximum);

            playerLifeBar.CurrentValue = userBars.Life.Current;
            playerLifeBar.MaxValue = userBars.Life.Maximum;
            playerLifeBar.Increment = userBars.Life.Increment;
            playerLifeBar.IncrementCooldownSeconds = userBars.Life.Interval;
            playerLifeBar.ReceiveIncrementInSeconds = userBars.Life.TickTime;
            playerLifeBar.FullAtSeconds = userBars.Life.FullTime;
            playerLifeBar.Percentage = (int)((userBars.Life.Current * 100) / userBars.Life.Maximum);


            ApiUserMoney userMoney = await API.User.GetUserMoney();

            ApiTornTimestamp serverTimestamp = await API.Torn.GetTornTimestamp();
            ServerTimestamp = (long)serverTimestamp.Timestamp;
            timerServerTime.Start(); // Start the timer that updates the server time in the status bar

            // Player Groupbox
            
            labelPlayerID.Text = playerInfo.ID.ToString();
            labelPlayerName.Text = playerInfo.Name;
            labelPlayerLevel.Text = playerInfo.Level.ToString();
            labelPlayerGender.Text = playerInfo.Gender;
            labelPlayerStatus.Text = playerInfo.State;

            energyBar.Value = (int)playerEnergyBar.Percentage;
            labelEnergyCounter.Text = $"{playerEnergyBar.CurrentValue}/{playerEnergyBar.MaxValue}";

            nerveBar.Value = (int)playerNerveBar.Percentage;
            labelNerveCounter.Text = $"{playerNerveBar.CurrentValue}/{playerNerveBar.MaxValue}";

            happyBar.Value = (int)playerHappyBar.Percentage;
            labelHappyCounter.Text = $"{playerHappyBar.CurrentValue}/{playerHappyBar.MaxValue}";

            lifeBar.Value = (int)playerLifeBar.Percentage;
            labelLifeCounter.Text = $"{playerLifeBar.CurrentValue}/{playerLifeBar.MaxValue}";


            labelPlayerPoints.Text = userMoney.Points.ToString();
            labelPlayerWallet.Text = userMoney.Wallet?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));

            // Financial Tab

            labelFinancialDailyNetworth.Text = userMoney.DailyNetworth?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            labelFinancialWallet.Text = userMoney.Wallet?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            labelFinancialCaymanBank.Text = userMoney.CaymanBank?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            labelFinancialCompany.Text = userMoney.Company?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            labelFinancialHomeVault.Text = userMoney.Vault?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));

            labelFinancialCityBankInv.Text = userMoney.CityBank.Amount?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));
            labelFinancialInvDuration.Text = $"{userMoney.CityBank.Duration?.ToString()} days";

            DateTime citybankInvestedDate = DateTimeOffset.FromUnixTimeSeconds((long)userMoney.CityBank.InvestedDate).DateTime;
            labelFinancialInvAtDate.Text = citybankInvestedDate.ToString();

            DateTime citybankInvestmentDueDate = DateTimeOffset.FromUnixTimeSeconds((long)userMoney.CityBank.Until).DateTime;
            labelFinancialInvDueDate.Text = citybankInvestmentDueDate.ToString();
            CityBankInvestmentDueDate = citybankInvestmentDueDate;
            timerInvestmentTimeRemaining.Start(); // Start the timer that updates the time remaining for the City Bank Investment

            labelFinancialInvRate.Text = $"{userMoney.CityBank.InterestRate?.ToString()}%";
            labelFinancialInvProfit.Text = userMoney.CityBank.Profit?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));

            timerUpdatePlayerBars.Start();

        }

        private async void MainWindow_Load(object sender, EventArgs e) {
            this.Text = $"TornSharp Overview - v{ProductVersion}";
            GetBasicInfo();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e) {
            GetBasicInfo();
        }

        private void timerInvestmentTimeRemaining_Tick(object sender, EventArgs e) {
            // This Timer Updates the Time Remaining for the City Bank Investment every second, it calculates the time remaining by
            // subtracting the current time from the investment due date

            TimeSpan timeRemaining = CityBankInvestmentDueDate - DateTime.Now;
            if (timeRemaining.Ticks < 0) {
                labelFinancialInvTimeRemaining.Text = "Investment has matured.";
            }
            else {
                labelFinancialInvTimeRemaining.Text = $"{timeRemaining.Days}d, {timeRemaining.Hours}h {timeRemaining.Minutes}m {timeRemaining.Seconds}s";
            }
        }

        private void timerServerTime_Tick(object sender, EventArgs e) {
            // This Timer Updates the Server Time in the Status Bar every second, it uses the initial timestamp we got from the API
            // and adds 1 second to it every tick, this way we don't have to make an API call every second to get the server time

            DateTime serverTime = DateTimeOffset.FromUnixTimeSeconds(ServerTimestamp).DateTime;
            string ServerTime = serverTime.ToString("dd/MM/yyyy - HH:mm:ss");
            statusBarServerTime.Text = $"Server Time: {ServerTime}";
            ServerTimestamp += 1;
        }

        private void timerUpdatePlayerBars_Tick(object sender, EventArgs e) {
            DateTime energyBarNextIncrement = DateTime.Now.AddSeconds((int)playerEnergyBar.ReceiveIncrementInSeconds);
            TimeSpan timeUntilEnergyBarIncrement = energyBarNextIncrement - DateTime.Now;
            labelReceiveEnergyIn.Text = $"{timeUntilEnergyBarIncrement.Minutes}:{timeUntilEnergyBarIncrement.Seconds:D2}";
            playerEnergyBar.ReceiveIncrementInSeconds -= 1;

            if (playerEnergyBar.ReceiveIncrementInSeconds <= 0) {
                playerEnergyBar.ReceiveIncrementInSeconds = playerEnergyBar.IncrementCooldownSeconds;
                playerEnergyBar.CurrentValue += playerEnergyBar.Increment;
                labelEnergyCounter.Text = $"{playerEnergyBar.CurrentValue}/{playerEnergyBar.MaxValue}";
                energyBar.Value = PlayerBarsFunctions.UpdateBarPercentage(playerEnergyBar);
            }

            DateTime nerveBarNextIncrement = DateTime.Now.AddSeconds((int)playerNerveBar.ReceiveIncrementInSeconds);
            TimeSpan timeUntilNerveBarIncrement = nerveBarNextIncrement - DateTime.Now;
            labelReceiveNerveIn.Text = $"{timeUntilNerveBarIncrement.Minutes}:{timeUntilNerveBarIncrement.Seconds:D2}";
            playerNerveBar.ReceiveIncrementInSeconds -= 1;

            if (playerNerveBar.ReceiveIncrementInSeconds <= 0) {
                playerNerveBar.ReceiveIncrementInSeconds = playerNerveBar.IncrementCooldownSeconds;
                playerNerveBar.CurrentValue += playerNerveBar.Increment;
                labelNerveCounter.Text = $"{playerNerveBar.CurrentValue}/{playerNerveBar.MaxValue}";
                nerveBar.Value = PlayerBarsFunctions.UpdateBarPercentage(playerNerveBar);
            }

            DateTime happyBarNextIncrement = DateTime.Now.AddSeconds((int)playerHappyBar.ReceiveIncrementInSeconds);
            TimeSpan timeUntilHappyBarIncrement = happyBarNextIncrement - DateTime.Now;
            labelReceiveHappyIn.Text = $"{timeUntilHappyBarIncrement.Minutes}:{timeUntilHappyBarIncrement.Seconds:D2}";
            playerHappyBar.ReceiveIncrementInSeconds -= 1;

            if (playerHappyBar.ReceiveIncrementInSeconds <= 0) {
                playerHappyBar.ReceiveIncrementInSeconds = playerHappyBar.IncrementCooldownSeconds;
                playerHappyBar.CurrentValue += playerHappyBar.Increment;
                labelHappyCounter.Text = $"{playerHappyBar.CurrentValue}/{playerHappyBar.MaxValue}";
                happyBar.Value = PlayerBarsFunctions.UpdateBarPercentage(playerHappyBar);
            }

            DateTime lifeBarNextIncrement = DateTime.Now.AddSeconds((int)playerLifeBar.ReceiveIncrementInSeconds);
            TimeSpan timeUntilLifeBarIncrement = lifeBarNextIncrement - DateTime.Now;
            labelReceiveLifeIn.Text = $"{timeUntilLifeBarIncrement.Minutes}:{timeUntilLifeBarIncrement.Seconds:D2}";
            playerLifeBar.ReceiveIncrementInSeconds -= 1;

            if (playerLifeBar.ReceiveIncrementInSeconds <= 0) {
                playerLifeBar.ReceiveIncrementInSeconds = playerLifeBar.IncrementCooldownSeconds;
                playerLifeBar.CurrentValue += playerLifeBar.Increment;
                labelLifeCounter.Text = $"{playerLifeBar.CurrentValue}/{playerLifeBar.MaxValue}";
                lifeBar.Value = PlayerBarsFunctions.UpdateBarPercentage(playerLifeBar);
            }
        }
    }
}
