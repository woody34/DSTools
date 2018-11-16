using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;


namespace DSTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get the assembly information to display current version in the title of the window
            var assemblyName = AssemblyName.GetAssemblyName(Assembly.GetExecutingAssembly().Location);

            // format window title text (append version to the current title)
            Text = $@"{Text} v{assemblyName.Version.Major}.{assemblyName.Version.Minor}";

            // get the current Windows Product Key and display it
            oldSerial.Text = KeyFinder.GetWindowsProductKeyFromRegistry();

            make.Text = HardwareLibrary.ComputerMake();
            model.Text = HardwareLibrary.ComputerModel();
            hostname.Text = HardwareLibrary.ComputerName();
            machineSerial.Text = HardwareLibrary.SerialNumber();

        }

        private void Serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSerial_Click(object sender, EventArgs e)
        {
            string serial = this.Serial.Text;

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
    }
}
