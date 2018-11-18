using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;


namespace DSTools
{
    public partial class FormDSTools : Form
    {
        public FormDSTools()
        {
            InitializeComponent();

            // get the assembly information to display current version in the title of the window
            var assemblyName = AssemblyName.GetAssemblyName(Assembly.GetExecutingAssembly().Location);

            // format window title text (append version to the current title)
            Text = $@"{Text} v{assemblyName.Version.Major}.{assemblyName.Version.Minor}";

            // get the current Windows Product Key and display it
            oldSerial.Text = KeyFinder.GetWindowsProductKeyFromRegistry();

            ModifyRegistry.ModifyRegistry explorerShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Windows\CurrentVersion\Explorer\Shell Folders");
            ModifyRegistry.ModifyRegistry userShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Windows\CurrentVersion\Explorer\Shell Folders");
            ModifyRegistry.ModifyRegistry onedriveFolder = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Onedrive");

            make.Text = HardwareLibrary.ComputerMake();
            model.Text = HardwareLibrary.ComputerModel();
            hostname.Text = HardwareLibrary.ComputerName();
            machineSerial.Text = HardwareLibrary.SerialNumber();
            desktopLocation.Text = explorerShellFolders.ReadString("Desktop") + " + " + userShellFolders.ReadString("Desktop");
            documents.Text = explorerShellFolders.ReadString("Personal") + " + " + userShellFolders.ReadString("Personal");
            deviceID.Text = HardwareLibrary.DeviceID();

            bool onedriveInstalled = (onedriveFolder.ReadString("UserFolder") == null) ? false : true;
            if (onedriveInstalled)
            {
                onedrive.Text = onedriveFolder.ReadString("UserFolder") + 
                    " Version:" + onedriveFolder.ReadString("Version");
            }
            else
            {
                onedrive.Enabled = false;
            }
        }

        private void Serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSerial_Click(object sender, EventArgs e)
        {
            string serial = this.serial.Text;

            ActivateWindows.Activate(serial);
        }

        private void WindowsUpdate_Click(object sender, EventArgs e)

            
        {
            
            Process process = Process.Start(@"wumgr\wumgr.exe");
            
        }

        private void UpdateHost_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = "WMIC.exe";
            process.UseShellExecute = false;
            process.RedirectStandardOutput = true;
            process.Arguments = "ComputerSystem where Name='" + HardwareLibrary.ComputerName() + "' call Rename Name='" + hostname.Text + "'";
            Process proc = Process.Start(process);
            MessageBox.Show(proc.StandardOutput.ReadToEnd());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void desktopLocation_Click(object sender, EventArgs e)
        {

        }

        private void Ak_Click(object sender, EventArgs e)
        {
            Ak m = new Ak();
            m.Show();

        }
    }
}
