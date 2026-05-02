namespace TornSharp.Forms {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            labelPlayerName = new Label();
            groupBox1 = new GroupBox();
            labelPlayerWallet = new Label();
            label11 = new Label();
            labelPlayerPoints = new Label();
            label10 = new Label();
            labelLifeCounter = new Label();
            labelHappyCounter = new Label();
            labelNerveCounter = new Label();
            labelEnergyCounter = new Label();
            lifeBar = new TornSharp.CustomControls.ProfileBar();
            label9 = new Label();
            happyBar = new TornSharp.CustomControls.ProfileBar();
            label8 = new Label();
            nerveBar = new TornSharp.CustomControls.ProfileBar();
            label7 = new Label();
            energyBar = new TornSharp.CustomControls.ProfileBar();
            labelPlayerStatus = new Label();
            label6 = new Label();
            label5 = new Label();
            labelPlayerGender = new Label();
            label4 = new Label();
            labelPlayerLevel = new Label();
            label3 = new Label();
            labelPlayerID = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            financialTab = new TabPage();
            groupBox7 = new GroupBox();
            labelFinancialDailyNetworth = new Label();
            groupBox6 = new GroupBox();
            labelFinancialCaymanBank = new Label();
            groupBox5 = new GroupBox();
            labelFinancialHomeVault = new Label();
            groupBox4 = new GroupBox();
            labelFinancialCompany = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelFinancialInvProfit = new Label();
            label12 = new Label();
            labelFinancialCityBankInv = new Label();
            label17 = new Label();
            label13 = new Label();
            labelFinancialInvDuration = new Label();
            label14 = new Label();
            labelFinancialInvAtDate = new Label();
            label15 = new Label();
            labelFinancialInvDueDate = new Label();
            label18 = new Label();
            label16 = new Label();
            labelFinancialInvRate = new Label();
            labelFinancialInvTimeRemaining = new Label();
            groupBox2 = new GroupBox();
            labelFinancialWallet = new Label();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            overviewToolStripMenuItem = new ToolStripMenuItem();
            refreshDataToolStripMenuItem = new ToolStripMenuItem();
            timerInvestmentTimeRemaining = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            financialTab.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new Point(169, 24);
            labelPlayerName.Margin = new Padding(2, 0, 2, 0);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(62, 17);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "ABCDEFG";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(labelPlayerWallet);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(labelPlayerPoints);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(labelLifeCounter);
            groupBox1.Controls.Add(labelHappyCounter);
            groupBox1.Controls.Add(labelNerveCounter);
            groupBox1.Controls.Add(labelEnergyCounter);
            groupBox1.Controls.Add(lifeBar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(happyBar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nerveBar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(energyBar);
            groupBox1.Controls.Add(labelPlayerStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelPlayerGender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelPlayerLevel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelPlayerID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelPlayerName);
            groupBox1.Location = new Point(11, 27);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1079, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Profile";
            // 
            // labelPlayerWallet
            // 
            labelPlayerWallet.AutoSize = true;
            labelPlayerWallet.Location = new Point(703, 24);
            labelPlayerWallet.Margin = new Padding(2, 0, 2, 0);
            labelPlayerWallet.Name = "labelPlayerWallet";
            labelPlayerWallet.Size = new Size(36, 17);
            labelPlayerWallet.TabIndex = 25;
            labelPlayerWallet.Text = "0000";
            toolTip1.SetToolTip(labelPlayerWallet, "Warning: This money is not safe from being mugged!");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label11.Location = new Point(651, 24);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 17);
            label11.TabIndex = 24;
            label11.Text = "Wallet:";
            // 
            // labelPlayerPoints
            // 
            labelPlayerPoints.AutoSize = true;
            labelPlayerPoints.Location = new Point(611, 24);
            labelPlayerPoints.Margin = new Padding(2, 0, 2, 0);
            labelPlayerPoints.Name = "labelPlayerPoints";
            labelPlayerPoints.Size = new Size(36, 17);
            labelPlayerPoints.TabIndex = 23;
            labelPlayerPoints.Text = "0000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(558, 24);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 22;
            label10.Text = "Points:";
            // 
            // labelLifeCounter
            // 
            labelLifeCounter.AutoSize = true;
            labelLifeCounter.Location = new Point(687, 71);
            labelLifeCounter.Margin = new Padding(2, 0, 2, 0);
            labelLifeCounter.Name = "labelLifeCounter";
            labelLifeCounter.Size = new Size(27, 17);
            labelLifeCounter.TabIndex = 21;
            labelLifeCounter.Text = "0/0";
            // 
            // labelHappyCounter
            // 
            labelHappyCounter.AutoSize = true;
            labelHappyCounter.Location = new Point(509, 71);
            labelHappyCounter.Margin = new Padding(2, 0, 2, 0);
            labelHappyCounter.Name = "labelHappyCounter";
            labelHappyCounter.Size = new Size(27, 17);
            labelHappyCounter.TabIndex = 20;
            labelHappyCounter.Text = "0/0";
            // 
            // labelNerveCounter
            // 
            labelNerveCounter.AutoSize = true;
            labelNerveCounter.Location = new Point(328, 71);
            labelNerveCounter.Margin = new Padding(2, 0, 2, 0);
            labelNerveCounter.Name = "labelNerveCounter";
            labelNerveCounter.Size = new Size(27, 17);
            labelNerveCounter.TabIndex = 19;
            labelNerveCounter.Text = "0/0";
            // 
            // labelEnergyCounter
            // 
            labelEnergyCounter.AutoSize = true;
            labelEnergyCounter.Location = new Point(154, 71);
            labelEnergyCounter.Margin = new Padding(2, 0, 2, 0);
            labelEnergyCounter.Name = "labelEnergyCounter";
            labelEnergyCounter.Size = new Size(27, 17);
            labelEnergyCounter.TabIndex = 18;
            labelEnergyCounter.Text = "0/0";
            // 
            // lifeBar
            // 
            lifeBar.BackColor = SystemColors.ControlLight;
            lifeBar.Location = new Point(594, 49);
            lifeBar.Maximum = 100;
            lifeBar.Minimum = 0;
            lifeBar.Name = "lifeBar";
            lifeBar.ProgressBarColor = Color.CornflowerBlue;
            lifeBar.Size = new Size(120, 19);
            lifeBar.TabIndex = 17;
            lifeBar.Text = "Energy";
            lifeBar.Value = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(558, 48);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(31, 17);
            label9.TabIndex = 16;
            label9.Text = "Life:";
            // 
            // happyBar
            // 
            happyBar.BackColor = SystemColors.ControlLight;
            happyBar.Location = new Point(416, 49);
            happyBar.Maximum = 100;
            happyBar.Minimum = 0;
            happyBar.Name = "happyBar";
            happyBar.ProgressBarColor = Color.Gold;
            happyBar.Size = new Size(120, 19);
            happyBar.TabIndex = 15;
            happyBar.Text = "Energy";
            happyBar.Value = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(360, 48);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 14;
            label8.Text = "Happy:";
            // 
            // nerveBar
            // 
            nerveBar.BackColor = SystemColors.ControlLight;
            nerveBar.Location = new Point(235, 49);
            nerveBar.Maximum = 100;
            nerveBar.Minimum = 0;
            nerveBar.Name = "nerveBar";
            nerveBar.ProgressBarColor = Color.Tomato;
            nerveBar.Size = new Size(120, 19);
            nerveBar.TabIndex = 13;
            nerveBar.Text = "Energy";
            nerveBar.Value = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(186, 48);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 12;
            label7.Text = "Nerve:";
            // 
            // energyBar
            // 
            energyBar.BackColor = SystemColors.ControlLight;
            energyBar.Location = new Point(61, 49);
            energyBar.Maximum = 100;
            energyBar.Minimum = 0;
            energyBar.Name = "energyBar";
            energyBar.ProgressBarColor = Color.LimeGreen;
            energyBar.Size = new Size(120, 19);
            energyBar.TabIndex = 2;
            energyBar.Text = "Energy";
            energyBar.Value = 0;
            // 
            // labelPlayerStatus
            // 
            labelPlayerStatus.AutoSize = true;
            labelPlayerStatus.Location = new Point(492, 24);
            labelPlayerStatus.Margin = new Padding(2, 0, 2, 0);
            labelPlayerStatus.Name = "labelPlayerStatus";
            labelPlayerStatus.Size = new Size(62, 17);
            labelPlayerStatus.TabIndex = 10;
            labelPlayerStatus.Text = "ABCDEFG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(4, 48);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 11;
            label6.Text = "Energy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(439, 24);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 9;
            label5.Text = "Status:";
            // 
            // labelPlayerGender
            // 
            labelPlayerGender.AutoSize = true;
            labelPlayerGender.Location = new Point(373, 24);
            labelPlayerGender.Margin = new Padding(2, 0, 2, 0);
            labelPlayerGender.Name = "labelPlayerGender";
            labelPlayerGender.Size = new Size(62, 17);
            labelPlayerGender.TabIndex = 8;
            labelPlayerGender.Text = "ABCDEFG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(313, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // labelPlayerLevel
            // 
            labelPlayerLevel.AutoSize = true;
            labelPlayerLevel.Location = new Point(280, 24);
            labelPlayerLevel.Margin = new Padding(2, 0, 2, 0);
            labelPlayerLevel.Name = "labelPlayerLevel";
            labelPlayerLevel.Size = new Size(29, 17);
            labelPlayerLevel.TabIndex = 6;
            labelPlayerLevel.Text = "000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(235, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 5;
            label3.Text = "Level:";
            // 
            // labelPlayerID
            // 
            labelPlayerID.AutoSize = true;
            labelPlayerID.Location = new Point(32, 24);
            labelPlayerID.Margin = new Padding(2, 0, 2, 0);
            labelPlayerID.Name = "labelPlayerID";
            labelPlayerID.Size = new Size(57, 17);
            labelPlayerID.TabIndex = 4;
            labelPlayerID.Text = "0000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(4, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(93, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(financialTab);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 133);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1079, 558);
            tabControl1.TabIndex = 2;
            // 
            // financialTab
            // 
            financialTab.Controls.Add(groupBox7);
            financialTab.Controls.Add(groupBox6);
            financialTab.Controls.Add(groupBox5);
            financialTab.Controls.Add(groupBox4);
            financialTab.Controls.Add(groupBox3);
            financialTab.Controls.Add(groupBox2);
            financialTab.Location = new Point(4, 26);
            financialTab.Name = "financialTab";
            financialTab.Padding = new Padding(3);
            financialTab.Size = new Size(1071, 528);
            financialTab.TabIndex = 0;
            financialTab.Text = "Financial";
            financialTab.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(labelFinancialDailyNetworth);
            groupBox7.Location = new Point(6, 6);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(388, 76);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Daily Networth";
            // 
            // labelFinancialDailyNetworth
            // 
            labelFinancialDailyNetworth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFinancialDailyNetworth.AutoEllipsis = true;
            labelFinancialDailyNetworth.AutoSize = true;
            labelFinancialDailyNetworth.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialDailyNetworth.Location = new Point(6, 23);
            labelFinancialDailyNetworth.Name = "labelFinancialDailyNetworth";
            labelFinancialDailyNetworth.Size = new Size(203, 37);
            labelFinancialDailyNetworth.TabIndex = 4;
            labelFinancialDailyNetworth.Text = "000,000,000.00";
            labelFinancialDailyNetworth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(labelFinancialCaymanBank);
            groupBox6.Location = new Point(699, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(366, 76);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Cayman Bank";
            // 
            // labelFinancialCaymanBank
            // 
            labelFinancialCaymanBank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFinancialCaymanBank.AutoEllipsis = true;
            labelFinancialCaymanBank.AutoSize = true;
            labelFinancialCaymanBank.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialCaymanBank.Location = new Point(6, 23);
            labelFinancialCaymanBank.Name = "labelFinancialCaymanBank";
            labelFinancialCaymanBank.Size = new Size(203, 37);
            labelFinancialCaymanBank.TabIndex = 8;
            labelFinancialCaymanBank.Text = "000,000,000.00";
            labelFinancialCaymanBank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelFinancialHomeVault);
            groupBox5.Location = new Point(699, 88);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(366, 76);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Home Vault";
            // 
            // labelFinancialHomeVault
            // 
            labelFinancialHomeVault.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFinancialHomeVault.AutoEllipsis = true;
            labelFinancialHomeVault.AutoSize = true;
            labelFinancialHomeVault.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialHomeVault.Location = new Point(6, 23);
            labelFinancialHomeVault.Name = "labelFinancialHomeVault";
            labelFinancialHomeVault.Size = new Size(203, 37);
            labelFinancialHomeVault.TabIndex = 7;
            labelFinancialHomeVault.Text = "000,000,000.00";
            labelFinancialHomeVault.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelFinancialCompany);
            groupBox4.Location = new Point(400, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(293, 76);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Company";
            // 
            // labelFinancialCompany
            // 
            labelFinancialCompany.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFinancialCompany.AutoEllipsis = true;
            labelFinancialCompany.AutoSize = true;
            labelFinancialCompany.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialCompany.Location = new Point(6, 23);
            labelFinancialCompany.Name = "labelFinancialCompany";
            labelFinancialCompany.Size = new Size(203, 37);
            labelFinancialCompany.TabIndex = 6;
            labelFinancialCompany.Text = "000,000,000.00";
            labelFinancialCompany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Location = new Point(6, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 181);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "City Bank";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelFinancialInvProfit, 1, 7);
            tableLayoutPanel1.Controls.Add(label12, 0, 0);
            tableLayoutPanel1.Controls.Add(labelFinancialCityBankInv, 1, 0);
            tableLayoutPanel1.Controls.Add(label17, 0, 7);
            tableLayoutPanel1.Controls.Add(label13, 0, 1);
            tableLayoutPanel1.Controls.Add(labelFinancialInvDuration, 1, 1);
            tableLayoutPanel1.Controls.Add(label14, 0, 2);
            tableLayoutPanel1.Controls.Add(labelFinancialInvAtDate, 1, 2);
            tableLayoutPanel1.Controls.Add(label15, 0, 3);
            tableLayoutPanel1.Controls.Add(labelFinancialInvDueDate, 1, 3);
            tableLayoutPanel1.Controls.Add(label18, 0, 6);
            tableLayoutPanel1.Controls.Add(label16, 0, 4);
            tableLayoutPanel1.Controls.Add(labelFinancialInvRate, 1, 4);
            tableLayoutPanel1.Controls.Add(labelFinancialInvTimeRemaining, 1, 6);
            tableLayoutPanel1.Location = new Point(6, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(376, 148);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // labelFinancialInvProfit
            // 
            labelFinancialInvProfit.AutoSize = true;
            labelFinancialInvProfit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialInvProfit.ForeColor = Color.ForestGreen;
            labelFinancialInvProfit.Location = new Point(190, 121);
            labelFinancialInvProfit.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvProfit.Name = "labelFinancialInvProfit";
            labelFinancialInvProfit.Size = new Size(15, 17);
            labelFinancialInvProfit.TabIndex = 34;
            labelFinancialInvProfit.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label12.Location = new Point(2, 0);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(117, 17);
            label12.TabIndex = 26;
            label12.Text = "Amount Invested:";
            // 
            // labelFinancialCityBankInv
            // 
            labelFinancialCityBankInv.AutoSize = true;
            labelFinancialCityBankInv.Location = new Point(190, 0);
            labelFinancialCityBankInv.Margin = new Padding(2, 0, 2, 0);
            labelFinancialCityBankInv.Name = "labelFinancialCityBankInv";
            labelFinancialCityBankInv.Size = new Size(15, 17);
            labelFinancialCityBankInv.TabIndex = 26;
            labelFinancialCityBankInv.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label17.Location = new Point(2, 121);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(44, 17);
            label17.TabIndex = 33;
            label17.Text = "Profit:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label13.Location = new Point(2, 36);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(137, 17);
            label13.TabIndex = 27;
            label13.Text = "Investment Duration:";
            // 
            // labelFinancialInvDuration
            // 
            labelFinancialInvDuration.AutoSize = true;
            labelFinancialInvDuration.Location = new Point(190, 36);
            labelFinancialInvDuration.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvDuration.Name = "labelFinancialInvDuration";
            labelFinancialInvDuration.Size = new Size(15, 17);
            labelFinancialInvDuration.TabIndex = 28;
            labelFinancialInvDuration.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(2, 53);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(81, 17);
            label14.TabIndex = 29;
            label14.Text = "Invested At:";
            // 
            // labelFinancialInvAtDate
            // 
            labelFinancialInvAtDate.AutoSize = true;
            labelFinancialInvAtDate.Location = new Point(190, 53);
            labelFinancialInvAtDate.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvAtDate.Name = "labelFinancialInvAtDate";
            labelFinancialInvAtDate.Size = new Size(15, 17);
            labelFinancialInvAtDate.TabIndex = 30;
            labelFinancialInvAtDate.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label15.Location = new Point(2, 70);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(67, 17);
            label15.TabIndex = 31;
            label15.Text = "Due Date:";
            // 
            // labelFinancialInvDueDate
            // 
            labelFinancialInvDueDate.AutoSize = true;
            labelFinancialInvDueDate.Location = new Point(190, 70);
            labelFinancialInvDueDate.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvDueDate.Name = "labelFinancialInvDueDate";
            labelFinancialInvDueDate.Size = new Size(15, 17);
            labelFinancialInvDueDate.TabIndex = 32;
            labelFinancialInvDueDate.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label18.Location = new Point(2, 104);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(108, 17);
            label18.TabIndex = 35;
            label18.Text = "Time Remaining:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label16.Location = new Point(2, 87);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(89, 17);
            label16.TabIndex = 32;
            label16.Text = "Interest Rate:";
            // 
            // labelFinancialInvRate
            // 
            labelFinancialInvRate.AutoSize = true;
            labelFinancialInvRate.Location = new Point(190, 87);
            labelFinancialInvRate.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvRate.Name = "labelFinancialInvRate";
            labelFinancialInvRate.Size = new Size(15, 17);
            labelFinancialInvRate.TabIndex = 33;
            labelFinancialInvRate.Text = "0";
            // 
            // labelFinancialInvTimeRemaining
            // 
            labelFinancialInvTimeRemaining.AutoSize = true;
            labelFinancialInvTimeRemaining.Location = new Point(190, 104);
            labelFinancialInvTimeRemaining.Margin = new Padding(2, 0, 2, 0);
            labelFinancialInvTimeRemaining.Name = "labelFinancialInvTimeRemaining";
            labelFinancialInvTimeRemaining.Size = new Size(15, 17);
            labelFinancialInvTimeRemaining.TabIndex = 36;
            labelFinancialInvTimeRemaining.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelFinancialWallet);
            groupBox2.Location = new Point(400, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 76);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wallet";
            // 
            // labelFinancialWallet
            // 
            labelFinancialWallet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFinancialWallet.AutoEllipsis = true;
            labelFinancialWallet.AutoSize = true;
            labelFinancialWallet.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinancialWallet.Location = new Point(6, 23);
            labelFinancialWallet.Name = "labelFinancialWallet";
            labelFinancialWallet.Size = new Size(203, 37);
            labelFinancialWallet.TabIndex = 5;
            labelFinancialWallet.Text = "000,000,000.00";
            labelFinancialWallet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1071, 530);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { overviewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1101, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // overviewToolStripMenuItem
            // 
            overviewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshDataToolStripMenuItem });
            overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            overviewToolStripMenuItem.Size = new Size(68, 20);
            overviewToolStripMenuItem.Text = "Overview";
            // 
            // refreshDataToolStripMenuItem
            // 
            refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            refreshDataToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshDataToolStripMenuItem.Size = new Size(159, 22);
            refreshDataToolStripMenuItem.Text = "Refresh Data";
            refreshDataToolStripMenuItem.Click += refreshDataToolStripMenuItem_Click;
            // 
            // timerInvestmentTimeRemaining
            // 
            timerInvestmentTimeRemaining.Interval = 1000;
            timerInvestmentTimeRemaining.Tick += timerInvestmentTimeRemaining_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1101, 703);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TornSharp";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            financialTab.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label labelPlayerID;
        private Label label3;
        private Label labelPlayerLevel;
        private Label labelPlayerGender;
        private Label label4;
        private Label labelPlayerStatus;
        private Label label5;
        private Label label6;
        private CustomControls.ProfileBar energyBar;
        private CustomControls.ProfileBar nerveBar;
        private Label label7;
        private CustomControls.ProfileBar happyBar;
        private Label label8;
        private CustomControls.ProfileBar lifeBar;
        private Label label9;
        private Label labelHappyCounter;
        private Label labelNerveCounter;
        private Label labelEnergyCounter;
        private Label labelLifeCounter;
        private TabControl tabControl1;
        private TabPage financialTab;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label labelPlayerPoints;
        private Label label10;
        private Label labelPlayerWallet;
        private Label label11;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label labelFinancialDailyNetworth;
        private Label labelFinancialWallet;
        private Label labelFinancialCaymanBank;
        private Label labelFinancialHomeVault;
        private Label labelFinancialCompany;
        private Label labelFinancialCityBankInv;
        private Label label12;
        private Label label13;
        private Label labelFinancialInvDuration;
        private Label label14;
        private Label labelFinancialInvAtDate;
        private Label label15;
        private Label labelFinancialInvDueDate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label16;
        private Label labelFinancialInvRate;
        private Label labelFinancialInvProfit;
        private Label label17;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem overviewToolStripMenuItem;
        private ToolStripMenuItem refreshDataToolStripMenuItem;
        private Label label18;
        private Label labelFinancialInvTimeRemaining;
        private System.Windows.Forms.Timer timerInvestmentTimeRemaining;
        private ToolTip toolTip1;
    }
}