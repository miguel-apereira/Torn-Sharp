using System.Reflection;
using TornSharp.Forms;
using TornSharp.Functions;
using TornSharp.Settings;

namespace TornSharp {
    public partial class Startup : Form {
        public Startup() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            HelpFunctions.OpenBrowserURL("https://www.torn.com/preferences.php#tab=api");
        }

        private async void button1_Click(object sender, EventArgs e) {
            UserSettings.Default.ApiKey = textBox1.Text;
            AppSettings.SaveSettings();
            CheckAPIKey();
        }

        private void Startup_Load(object sender, EventArgs e) {
            this.Text = "Startup - TornSharp " + ProductVersion;

            if (UserSettings.Default.AutoSignin) {
                SkipStartup();
            }
            else {
                textBox1.Text = UserSettings.Default.ApiKey;
                checkBox1.Checked = UserSettings.Default.AutoSignin;

                if (textBox1.Text == "" || textBox1.Text == null) {
                    button1.Text = "Save";
                }
                else {
                    button1.Text = "Continue";
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            UserSettings.Default.AutoSignin = checkBox1.Checked;
            AppSettings.SaveSettings();
        }

        private void SkipStartup() {
            if (UserSettings.Default.ApiKey != "" && UserSettings.Default.ApiKey != null) {
                CheckAPIKey();
            }
            else {
                TornSharpError.ThrowError("No API key found. Please enter your API key to continue.");
                this.Show();
                checkBox1.Checked = true;
                UserSettings.Default.AutoSignin = true;
                AppSettings.SaveSettings();
            }
        }

        private async void CheckAPIKey() {
            var UserBasicInfo = await API.User.GetBasicInfo();

            if (UserBasicInfo == null) {
                TornSharpError.ThrowError("Invalid API key. Please check your API key and try again.");
                this.Show();
                checkBox1.Checked = true;
                UserSettings.Default.AutoSignin = true;
                AppSettings.SaveSettings();
            }
            else {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
        }
    }
}
