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
            this.onedriveButton = new System.Windows.Forms.Button();
            this.aknoledgement = new System.Windows.Forms.Button();
            this.SID = new System.Windows.Forms.Label();
            this.firmware = new System.Windows.Forms.Button();
            this.oneDriveRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.updateSerial.Location = new System.Drawing.Point(230, 26);
            this.updateSerial.Name = "updateSerial";
            this.updateSerial.Size = new System.Drawing.Size(81, 37);
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
            this.make.Location = new System.Drawing.Point(360, 2);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(34, 13);
            this.make.TabIndex = 5;
            this.make.Text = "Make";
            // 
            // hostname
            // 
            this.hostname.Location = new System.Drawing.Point(551, 0);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(123, 20);
            this.hostname.TabIndex = 6;
            this.hostname.Text = "Hostname";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(360, 15);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 7;
            this.model.Text = "Model";
            // 
            // machineSerial
            // 
            this.machineSerial.AutoSize = true;
            this.machineSerial.Location = new System.Drawing.Point(360, 28);
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
            this.desktopLocation.Location = new System.Drawing.Point(360, 67);
            this.desktopLocation.Name = "desktopLocation";
            this.desktopLocation.Size = new System.Drawing.Size(47, 13);
            this.desktopLocation.TabIndex = 11;
            this.desktopLocation.Text = "Desktop";
            this.desktopLocation.Click += new System.EventHandler(this.desktopLocation_Click);
            // 
            // deviceID
            // 
            this.deviceID.AutoSize = true;
            this.deviceID.Location = new System.Drawing.Point(360, 41);
            this.deviceID.Name = "deviceID";
            this.deviceID.Size = new System.Drawing.Size(55, 13);
            this.deviceID.TabIndex = 12;
            this.deviceID.Text = "Device ID";
            // 
            // documents
            // 
            this.documents.AutoSize = true;
            this.documents.Location = new System.Drawing.Point(360, 80);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(61, 13);
            this.documents.TabIndex = 13;
            this.documents.Text = "Documents";
            // 
            // onedrive
            // 
            this.onedrive.AutoSize = true;
            this.onedrive.Location = new System.Drawing.Point(360, 93);
            this.onedrive.Name = "onedrive";
            this.onedrive.Size = new System.Drawing.Size(123, 13);
            this.onedrive.TabIndex = 14;
            this.onedrive.Text = "Onedrive NOT Detected";
            // 
            // onedriveButton
            // 
            this.onedriveButton.Enabled = false;
            this.onedriveButton.Location = new System.Drawing.Point(695, 69);
            this.onedriveButton.Name = "onedriveButton";
            this.onedriveButton.Size = new System.Drawing.Size(98, 43);
            this.onedriveButton.TabIndex = 15;
            this.onedriveButton.Text = "OneDrive ShellDirChange";
            this.onedriveButton.UseVisualStyleBackColor = true;
            this.onedriveButton.Click += new System.EventHandler(this.OnedriveButton_Click);
            // 
            // aknoledgement
            // 
            this.aknoledgement.Cursor = System.Windows.Forms.Cursors.Cross;
            this.aknoledgement.Location = new System.Drawing.Point(695, 415);
            this.aknoledgement.Name = "aknoledgement";
            this.aknoledgement.Size = new System.Drawing.Size(97, 23);
            this.aknoledgement.TabIndex = 16;
            this.aknoledgement.Text = "Acknowledgment";
            this.aknoledgement.UseVisualStyleBackColor = true;
            this.aknoledgement.Click += new System.EventHandler(this.Ak_Click);
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(360, 54);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(25, 13);
            this.SID.TabIndex = 17;
            this.SID.Text = "SID";
            // 
            // firmware
            // 
            this.firmware.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firmware.Location = new System.Drawing.Point(120, 69);
            this.firmware.Name = "firmware";
            this.firmware.Size = new System.Drawing.Size(123, 23);
            this.firmware.TabIndex = 18;
            this.firmware.Text = "HP F9470m Firmware";
            this.firmware.UseVisualStyleBackColor = true;
            this.firmware.Click += new System.EventHandler(this.Firmware_Click);
            // 
            // oneDriveRestore
            // 
            this.oneDriveRestore.Location = new System.Drawing.Point(695, 28);
            this.oneDriveRestore.Name = "oneDriveRestore";
            this.oneDriveRestore.Size = new System.Drawing.Size(98, 39);
            this.oneDriveRestore.TabIndex = 19;
            this.oneDriveRestore.Text = "Restore OneDrive";
            this.oneDriveRestore.UseVisualStyleBackColor = true;
            this.oneDriveRestore.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(327, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(325, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(328, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Serial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(335, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "HID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(336, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "SID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(263, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "User Shell Desktop:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(249, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "User Shell Documents:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(246, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "OneDrive For Business:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Uninstall Programs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Default Google Chome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDSTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.onedrive);
            this.Controls.Add(this.documents);
            this.Controls.Add(this.deviceID);
            this.Controls.Add(this.desktopLocation);
            this.Controls.Add(this.machineSerial);
            this.Controls.Add(this.model);
            this.Controls.Add(this.make);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oneDriveRestore);
            this.Controls.Add(this.firmware);
            this.Controls.Add(this.aknoledgement);
            this.Controls.Add(this.onedriveButton);
            this.Controls.Add(this.updateHost);
            this.Controls.Add(this.hostname);
            this.Controls.Add(this.windowsUpdate);
            this.Controls.Add(this.productKey);
            this.Controls.Add(this.updateSerial);
            this.Controls.Add(this.oldSerial);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
        private Button onedriveButton;
        private Button aknoledgement;
        private Label SID;
        private Button firmware;
        private Button oneDriveRestore;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}

