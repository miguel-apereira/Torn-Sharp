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

        private void MainWindow_Load(object sender, EventArgs e) {
            this.Text = "TornSharp Overview - " + ProductVersion;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
