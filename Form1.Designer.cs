using System.Windows.Forms;

namespace DSTools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Serial = new System.Windows.Forms.TextBox();
            this.oldSerial = new System.Windows.Forms.Label();
            this.updateSerial = new System.Windows.Forms.Button();
            this.productKey = new System.Windows.Forms.Label();
            this.windowsUpdate = new System.Windows.Forms.Button();
            this.make = new System.Windows.Forms.Label();
            this.hostname = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.machineSerial = new System.Windows.Forms.Label();
            this.updateHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Serial.Location = new System.Drawing.Point(12, 42);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(224, 20);
            this.Serial.TabIndex = 0;
            this.Serial.TextChanged += new System.EventHandler(this.Serial_TextChanged);
            // 
            // oldSerial
            // 
            this.oldSerial.AutoSize = true;
            this.oldSerial.Location = new System.Drawing.Point(9, 26);
            this.oldSerial.Name = "oldSerial";
            this.oldSerial.Size = new System.Drawing.Size(55, 13);
            this.oldSerial.TabIndex = 1;
            this.oldSerial.Text = "Old Serial:";
            // 
            // updateSerial
            // 
            this.updateSerial.Location = new System.Drawing.Point(246, 42);
            this.updateSerial.Name = "updateSerial";
            this.updateSerial.Size = new System.Drawing.Size(118, 19);
            this.updateSerial.TabIndex = 2;
            this.updateSerial.Text = "Install Product Key";
            this.updateSerial.UseVisualStyleBackColor = true;
            this.updateSerial.Click += new System.EventHandler(this.UpdateSerial_Click);
            // 
            // label1
            // 
            this.productKey.AutoSize = true;
            this.productKey.Location = new System.Drawing.Point(9, 4);
            this.productKey.Name = "productKey";
            this.productKey.Size = new System.Drawing.Size(65, 13);
            this.productKey.TabIndex = 3;
            this.productKey.Text = "Product Key";            // 
            // windowsUpdate
            // 
            this.windowsUpdate.Location = new System.Drawing.Point(12, 69);
            this.windowsUpdate.Name = "windowsUpdate";
            this.windowsUpdate.Size = new System.Drawing.Size(101, 23);
            this.windowsUpdate.TabIndex = 4;
            this.windowsUpdate.Text = "Update Windows";
            this.windowsUpdate.UseVisualStyleBackColor = true;
            this.windowsUpdate.Click += new System.EventHandler(this.WindowsUpdate_Click);
            // 
            // make
            // 
            this.make.AutoSize = true;
            this.make.Location = new System.Drawing.Point(375, 4);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(34, 13);
            this.make.TabIndex = 5;
            this.make.Text = "Make";
            // 
            // hostname
            // 
            this.hostname.Location = new System.Drawing.Point(551, 4);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(123, 20);
            this.hostname.TabIndex = 6;
            this.hostname.Text = "Hostname";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(375, 26);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 7;
            this.model.Text = "Model";
            // 
            // machineSerial
            // 
            this.machineSerial.AutoSize = true;
            this.machineSerial.Location = new System.Drawing.Point(551, 26);
            this.machineSerial.Name = "machineSerial";
            this.machineSerial.Size = new System.Drawing.Size(77, 13);
            this.machineSerial.TabIndex = 8;
            this.machineSerial.Text = "Machine Serial";
            // 
            // updateHost
            // 
            this.updateHost.Location = new System.Drawing.Point(680, 2);
            this.updateHost.Name = "updateHost";
            this.updateHost.Size = new System.Drawing.Size(113, 23);
            this.updateHost.TabIndex = 10;
            this.updateHost.Text = "Update Hostname";
            this.updateHost.UseVisualStyleBackColor = true;
            this.updateHost.Click += new System.EventHandler(this.UpdateHost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateHost);
            this.Controls.Add(this.machineSerial);
            this.Controls.Add(this.model);
            this.Controls.Add(this.hostname);
            this.Controls.Add(this.make);
            this.Controls.Add(this.windowsUpdate);
            this.Controls.Add(this.productKey);
            this.Controls.Add(this.updateSerial);
            this.Controls.Add(this.oldSerial);
            this.Controls.Add(this.Serial);
            this.Name = "Form1";
            this.Text = "DSTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Label oldSerial;
        private Button updateSerial;
        private Label productKey;
        private Button windowsUpdate;
        private Label make;
        private TextBox hostname;
        private Label model;
        private Label machineSerial;
        private Button updateHost;
    }
}

