using System.Windows.Forms;

namespace DSTools
{
    partial class FormDSTools
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
            this.serial = new System.Windows.Forms.TextBox();
            this.oldSerial = new System.Windows.Forms.Label();
            this.updateSerial = new System.Windows.Forms.Button();
            this.productKey = new System.Windows.Forms.Label();
            this.windowsUpdate = new System.Windows.Forms.Button();
            this.make = new System.Windows.Forms.Label();
            this.hostname = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.machineSerial = new System.Windows.Forms.Label();
            this.updateHost = new System.Windows.Forms.Button();
            this.desktopLocation = new System.Windows.Forms.Label();
            this.deviceID = new System.Windows.Forms.Label();
            this.documents = new System.Windows.Forms.Label();
            this.onedrive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aknoledgement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.serial.Location = new System.Drawing.Point(12, 42);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(224, 20);
            this.serial.TabIndex = 0;
            this.serial.TextChanged += new System.EventHandler(this.Serial_TextChanged);
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
            // productKey
            // 
            this.productKey.AutoSize = true;
            this.productKey.Location = new System.Drawing.Point(9, 4);
            this.productKey.Name = "productKey";
            this.productKey.Size = new System.Drawing.Size(65, 13);
            this.productKey.TabIndex = 3;
            this.productKey.Text = "Product Key";
            // 
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
            this.make.Location = new System.Drawing.Point(374, 4);
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
            this.model.Location = new System.Drawing.Point(374, 26);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 7;
            this.model.Text = "Model";
            // 
            // machineSerial
            // 
            this.machineSerial.AutoSize = true;
            this.machineSerial.Location = new System.Drawing.Point(551, 27);
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
            // desktopLocation
            // 
            this.desktopLocation.AutoSize = true;
            this.desktopLocation.Location = new System.Drawing.Point(374, 64);
            this.desktopLocation.Name = "desktopLocation";
            this.desktopLocation.Size = new System.Drawing.Size(47, 13);
            this.desktopLocation.TabIndex = 11;
            this.desktopLocation.Text = "Desktop";
            this.desktopLocation.Click += new System.EventHandler(this.desktopLocation_Click);
            // 
            // deviceID
            // 
            this.deviceID.AutoSize = true;
            this.deviceID.Location = new System.Drawing.Point(374, 45);
            this.deviceID.Name = "deviceID";
            this.deviceID.Size = new System.Drawing.Size(55, 13);
            this.deviceID.TabIndex = 12;
            this.deviceID.Text = "Device ID";
            // 
            // documents
            // 
            this.documents.AutoSize = true;
            this.documents.Location = new System.Drawing.Point(374, 82);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(61, 13);
            this.documents.TabIndex = 13;
            this.documents.Text = "Documents";
            // 
            // onedrive
            // 
            this.onedrive.AutoSize = true;
            this.onedrive.Location = new System.Drawing.Point(375, 99);
            this.onedrive.Name = "onedrive";
            this.onedrive.Size = new System.Drawing.Size(123, 13);
            this.onedrive.TabIndex = 14;
            this.onedrive.Text = "Onedrive NOT Detected";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Shell Folders to Onedrive + Move Files";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aknoledgement
            // 
            this.aknoledgement.Cursor = System.Windows.Forms.Cursors.Cross;
            this.aknoledgement.Location = new System.Drawing.Point(717, 415);
            this.aknoledgement.Name = "aknoledgement";
            this.aknoledgement.Size = new System.Drawing.Size(75, 23);
            this.aknoledgement.TabIndex = 16;
            this.aknoledgement.Text = "Aknoledgement";
            this.aknoledgement.UseVisualStyleBackColor = true;
            this.aknoledgement.Click += new System.EventHandler(this.Ak_Click);
            // 
            // FormDSTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aknoledgement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.onedrive);
            this.Controls.Add(this.documents);
            this.Controls.Add(this.deviceID);
            this.Controls.Add(this.desktopLocation);
            this.Controls.Add(this.updateHost);
            this.Controls.Add(this.machineSerial);
            this.Controls.Add(this.model);
            this.Controls.Add(this.hostname);
            this.Controls.Add(this.make);
            this.Controls.Add(this.windowsUpdate);
            this.Controls.Add(this.productKey);
            this.Controls.Add(this.updateSerial);
            this.Controls.Add(this.oldSerial);
            this.Controls.Add(this.serial);
            this.Name = "FormDSTools";
            this.Text = "DSTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox serial;
        private Label oldSerial;
        private Button updateSerial;
        private Label productKey;
        private Button windowsUpdate;
        private Label make;
        private TextBox hostname;
        private Label model;
        private Label machineSerial;
        private Button updateHost;
        private Label desktopLocation;
        private Label deviceID;
        private Label documents;
        private Label onedrive;
        private Button button1;
        private Button aknoledgement;
    }
}

