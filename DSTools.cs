using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Net;
using System.ComponentModel;

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

            make.Text = HardwareLibrary.ComputerMake();
            model.Text = HardwareLibrary.ComputerModel();
            hostname.Text = HardwareLibrary.ComputerName();
            machineSerial.Text = HardwareLibrary.SerialNumber();

            UpdateOnedriveInfo();
        }

        private void UpdateOnedriveInfo()
        {
            onedriveButton.Enabled = false;
            //ModifyRegistry.ModifyRegistry userShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Windows\CurrentVersion\Explorer\User Shell Folders");
            ModifyRegistry.ModifyRegistry userShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, "Microsoft", @"Windows\CurrentVersion\Explorer\User Shell Folders");
            ModifyRegistry.ModifyRegistry onedriveFolder = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"OneDrive\Accounts\Business1");
            ModifyRegistry.ModifyRegistry onedriveVersionFolder = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Onedrive");


            string user = Environment.UserName;
            NTAccount currentUser = new NTAccount(user);
            SecurityIdentifier sid = (SecurityIdentifier) currentUser.Translate(typeof(SecurityIdentifier));
            SID.Text = sid.ToString();
            desktopLocation.Text = userShellFolders.ReadString("{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}");
            documents.Text = userShellFolders.ReadString("Personal");
            deviceID.Text = HardwareLibrary.DeviceID();

            bool onedriveInstalled = (onedriveFolder.ReadString(@"UserFolder") == null) ? false : true;
            if (onedriveInstalled)
            {
                onedrive.Text = onedriveFolder.ReadString("UserFolder") +
                    "|Version:" + onedriveVersionFolder.ReadString("Version");
                Thread.Sleep(200);
                onedriveButton.Enabled = true;
            }
        }

        private void RestoreOneDriveReg()
        {
            ModifyRegistry.ModifyRegistry userShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Windows\CurrentVersion\Explorer\User Shell Folders");
            ModifyRegistry.ModifyRegistry onedriveFolder = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Onedrive\Accounts\Business1");

            string desktopShellPath = userShellFolders.ReadString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}");
            string documentsShellPath = userShellFolders.ReadString(@"Personal");

            string defaultDesktopShellPath = @"C:\Users\" + Environment.UserName + @"\Desktop";
            string defaultDocumentsShellPath = @"C:\Users\" + Environment.UserName + @"\Documents";

            RestartProcess.KillProcessByFileName("OneDrive");

            if (desktopShellPath != defaultDesktopShellPath)
            {
                try
                {
                    userShellFolders.WriteString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}", defaultDesktopShellPath);
                    userShellFolders.WriteString(@"Desktop", defaultDesktopShellPath);

                    Thread.Sleep(100);
                    RestartProcess.KillProcessByFileName("explorer");
                }
                catch (Exception fileMoveE)
                {
                    MessageBox.Show(fileMoveE.Message);
                }
            }

            try
            {
                if (documentsShellPath != defaultDocumentsShellPath)
                {
                    FileSystem.CopyDirectory(documentsShellPath, defaultDocumentsShellPath, false);
                    userShellFolders.WriteString(@"Personal", defaultDocumentsShellPath);
                }
                RestartProcess.KillProcessByFileName("explorer");
            }
            catch (Exception fileMoveE)
            {
                MessageBox.Show(fileMoveE.Message);
            }

            Process.Start("explorer.exe");

            UpdateOnedriveInfo();
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
            
            Process process = Process.Start(@"Services\wumgr\wumgr.exe");
            
        }

        private void UpdateHost_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = @"WMIC.exe";
            process.UseShellExecute = false;
            process.RedirectStandardOutput = true;
            process.Arguments = @"ComputerSystem where Name='" + HardwareLibrary.ComputerName() + @"' call Rename Name='" + hostname.Text + "'";
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

        private void OnedriveButton_Click(object sender, EventArgs e)
        {
            ModifyRegistry.ModifyRegistry userShellFolders = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Windows\CurrentVersion\Explorer\User Shell Folders");
            ModifyRegistry.ModifyRegistry onedriveFolder = new ModifyRegistry.ModifyRegistry(Registry.CurrentUser, @"Microsoft", @"Onedrive\Accounts\Business1");

            try
            {
                string oneDriveDesktopPath = onedriveFolder.ReadString("UserFolder") + @"\Desktop\";
                string desktopShellPath = userShellFolders.ReadString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}") + @"\";

                if (@desktopShellPath != @oneDriveDesktopPath)
                {
                    UIOption showUI = UIOption.AllDialogs;
                    UICancelOption onUserCancel = UICancelOption.ThrowException;
                    FileSystem.CopyDirectory(@desktopShellPath, @oneDriveDesktopPath, showUI, onUserCancel);

                    userShellFolders.WriteString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}", @oneDriveDesktopPath.TrimEnd(char.Parse(@"\")));
                    userShellFolders.WriteString(@"Desktop", @oneDriveDesktopPath.TrimEnd(char.Parse(@"\")));
                }
            }
            catch (Exception dMoveEx)
            {
                MessageBox.Show(dMoveEx.Message + dMoveEx.TargetSite);
            }

            try
            {
                string oneDriveDocumentsPath = onedriveFolder.ReadString(@"UserFolder") + @"\Documents\";
                string documentsShellPath = userShellFolders.ReadString(@"Personal") + @"\";

                if (documentsShellPath != oneDriveDocumentsPath)
                {
                    UIOption showUI = UIOption.AllDialogs;
                    UICancelOption onUserCancel = UICancelOption.ThrowException;
                    FileIOPermission f = new FileIOPermission(PermissionState.Unrestricted);
                    f.AllFiles = FileIOPermissionAccess.AllAccess;
                    FileSystem.CopyDirectory(documentsShellPath, oneDriveDocumentsPath, showUI, onUserCancel);

                    userShellFolders.WriteString(@"Personal", oneDriveDocumentsPath.TrimEnd(char.Parse(@"\")));
                }
            }
            catch (Exception dMoveEx)
            {
                MessageBox.Show(dMoveEx.Message);
            }
            RestartProcess.RestartProcessByFileName("explorer");

            UpdateOnedriveInfo();
        }

        private void Firmware_Click(object sender, EventArgs e)
        {
            ThreadStart chilRef = new ThreadStart(FirmwareInstall);
            Thread t = new Thread(chilRef);
            t.Start();

        }
        
        public void FirmwareInstall()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(@"https://ftp.hp.com/pub/softpaq/sp88001-88500/sp88053.exe", "Hp-Folio-9470m-BIOS.exe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestoreOneDriveReg();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process process = Process.Start(@"Services\TotalUninstaller.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"Services\SetDefaultBrowser\SetDefaultBrowser.exe";
                psi.Arguments = "HKLM \"Google Chrome\"";
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                Process proc = Process.Start(psi);
            }
            catch(Win32Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
