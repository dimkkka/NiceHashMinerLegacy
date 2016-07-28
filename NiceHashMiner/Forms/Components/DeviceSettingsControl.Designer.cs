﻿namespace NiceHashMiner.Forms.Components {
    partial class DeviceSettingsControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelSelectedDeviceName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSelectedDeviceGroup = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fieldAPIBindPort = new NiceHashMiner.Forms.Components.Field();
            this.fieldUsePassword = new NiceHashMiner.Forms.Components.Field();
            this.fieldMinimumProfit = new NiceHashMiner.Forms.Components.Field();
            this.groupBoxExtraLaunchParameters = new System.Windows.Forms.GroupBox();
            this.richTextBoxExtraLaunchParameters = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amdSpecificSettings1 = new NiceHashMiner.Forms.Components.AmdSpecificSettings();
            this.cpuSpecificSettings1 = new NiceHashMiner.Forms.Components.CpuSpecificSettings();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxExtraLaunchParameters.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectedDeviceName
            // 
            this.labelSelectedDeviceName.AutoSize = true;
            this.labelSelectedDeviceName.Location = new System.Drawing.Point(6, 28);
            this.labelSelectedDeviceName.Name = "labelSelectedDeviceName";
            this.labelSelectedDeviceName.Size = new System.Drawing.Size(151, 13);
            this.labelSelectedDeviceName.TabIndex = 1;
            this.labelSelectedDeviceName.Text = "Name: Selected Device Name";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelSelectedDeviceGroup);
            this.groupBox1.Controls.Add(this.labelSelectedDeviceName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Device Info";
            // 
            // labelSelectedDeviceGroup
            // 
            this.labelSelectedDeviceGroup.AutoSize = true;
            this.labelSelectedDeviceGroup.Location = new System.Drawing.Point(6, 52);
            this.labelSelectedDeviceGroup.Name = "labelSelectedDeviceGroup";
            this.labelSelectedDeviceGroup.Size = new System.Drawing.Size(153, 13);
            this.labelSelectedDeviceGroup.TabIndex = 2;
            this.labelSelectedDeviceGroup.Text = "Group: Selected Device Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(3, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common Device Group Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fieldAPIBindPort);
            this.flowLayoutPanel1.Controls.Add(this.fieldUsePassword);
            this.flowLayoutPanel1.Controls.Add(this.fieldMinimumProfit);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxExtraLaunchParameters);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(433, 201);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fieldAPIBindPort
            // 
            this.fieldAPIBindPort.AutoSize = true;
            this.fieldAPIBindPort.BackColor = System.Drawing.Color.Transparent;
            this.fieldAPIBindPort.EntryText = "";
            this.fieldAPIBindPort.LabelText = "API Bind Port:";
            this.fieldAPIBindPort.Location = new System.Drawing.Point(0, 3);
            this.fieldAPIBindPort.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.fieldAPIBindPort.Name = "fieldAPIBindPort";
            this.fieldAPIBindPort.Size = new System.Drawing.Size(389, 31);
            this.fieldAPIBindPort.TabIndex = 0;
            // 
            // fieldUsePassword
            // 
            this.fieldUsePassword.AutoSize = true;
            this.fieldUsePassword.BackColor = System.Drawing.Color.Transparent;
            this.fieldUsePassword.EntryText = "";
            this.fieldUsePassword.LabelText = "Use Password:";
            this.fieldUsePassword.Location = new System.Drawing.Point(0, 34);
            this.fieldUsePassword.Margin = new System.Windows.Forms.Padding(0);
            this.fieldUsePassword.Name = "fieldUsePassword";
            this.fieldUsePassword.Size = new System.Drawing.Size(389, 31);
            this.fieldUsePassword.TabIndex = 1;
            // 
            // fieldMinimumProfit
            // 
            this.fieldMinimumProfit.AutoSize = true;
            this.fieldMinimumProfit.BackColor = System.Drawing.Color.Transparent;
            this.fieldMinimumProfit.EntryText = "";
            this.fieldMinimumProfit.LabelText = "Minimum Profit ($/day):";
            this.fieldMinimumProfit.Location = new System.Drawing.Point(0, 65);
            this.fieldMinimumProfit.Margin = new System.Windows.Forms.Padding(0);
            this.fieldMinimumProfit.Name = "fieldMinimumProfit";
            this.fieldMinimumProfit.Size = new System.Drawing.Size(389, 31);
            this.fieldMinimumProfit.TabIndex = 2;
            // 
            // groupBoxExtraLaunchParameters
            // 
            this.groupBoxExtraLaunchParameters.Controls.Add(this.richTextBoxExtraLaunchParameters);
            this.groupBoxExtraLaunchParameters.Location = new System.Drawing.Point(3, 99);
            this.groupBoxExtraLaunchParameters.Name = "groupBoxExtraLaunchParameters";
            this.groupBoxExtraLaunchParameters.Size = new System.Drawing.Size(427, 99);
            this.groupBoxExtraLaunchParameters.TabIndex = 5;
            this.groupBoxExtraLaunchParameters.TabStop = false;
            this.groupBoxExtraLaunchParameters.Text = "Extra Launch Parameters:";
            // 
            // richTextBoxExtraLaunchParameters
            // 
            this.richTextBoxExtraLaunchParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxExtraLaunchParameters.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxExtraLaunchParameters.Name = "richTextBoxExtraLaunchParameters";
            this.richTextBoxExtraLaunchParameters.Size = new System.Drawing.Size(421, 80);
            this.richTextBoxExtraLaunchParameters.TabIndex = 0;
            this.richTextBoxExtraLaunchParameters.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amdSpecificSettings1);
            this.groupBox3.Controls.Add(this.cpuSpecificSettings1);
            this.groupBox3.Location = new System.Drawing.Point(3, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 76);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specific Device Group Settings";
            // 
            // amdSpecificSettings1
            // 
            this.amdSpecificSettings1.Location = new System.Drawing.Point(9, 19);
            this.amdSpecificSettings1.Name = "amdSpecificSettings1";
            this.amdSpecificSettings1.Size = new System.Drawing.Size(435, 40);
            this.amdSpecificSettings1.TabIndex = 5;
            // 
            // cpuSpecificSettings1
            // 
            this.cpuSpecificSettings1.Location = new System.Drawing.Point(9, 13);
            this.cpuSpecificSettings1.Name = "cpuSpecificSettings1";
            this.cpuSpecificSettings1.Size = new System.Drawing.Size(430, 57);
            this.cpuSpecificSettings1.TabIndex = 0;
            // 
            // DeviceSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceSettingsControl";
            this.Size = new System.Drawing.Size(447, 417);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxExtraLaunchParameters.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedDeviceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSelectedDeviceGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxExtraLaunchParameters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Field fieldAPIBindPort;
        private Field fieldUsePassword;
        private Field fieldMinimumProfit;
        private System.Windows.Forms.RichTextBox richTextBoxExtraLaunchParameters;
        private CpuSpecificSettings cpuSpecificSettings1;
        private AmdSpecificSettings amdSpecificSettings1;

    }
}
