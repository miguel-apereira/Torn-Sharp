using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TornSharp.API;
using TornSharp.API.Classes;

namespace TornSharp.Forms {
    public partial class MainWindow : Form {
        static DateTime CityBankInvestmentDueDate;
        public MainWindow() {
            InitializeComponent();
        }

        internal async void GetBasicInfo() {
            ApiUserBasic userBasicInfo = await API.User.GetUserBasic();
            ApiUserBars userBars = await API.User.GetUserBars();
            ApiUserMoney userMoney = await API.User.GetUserMoney();

            // Player Groupbox

            labelPlayerID.Text = userBasicInfo.ID.ToString();
            labelPlayerName.Text = userBasicInfo.Name;
            labelPlayerLevel.Text = userBasicInfo.Level.ToString();
            labelPlayerGender.Text = userBasicInfo.Gender;
            labelPlayerStatus.Text = userBasicInfo.Status.Description;

            energyBar.Value = (int)((userBars.Energy.Current * 100) / userBars.Energy.Maximum);
            nerveBar.Value = (int)((userBars.Nerve.Current * 100) / userBars.Nerve.Maximum);
            happyBar.Value = (int)((userBars.Happy.Current * 100) / userBars.Happy.Maximum);
            lifeBar.Value = (int)((userBars.Life.Current * 100) / userBars.Life.Maximum);

            labelEnergyCounter.Text = $"{userBars.Energy.Current}/{userBars.Energy.Maximum}";
            labelNerveCounter.Text = $"{userBars.Nerve.Current}/{userBars.Nerve.Maximum}";
            labelHappyCounter.Text = $"{userBars.Happy.Current}/{userBars.Happy.Maximum}";
            labelLifeCounter.Text = $"{userBars.Life.Current}/{userBars.Life.Maximum}";

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
            timerInvestmentTimeRemaining.Start();

            labelFinancialInvRate.Text = $"{userMoney.CityBank.InterestRate?.ToString()}%";
            labelFinancialInvProfit.Text = userMoney.CityBank.Profit?.ToString("C0", CultureInfo.GetCultureInfo("en-US"));

        }

        private async void MainWindow_Load(object sender, EventArgs e) {
            this.Text = "TornSharp Overview - " + ProductVersion;
            GetBasicInfo();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e) {
            GetBasicInfo();
        }

        private void timerInvestmentTimeRemaining_Tick(object sender, EventArgs e) {
            TimeSpan timeRemaining = CityBankInvestmentDueDate - DateTime.Now;
            if (timeRemaining.Ticks < 0) {
                labelFinancialInvTimeRemaining.Text = "Investment has matured.";
            } else {
                labelFinancialInvTimeRemaining.Text = $"{timeRemaining.Days}d, {timeRemaining.Hours}h {timeRemaining.Minutes}m {timeRemaining.Seconds}s";
            }
        }
    }
}
