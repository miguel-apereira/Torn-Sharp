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
            labelPlayerName = new Label();
            groupBox1 = new GroupBox();
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
            groupBox1.SuspendLayout();
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
            groupBox1.Location = new Point(11, 10);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1080, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Profile";
            // 
            // lifeBar
            // 
            lifeBar.BackColor = SystemColors.ControlLight;
            lifeBar.Location = new Point(577, 49);
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
            label9.Location = new Point(541, 48);
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 640);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TornSharp";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
    }
}