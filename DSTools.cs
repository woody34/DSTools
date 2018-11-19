using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;
using System.Security.Permissions;
using System.Net;
using System.ComponentModel;
using System.Net.Mail;
using IniParser;
using IniParser.Model;
using NETCore.Encrypt;

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
            LoadAdminGroup();

            bool onedriveInstalled = (onedriveFolder.ReadString(@"UserFolder") == null) ? false : true;
            if (onedriveInstalled)
            {
                onedrive.Text = onedriveFolder.ReadString("UserFolder");
                version.Text = onedriveVersionFolder.ReadString("Version");
                Thread.Sleep(200);
                onedriveButton.Enabled = true;
            }
        }

        private void LoadAdminGroup()
        {
            try
            {

                string newAdmin = newAdminUsername.Text;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"net";
                psi.Arguments = "localgroup administrators";
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                Process proc = Process.Start(psi);
                string stdOut = proc.StandardOutput.ReadToEnd();
                stdOut = stdOut.Remove(0, 217);
                adminGroup.Text = stdOut;
            }
            catch (Win32Exception ee)
            {
                MessageBox.Show(ee.Message);
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


            userShellFolders.WriteString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}", defaultDesktopShellPath);
            userShellFolders.WriteString(@"Desktop", defaultDesktopShellPath);

            try
            {
                if (documentsShellPath != defaultDocumentsShellPath)
                {
                    FileSystem.CopyDirectory(documentsShellPath, defaultDocumentsShellPath, false);
                }
            }
            catch (Exception fileMoveE)
            {
                MessageBox.Show(fileMoveE.Message);
            }

            userShellFolders.WriteString(@"Personal", defaultDocumentsShellPath);

            RestartProcess.KillProcessByFileName("explorer");

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
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"WMIC.exe";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.Arguments = @"ComputerSystem where Name='" + HardwareLibrary.ComputerName() + @"' call Rename Name='" + hostname.Text + "'";
            Process proc = Process.Start(psi);
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

            string oneDriveDesktopPath = onedriveFolder.ReadString("UserFolder") + @"\Desktop\";
            string oneDriveDocumentsPath = onedriveFolder.ReadString(@"UserFolder") + @"\Documents\";
            string desktopShellPath = userShellFolders.ReadString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}") + @"\";
            string documentsShellPath = userShellFolders.ReadString(@"Personal") + @"\";

            try
            {
                if (@desktopShellPath != @oneDriveDesktopPath)
                {
                    UIOption showUI = UIOption.AllDialogs;
                    UICancelOption onUserCancel = UICancelOption.ThrowException;
                    FileSystem.CopyDirectory(@desktopShellPath, @oneDriveDesktopPath, showUI, onUserCancel);
                }
            }
            catch (Exception dMoveEx)
            {
                MessageBox.Show(dMoveEx.Message + dMoveEx.TargetSite);
            }

            userShellFolders.WriteString(@"{754AC886-DF64-4CBA-86B5-F7FBF4FBCEF5}", @oneDriveDesktopPath.TrimEnd(char.Parse(@"\")));
            userShellFolders.WriteString(@"Desktop", @oneDriveDesktopPath.TrimEnd(char.Parse(@"\")));

            try
            {


                if (documentsShellPath != oneDriveDocumentsPath)
                {
                    UIOption showUI = UIOption.AllDialogs;
                    UICancelOption onUserCancel = UICancelOption.ThrowException;
                    FileIOPermission f = new FileIOPermission(PermissionState.Unrestricted);
                    f.AllFiles = FileIOPermissionAccess.AllAccess;
                    FileSystem.CopyDirectory(documentsShellPath, oneDriveDocumentsPath, showUI, onUserCancel);
                }
            }
            catch (Exception dMoveEx)
            {
                MessageBox.Show(dMoveEx.Message);
            }

            userShellFolders.WriteString(@"Personal", oneDriveDocumentsPath.TrimEnd(char.Parse(@"\")));

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

        private void RestoreOneDrive_Click(object sender, EventArgs e)
        {
            RestoreOneDriveReg();
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.Start(@"Services\TotalUninstaller.exe");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DefaultChrome_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"Services\SetDefaultBrowser\SetDefaultBrowser.exe";
                psi.Arguments = "HKLM \"Google Chrome\"";
                psi.UseShellExecute = false;
                Process proc = Process.Start(psi);
            }
            catch(Win32Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void companyLinks_Click(object sender, EventArgs e)
        {
            UIOption showUI = UIOption.AllDialogs;
            UICancelOption onUserCancel = UICancelOption.ThrowException;
            try
            {
                FileSystem.CopyDirectory(@"Company Links", @"C:\Users\Default\Desktop\Company Links", showUI, onUserCancel);
                FileSystem.CopyDirectory(@"Company Links", @"C:\Users\" + Environment.UserName + @"\Desktop\Company Links", showUI, onUserCancel);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void addToStarup_Click(object sender, EventArgs e)
        {

        }

        private void adminAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"net";
                psi.Arguments = @"localgroup administrators " + newAdminUsername.Text + " /add";
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                Process proc = Process.Start(psi);
                LoadAdminGroup();
            }
            catch (Win32Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void adminRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"net";
                psi.Arguments = @"localgroup administrators " + newAdminUsername.Text + " /delete | PAUSE";
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                Process proc = Process.Start(psi);
                LoadAdminGroup();
            }
            catch (Win32Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //ini file
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            //var aesKey = EncryptProvider.CreateAesKey();
            //var key = aesKey.Key;
            //var iv = aesKey.IV;

            //var plainTextPassword = "";
            //var plainTextEmailFrom = "";
            //var plainTextEmailTo = "";

            //var ePass = EncryptProvider.AESEncrypt(plainTextPassword, key, iv);
            //var eEmailFrom = EncryptProvider.AESEncrypt(plainTextEmailFrom, key, iv);
            //var eEmailTo = EncryptProvider.AESEncrypt(plainTextEmailTo, key, iv);

            //data["Auth"]["tbp"] = ePass;
            //data["Auth"]["efr"] = eEmailFrom;
            //data["Auth"]["eto"] = eEmailTo;
            //data["Auth"]["k"] = key;
            //data["Auth"]["4"] = iv;
            //parser.WriteFile("config.ini", data);

            var aesKey = EncryptProvider.CreateAesKey();
            var key = data["Auth"]["k"];
            var iv = data["Auth"]["4"];

            var encryptedP = data["Auth"]["tbp"];
            var decryptedP = EncryptProvider.AESDecrypt(encryptedP, key, iv);

            var encryptedF = data["Auth"]["efr"];
            var decryptedF = EncryptProvider.AESDecrypt(encryptedF, key, iv);

            var encryptedT = data["Auth"]["eto"];
            var decryptedT = EncryptProvider.AESDecrypt(encryptedT, key, iv);

            var fromAddress = new MailAddress(decryptedF);
            var toAddress = new MailAddress(decryptedT);
            string fromPassword = decryptedP;
            string subject = "New Setup-" + hostname.Text;
            string body =
                "Make: " + make.Text + "\n" +
                "Model: " + model.Text + "\n" +
                "Serial: " + machineSerial.Text + "\n" +
                "Hardware ID: " + deviceID.Text + "\n" +
                "Security ID: " + SID.Text + "\n";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
