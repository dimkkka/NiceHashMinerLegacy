﻿namespace NiceHashMiner.Forms.Components {
    partial class Field {
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
            this.labelFieldIndicator = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFieldIndicator
            // 
            this.labelFieldIndicator.AutoSize = true;
            this.labelFieldIndicator.Location = new System.Drawing.Point(3, 6);
            this.labelFieldIndicator.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelFieldIndicator.Name = "labelFieldIndicator";
            this.labelFieldIndicator.Size = new System.Drawing.Size(98, 13);
            this.labelFieldIndicator.TabIndex = 3;
            this.labelFieldIndicator.Text = "Label field indicator";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(165, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(206, 20);
            this.textBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFieldIndicator);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 28);
            this.panel1.TabIndex = 6;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "Field";
            this.Size = new System.Drawing.Size(455, 31);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFieldIndicator;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;


    }
}
