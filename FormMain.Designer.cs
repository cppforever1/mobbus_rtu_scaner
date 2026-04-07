namespace mobbus_rtu_scaner
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            StatusStripMain = new StatusStrip();
            ToolStripProgressBarScan = new ToolStripProgressBar();
            toolStripStatusLabelEstimatedTtimeRremaining = new ToolStripStatusLabel();
            ToolStripMain = new ToolStrip();
            ToolStripComboBoxPorts = new ToolStripComboBox();
            ToolStripButtonStartScan = new ToolStripButton();
            ToolStripButtonStopScan = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            ToolStripComboBoxDeviceID = new ToolStripComboBox();
            SplitContainer = new SplitContainer();
            panel7 = new Panel();
            textBoxEstimatedTime = new TextBox();
            textBoxTotalCombinations = new TextBox();
            textBox7 = new TextBox();
            panel6 = new Panel();
            CheckedListBoxModbusFunctions = new CheckedListBox();
            textBox6 = new TextBox();
            panel5 = new Panel();
            CheckedListBoxHandshake = new CheckedListBox();
            textBox5 = new TextBox();
            panel4 = new Panel();
            CheckedListBoxParity = new CheckedListBox();
            textBox4 = new TextBox();
            panel3 = new Panel();
            CheckedListBoxStopbit = new CheckedListBox();
            textBox3 = new TextBox();
            panel2 = new Panel();
            CheckedListBoxDatabit = new CheckedListBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            CheckedListBoxBuadRate = new CheckedListBox();
            textBox1 = new TextBox();
            TextBoxLogger = new TextBox();
            StatusStripMain.SuspendLayout();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StatusStripMain
            // 
            StatusStripMain.ImageScalingSize = new Size(20, 20);
            StatusStripMain.Items.AddRange(new ToolStripItem[] { ToolStripProgressBarScan, toolStripStatusLabelEstimatedTtimeRremaining });
            StatusStripMain.Location = new Point(0, 750);
            StatusStripMain.Name = "StatusStripMain";
            StatusStripMain.Size = new Size(1310, 26);
            StatusStripMain.TabIndex = 0;
            StatusStripMain.Text = "SstatusStripMain";
            // 
            // ToolStripProgressBarScan
            // 
            ToolStripProgressBarScan.Name = "ToolStripProgressBarScan";
            ToolStripProgressBarScan.Size = new Size(1000, 18);
            // 
            // toolStripStatusLabelEstimatedTtimeRremaining
            // 
            toolStripStatusLabelEstimatedTtimeRremaining.Name = "toolStripStatusLabelEstimatedTtimeRremaining";
            toolStripStatusLabelEstimatedTtimeRremaining.Size = new Size(0, 20);
            // 
            // ToolStripMain
            // 
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripComboBoxPorts, ToolStripButtonStartScan, ToolStripButtonStopScan, toolStripSeparator1, toolStripLabel1, ToolStripComboBoxDeviceID });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(1310, 28);
            ToolStripMain.TabIndex = 1;
            ToolStripMain.Text = "ToolStripMain";
            // 
            // ToolStripComboBoxPorts
            // 
            ToolStripComboBoxPorts.BackColor = SystemColors.Info;
            ToolStripComboBoxPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxPorts.Name = "ToolStripComboBoxPorts";
            ToolStripComboBoxPorts.Size = new Size(121, 28);
            // 
            // ToolStripButtonStartScan
            // 
            ToolStripButtonStartScan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonStartScan.Image = (Image)resources.GetObject("ToolStripButtonStartScan.Image");
            ToolStripButtonStartScan.ImageTransparentColor = Color.Magenta;
            ToolStripButtonStartScan.Name = "ToolStripButtonStartScan";
            ToolStripButtonStartScan.Size = new Size(79, 25);
            ToolStripButtonStartScan.Text = "Start Scan";
            ToolStripButtonStartScan.Click += ToolStripButtonStartScan_Click;
            // 
            // ToolStripButtonStopScan
            // 
            ToolStripButtonStopScan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonStopScan.Image = (Image)resources.GetObject("ToolStripButtonStopScan.Image");
            ToolStripButtonStopScan.ImageTransparentColor = Color.Magenta;
            ToolStripButtonStopScan.Name = "ToolStripButtonStopScan";
            ToolStripButtonStopScan.Size = new Size(79, 25);
            ToolStripButtonStopScan.Text = "Stop Scan";
            ToolStripButtonStopScan.Click += ToolStripButtonStopScan_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(69, 25);
            toolStripLabel1.Text = "DeviceID";
            // 
            // ToolStripComboBoxDeviceID
            // 
            ToolStripComboBoxDeviceID.BackColor = SystemColors.Info;
            ToolStripComboBoxDeviceID.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxDeviceID.Name = "ToolStripComboBoxDeviceID";
            ToolStripComboBoxDeviceID.Size = new Size(80, 28);
            // 
            // SplitContainer
            // 
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 28);
            SplitContainer.Name = "SplitContainer";
            SplitContainer.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(panel7);
            SplitContainer.Panel1.Controls.Add(panel6);
            SplitContainer.Panel1.Controls.Add(panel5);
            SplitContainer.Panel1.Controls.Add(panel4);
            SplitContainer.Panel1.Controls.Add(panel3);
            SplitContainer.Panel1.Controls.Add(panel2);
            SplitContainer.Panel1.Controls.Add(panel1);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(TextBoxLogger);
            SplitContainer.Size = new Size(1310, 722);
            SplitContainer.SplitterDistance = 442;
            SplitContainer.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxEstimatedTime);
            panel7.Controls.Add(textBoxTotalCombinations);
            panel7.Controls.Add(textBox7);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(990, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(316, 442);
            panel7.TabIndex = 15;
            // 
            // textBoxEstimatedTime
            // 
            textBoxEstimatedTime.BackColor = SystemColors.Info;
            textBoxEstimatedTime.Location = new Point(18, 165);
            textBoxEstimatedTime.Name = "textBoxEstimatedTime";
            textBoxEstimatedTime.ReadOnly = true;
            textBoxEstimatedTime.Size = new Size(280, 27);
            textBoxEstimatedTime.TabIndex = 4;
            textBoxEstimatedTime.TabStop = false;
            textBoxEstimatedTime.TextAlign = HorizontalAlignment.Center;
            textBoxEstimatedTime.WordWrap = false;
            // 
            // textBoxTotalCombinations
            // 
            textBoxTotalCombinations.BackColor = SystemColors.Info;
            textBoxTotalCombinations.Location = new Point(18, 95);
            textBoxTotalCombinations.Name = "textBoxTotalCombinations";
            textBoxTotalCombinations.ReadOnly = true;
            textBoxTotalCombinations.Size = new Size(280, 27);
            textBoxTotalCombinations.TabIndex = 3;
            textBoxTotalCombinations.TabStop = false;
            textBoxTotalCombinations.TextAlign = HorizontalAlignment.Center;
            textBoxTotalCombinations.WordWrap = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Info;
            textBox7.Dock = DockStyle.Top;
            textBox7.Location = new Point(0, 0);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(316, 27);
            textBox7.TabIndex = 1;
            textBox7.TabStop = false;
            textBox7.Text = "Information";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.Controls.Add(CheckedListBoxModbusFunctions);
            panel6.Controls.Add(textBox6);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(750, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 442);
            panel6.TabIndex = 14;
            // 
            // CheckedListBoxModbusFunctions
            // 
            CheckedListBoxModbusFunctions.Dock = DockStyle.Fill;
            CheckedListBoxModbusFunctions.FormattingEnabled = true;
            CheckedListBoxModbusFunctions.Location = new Point(0, 27);
            CheckedListBoxModbusFunctions.Name = "CheckedListBoxModbusFunctions";
            CheckedListBoxModbusFunctions.Size = new Size(240, 415);
            CheckedListBoxModbusFunctions.TabIndex = 9;
            CheckedListBoxModbusFunctions.ItemCheck += ItemCheck;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Dock = DockStyle.Top;
            textBox6.Location = new Point(0, 0);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(240, 27);
            textBox6.TabIndex = 0;
            textBox6.TabStop = false;
            textBox6.Text = "Modbus Function";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.Controls.Add(CheckedListBoxHandshake);
            panel5.Controls.Add(textBox5);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(600, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 442);
            panel5.TabIndex = 13;
            // 
            // CheckedListBoxHandshake
            // 
            CheckedListBoxHandshake.Dock = DockStyle.Fill;
            CheckedListBoxHandshake.FormattingEnabled = true;
            CheckedListBoxHandshake.Location = new Point(0, 27);
            CheckedListBoxHandshake.Name = "CheckedListBoxHandshake";
            CheckedListBoxHandshake.Size = new Size(150, 415);
            CheckedListBoxHandshake.TabIndex = 8;
            CheckedListBoxHandshake.ItemCheck += ItemCheck;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Info;
            textBox5.Dock = DockStyle.Top;
            textBox5.Location = new Point(0, 0);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(150, 27);
            textBox5.TabIndex = 0;
            textBox5.TabStop = false;
            textBox5.Text = "Handshake";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.Controls.Add(CheckedListBoxParity);
            panel4.Controls.Add(textBox4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(450, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 442);
            panel4.TabIndex = 12;
            // 
            // CheckedListBoxParity
            // 
            CheckedListBoxParity.Dock = DockStyle.Fill;
            CheckedListBoxParity.FormattingEnabled = true;
            CheckedListBoxParity.Location = new Point(0, 27);
            CheckedListBoxParity.Name = "CheckedListBoxParity";
            CheckedListBoxParity.Size = new Size(150, 415);
            CheckedListBoxParity.TabIndex = 7;
            CheckedListBoxParity.ItemCheck += ItemCheck;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Dock = DockStyle.Top;
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 27);
            textBox4.TabIndex = 0;
            textBox4.TabStop = false;
            textBox4.Text = "Parity";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(CheckedListBoxStopbit);
            panel3.Controls.Add(textBox3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 442);
            panel3.TabIndex = 11;
            // 
            // CheckedListBoxStopbit
            // 
            CheckedListBoxStopbit.Dock = DockStyle.Fill;
            CheckedListBoxStopbit.FormattingEnabled = true;
            CheckedListBoxStopbit.Location = new Point(0, 27);
            CheckedListBoxStopbit.Name = "CheckedListBoxStopbit";
            CheckedListBoxStopbit.Size = new Size(150, 415);
            CheckedListBoxStopbit.TabIndex = 6;
            CheckedListBoxStopbit.ItemCheck += ItemCheck;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Dock = DockStyle.Top;
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 27);
            textBox3.TabIndex = 0;
            textBox3.TabStop = false;
            textBox3.Text = "Stop Bit";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(CheckedListBoxDatabit);
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 442);
            panel2.TabIndex = 10;
            // 
            // CheckedListBoxDatabit
            // 
            CheckedListBoxDatabit.Dock = DockStyle.Fill;
            CheckedListBoxDatabit.FormattingEnabled = true;
            CheckedListBoxDatabit.Location = new Point(0, 27);
            CheckedListBoxDatabit.Name = "CheckedListBoxDatabit";
            CheckedListBoxDatabit.Size = new Size(150, 415);
            CheckedListBoxDatabit.TabIndex = 5;
            CheckedListBoxDatabit.ItemCheck += ItemCheck;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 0;
            textBox2.TabStop = false;
            textBox2.Text = "Data Bit";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(CheckedListBoxBuadRate);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 442);
            panel1.TabIndex = 9;
            // 
            // CheckedListBoxBuadRate
            // 
            CheckedListBoxBuadRate.Dock = DockStyle.Fill;
            CheckedListBoxBuadRate.FormattingEnabled = true;
            CheckedListBoxBuadRate.Location = new Point(0, 27);
            CheckedListBoxBuadRate.Name = "CheckedListBoxBuadRate";
            CheckedListBoxBuadRate.Size = new Size(150, 415);
            CheckedListBoxBuadRate.TabIndex = 4;
            CheckedListBoxBuadRate.ItemCheck += ItemCheck;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Buad Rate";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxLogger
            // 
            TextBoxLogger.Dock = DockStyle.Fill;
            TextBoxLogger.Location = new Point(0, 0);
            TextBoxLogger.Multiline = true;
            TextBoxLogger.Name = "TextBoxLogger";
            TextBoxLogger.ReadOnly = true;
            TextBoxLogger.ScrollBars = ScrollBars.Both;
            TextBoxLogger.Size = new Size(1310, 276);
            TextBoxLogger.TabIndex = 0;
            TextBoxLogger.WordWrap = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 776);
            Controls.Add(SplitContainer);
            Controls.Add(ToolStripMain);
            Controls.Add(StatusStripMain);
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modbus RTU Scaner";
            Shown += FormMain_Shown;
            StatusStripMain.ResumeLayout(false);
            StatusStripMain.PerformLayout();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip StatusStripMain;
        private ToolStrip ToolStripMain;
        private ToolStripComboBox ToolStripComboBoxPorts;
        private ToolStripButton ToolStripButtonStartScan;
        private ToolStripButton ToolStripButtonStopScan;
        private SplitContainer SplitContainer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox ToolStripComboBoxDeviceID;
        private TextBox TextBoxLogger;
        private ToolStripProgressBar ToolStripProgressBarScan;
        private ToolStripStatusLabel toolStripStatusLabelEstimatedTtimeRremaining;
        private Panel panel2;
        private TextBox textBox2;
        private Panel panel1;
        private CheckedListBox CheckedListBoxBuadRate;
        private TextBox textBox1;
        private Panel panel6;
        private CheckedListBox CheckedListBoxModbusFunctions;
        private TextBox textBox6;
        private Panel panel5;
        private CheckedListBox CheckedListBoxHandshake;
        private TextBox textBox5;
        private Panel panel4;
        private CheckedListBox CheckedListBoxParity;
        private TextBox textBox4;
        private Panel panel3;
        private CheckedListBox CheckedListBoxStopbit;
        private TextBox textBox3;
        private CheckedListBox CheckedListBoxDatabit;
        private Panel panel7;
        private TextBox textBox7;
        private TextBox textBoxTotalCombinations;
        private TextBox textBoxEstimatedTime;
    }
}
