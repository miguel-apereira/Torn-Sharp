using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TornSharp.API;
using TornSharp.API.Classes;

namespace TornSharp.Forms {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        internal async void GetBasicInfo() {
            ApiUserBasic userBasicInfo = await API.User.GetUserBasic();
            ApiUserBars userBars = await API.User.GetUserBars();

            labelPlayerID.Text = userBasicInfo.ID.ToString();
            labelPlayerName.Text = userBasicInfo.Name;
            labelPlayerLevel.Text = userBasicInfo.Level.ToString();
            labelPlayerGender.Text = userBasicInfo.Gender;
            labelPlayerStatus.Text = userBasicInfo.Status.Description;

            energyBar.Value = (int)((userBars.Energy.Current * 100) / userBars.Energy.Maximum);
            nerveBar.Value = (int)((userBars.Nerve.Current * 100) / userBars.Nerve.Maximum);
            happyBar.Value = (int)((userBars.Happy.Current * 100) / userBars.Happy.Maximum);
            lifeBar.Value = (int)((userBars.Life.Current * 100) / userBars.Life.Maximum);

        }

        private async void MainWindow_Load(object sender, EventArgs e) {
            this.Text = "TornSharp Overview - " + ProductVersion;
            GetBasicInfo();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

    }
}
