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
            statusStrip1 = new StatusStrip();
            ToolStripProgressBarScan = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            ToolStripComboBoxPorts = new ToolStripComboBox();
            ToolStripButtonStartScan = new ToolStripButton();
            ToolStripButtonStopScan = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            ToolStripComboBoxDeviceID = new ToolStripComboBox();
            SplitContainer = new SplitContainer();
            CheckedListBoxHandshake = new CheckedListBox();
            CheckedListBoxParity = new CheckedListBox();
            CheckedListBoxStopbit = new CheckedListBox();
            CheckedListBoxDatabit = new CheckedListBox();
            CheckedListBoxBuadRate = new CheckedListBox();
            TextBoxLogger = new TextBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripProgressBarScan, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 750);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1291, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "SstatusStripMain";
            // 
            // ToolStripProgressBarScan
            // 
            ToolStripProgressBarScan.Name = "ToolStripProgressBarScan";
            ToolStripProgressBarScan.Size = new Size(1000, 18);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripComboBoxPorts, ToolStripButtonStartScan, ToolStripButtonStopScan, toolStripSeparator1, toolStripLabel1, ToolStripComboBoxDeviceID });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1291, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "ToolStripMain";
            // 
            // ToolStripComboBoxPorts
            // 
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
            SplitContainer.Panel1.Controls.Add(CheckedListBoxHandshake);
            SplitContainer.Panel1.Controls.Add(CheckedListBoxParity);
            SplitContainer.Panel1.Controls.Add(CheckedListBoxStopbit);
            SplitContainer.Panel1.Controls.Add(CheckedListBoxDatabit);
            SplitContainer.Panel1.Controls.Add(CheckedListBoxBuadRate);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(TextBoxLogger);
            SplitContainer.Size = new Size(1291, 722);
            SplitContainer.SplitterDistance = 270;
            SplitContainer.TabIndex = 3;
            // 
            // CheckedListBoxHandshake
            // 
            CheckedListBoxHandshake.Dock = DockStyle.Top;
            CheckedListBoxHandshake.FormattingEnabled = true;
            CheckedListBoxHandshake.Location = new Point(0, 214);
            CheckedListBoxHandshake.MultiColumn = true;
            CheckedListBoxHandshake.Name = "CheckedListBoxHandshake";
            CheckedListBoxHandshake.Size = new Size(1291, 48);
            CheckedListBoxHandshake.TabIndex = 7;
            // 
            // CheckedListBoxParity
            // 
            CheckedListBoxParity.Dock = DockStyle.Top;
            CheckedListBoxParity.FormattingEnabled = true;
            CheckedListBoxParity.Location = new Point(0, 166);
            CheckedListBoxParity.MultiColumn = true;
            CheckedListBoxParity.Name = "CheckedListBoxParity";
            CheckedListBoxParity.Size = new Size(1291, 48);
            CheckedListBoxParity.TabIndex = 6;
            // 
            // CheckedListBoxStopbit
            // 
            CheckedListBoxStopbit.Dock = DockStyle.Top;
            CheckedListBoxStopbit.FormattingEnabled = true;
            CheckedListBoxStopbit.Location = new Point(0, 118);
            CheckedListBoxStopbit.MultiColumn = true;
            CheckedListBoxStopbit.Name = "CheckedListBoxStopbit";
            CheckedListBoxStopbit.Size = new Size(1291, 48);
            CheckedListBoxStopbit.TabIndex = 5;
            // 
            // CheckedListBoxDatabit
            // 
            CheckedListBoxDatabit.Dock = DockStyle.Top;
            CheckedListBoxDatabit.FormattingEnabled = true;
            CheckedListBoxDatabit.Location = new Point(0, 70);
            CheckedListBoxDatabit.MultiColumn = true;
            CheckedListBoxDatabit.Name = "CheckedListBoxDatabit";
            CheckedListBoxDatabit.Size = new Size(1291, 48);
            CheckedListBoxDatabit.TabIndex = 4;
            // 
            // CheckedListBoxBuadRate
            // 
            CheckedListBoxBuadRate.Dock = DockStyle.Top;
            CheckedListBoxBuadRate.FormattingEnabled = true;
            CheckedListBoxBuadRate.Location = new Point(0, 0);
            CheckedListBoxBuadRate.MultiColumn = true;
            CheckedListBoxBuadRate.Name = "CheckedListBoxBuadRate";
            CheckedListBoxBuadRate.Size = new Size(1291, 70);
            CheckedListBoxBuadRate.TabIndex = 3;
            // 
            // TextBoxLogger
            // 
            TextBoxLogger.Dock = DockStyle.Fill;
            TextBoxLogger.Location = new Point(0, 0);
            TextBoxLogger.Multiline = true;
            TextBoxLogger.Name = "TextBoxLogger";
            TextBoxLogger.ReadOnly = true;
            TextBoxLogger.ScrollBars = ScrollBars.Both;
            TextBoxLogger.Size = new Size(1291, 448);
            TextBoxLogger.TabIndex = 0;
            TextBoxLogger.WordWrap = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 776);
            Controls.Add(SplitContainer);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modbus RTU Scaner";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripComboBox ToolStripComboBoxPorts;
        private ToolStripButton ToolStripButtonStartScan;
        private ToolStripButton ToolStripButtonStopScan;
        private SplitContainer SplitContainer;
        private CheckedListBox CheckedListBoxBuadRate;
        private CheckedListBox CheckedListBoxDatabit;
        private CheckedListBox CheckedListBoxStopbit;
        private CheckedListBox CheckedListBoxParity;
        private CheckedListBox CheckedListBoxHandshake;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox ToolStripComboBoxDeviceID;
        private TextBox TextBoxLogger;
        private ToolStripProgressBar ToolStripProgressBarScan;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
