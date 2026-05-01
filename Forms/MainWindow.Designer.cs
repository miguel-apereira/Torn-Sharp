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
            labelPlayerStatus = new Label();
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
            groupBox1.Controls.Add(labelPlayerStatus);
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
            groupBox1.Size = new Size(978, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Profile";
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
            ClientSize = new Size(999, 563);
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
    }
}