using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.Text.RegularExpressions;
using System.IO;
namespace PCSetupTool
{

    public partial class FrmMain : Form
    {
        //[DllImport("kernel32.dll", EntryPoint = "SetComputerNameEx")]
        //public static extern int apiSetComputerNameEx(int type, string lpComputerName);
        //[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool SetCursorPos(int x, int y);
        //[DllImport("user32.dll", EntryPoint = "SendInput")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool SendInput(int x, int y);
        //[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        //public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        //[DllImport("USER32.DLL")]
        //public static extern bool SetForegroundWindow(IntPtr hWnd);



        [DllImport("PowrProf.dll")]
        public static extern UInt32 PowerEnumerate(IntPtr RootPowerKey, IntPtr SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, UInt32 AcessFlags, UInt32 Index, ref Guid Buffer, ref UInt32 BufferSize);
        [DllImport("PowrProf.dll")]
        public static extern UInt32 PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref UInt32 BufferSize);
        [DllImport("powrprof.dll")]
        static extern uint PowerGetActiveScheme( IntPtr UserRootPowerKey, ref IntPtr ActivePolicyGuid);
    
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        FrmHelp frmHelp =null;
        FrmFloat frmFloat = new FrmFloat();
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x02;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x04;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
      

       
        public FrmMain()
        {
            InitializeComponent();

            frmHelp = new FrmHelp(this.DesktopLocation.X + 18, this.DesktopLocation.Y + 88);
            frmFloat.frmMain = this;
            frmFloat.SetDesktopLocation(SystemInformation.PrimaryMonitorSize.Width -3* frmFloat.Width,  2*frmFloat.Height);
        }

        private void BtName_Click(object sender, EventArgs e)
        {
            //int rtn = apiSetComputerNameEx(5, "TestComputerNameModification");
            //System.Console.WriteLine("Computer name set result=" + rtn);
            Process.Start("sysdm.cpl");
        }

        private void BtAccount_Click(object sender, EventArgs e)
        {
            // Process.Start("control.exe", "/name Microsoft.UserAccounts");
            //Process.Start("lusrmgr.msc");
            
            Process.Start("Netplwiz");
        }

        private void BtPowerPlan_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg.cpl");


        }

        private void BtControl_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }

        private void BtShowComputer_Click(object sender, EventArgs e)
        {
            Process.Start("desk.cpl", ",,0");
        }

        private void BtFileExt_Click(object sender, EventArgs e)
        {
            //string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
            //Registry.SetValue(keyName, "HideFileExt", 0, RegistryValueKind.DWord);
            Process.Start("explorer.exe");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("^4");
            //IntPtr calcWindow = FindWindow(null, "explorer.exe");
            //if (SetForegroundWindow(calcWindow))
            Debug.Print("test");
            SendKeys.Send("%V");
            //System.Threading.Thread.Sleep(200);
            //SendKeys.Send("%H");
            //System.Threading.Thread.Sleep(200);
            //SendKeys.Send("%F");


        }

        private void BtTaskBarIcon_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe", "/name Microsoft.Taskbar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void GetInfo()
        {

           
            rtSystemInfo.Text = "PC Name:" + SystemInformation.ComputerName.ToString() + "\n\n";
            rtSystemInfo.Text = rtSystemInfo.Text + "UserName:" + SystemInformation.UserName + "\n\n";

            /* Get OS information*/
            ManagementClass mcWMI = new ManagementClass("Win32_OperatingSystem");
            mcWMI.Path = new ManagementPath("Win32_OperatingSystem");
            ManagementObjectCollection wmiString = mcWMI.GetInstances();
            foreach (ManagementObject item in wmiString) { rtSystemInfo.Text = rtSystemInfo.Text + "OS:" + item["Caption"].ToString() + " " + item["OSArchitecture"].ToString() + " " + item["BuildNumber"].ToString() + "\n\n"; }
            rtSystemInfo.Text = rtSystemInfo.Text + "WinNT:" + Environment.OSVersion.VersionString + " " + (Environment.Is64BitOperatingSystem ? "64bit" : "32bit") + "\n\n";
            //foreach (ManagementObject item in osString) { LablePcInfo.Text = LablePcInfo.Text + "CPU:" + item["Name"].ToString() + "\n\n"; }
            rtSystemInfo.Text += "---------------------\n";
            /*Get CPU information*/
            mcWMI.Path = new ManagementPath("Win32_Processor");
            wmiString = mcWMI.GetInstances();
            foreach (ManagementObject item in wmiString) { rtSystemInfo.Text = rtSystemInfo.Text + "CPU:" + item["Name"].ToString() + "\n\n"; }



            /*Get Memery information*/
            mcWMI.Path = new ManagementPath("Win32_PhysicalMemory");
            wmiString = mcWMI.GetInstances();
            UInt64 mmCapacity = 0;
            foreach (ManagementObject item in wmiString) { mmCapacity += ((UInt64)item["Capacity"] / 1024 / 1024 / 1024); }
            rtSystemInfo.Text = rtSystemInfo.Text + "Memery:" + mmCapacity.ToString() + "GB" + "\n\n";

            /*Get HardDisk information*/
            mcWMI.Path = new ManagementPath("Win32_DiskDrive");
            wmiString = mcWMI.GetInstances();
            foreach (ManagementObject item in wmiString) { rtSystemInfo.Text = rtSystemInfo.Text + "Disk:" + (Convert.ToUInt64(item["Size"]) / 1024 / 1024 / 1024).ToString() + "GB" + " " + item["Caption"].ToString() + "\n\n"; }
            //System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            //long totalFreeSpace = 0;
            //long totalDiskSize = 0;
            //foreach (var drive in drives)
            //{

            //    if (drive.IsReady)   
            //    {
            //        totalFreeSpace += drive.AvailableFreeSpace;
            //        totalDiskSize += drive.TotalSize;
            //    }
            //    if (drive.IsReady)   
            //    {LablePcInfo.Text = LablePcInfo.Text + string.Format("Capacity：{0} Remain：{1}", totalDiskSize / 1024 / 1024 / 1024 + "GB", totalFreeSpace / 1024 / 1024 / 1024 + "GB")   + "\n\n";}
            //}

            //*Get GriaphicCard information*/
            mcWMI.Path = new ManagementPath("Win32_VideoController");
            wmiString = mcWMI.GetInstances();
            foreach (ManagementObject item in wmiString) { rtSystemInfo.Text = rtSystemInfo.Text + "GraphicCard:" + item["Name"].ToString() + " " + (Convert.ToInt64(item["AdapterRAM"]) / 1024 / 1024 / 1024) + "GB" + "\n\n"; }

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powercfg",
                    Arguments ="/GETACTIVESCHEME",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            string line = "";
             line = proc.StandardOutput.ReadLine();
        
            foreach (var item in line.Split(' '))
            {
                Debug.Print(item);
            }
            rtSystemInfo.Text = rtSystemInfo.Text + "PowerPlan:" + Regex.Match(line, @"\((.*?)\)").Groups[1].Value + "\n\n";
            // Process.Start("powercfg", "-CHANGE -monitor -timeout -ac 0");
            // LablePcInfo.Text = LablePcInfo.Text + "PowerPlan:" + Process.Start("powercfg", " /GETACTIVESCHEME")+"\n\n"; 
            Debug.Print(rtSystemInfo.Text);
        }

        
        private void BtSystem_Click(object sender, EventArgs e)
        {
            // Process.Start("winver");
            //Process.Start("control.exe", "/name Microsoft.System");
            Process.Start("ms-settings:about");

        }

        private void BtDevice_Click(object sender, EventArgs e)
        {
            //Process.Start("control"," /name Microsoft.DeviceManager");
            //Process.Start("hdwwiz.cpl");
            Process.Start("devmgmt.msc");
        }

        private void ファイル設定FileConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe","/name Microsoft.AdministrativeTools");
        }
       
        private void BtIcon_Click(object sender, EventArgs e)
        {
            var shell = new Shell32.Shell();
            var shellDispatch = (Shell32.IShellDispatch4)shell;
             shellDispatch.ToggleDesktop();
            //SendKeys.Send("^4");

            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            Thread.Sleep(100);
            //SendKeys.Send("^ ");
            //Thread.Sleep(300);
            //SendKeys.Send("{TAB}");
            SendKeys.Send("+{F10}");
            Thread.Sleep(100);
            SendKeys.Send("V");
            //Thread.Sleep(500);
            Thread.Sleep(100);
            SendKeys.Send("{RIGHT}");
            //SendKeys.Send("{ENTER}");

        }

        private void BtStartup_Click(object sender, EventArgs e)
        {
            Form StartupForm = new FrmStatup();
            StartupForm.Show();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
   
        }

        private void BtLabview_Click(object sender, EventArgs e)
        {

            string resLabviewBak = "PCSetupTool.LabVIEW.ini";
            string labviewiniFile = "C:\\Program Files (x86)\\National Instruments\\LabVIEW 2016\\LabVIEW.ini";
            string labviewPath = "C:\\Program Files (x86)\\National Instruments\\LabVIEW 2016";
            string labviewIniBak = "";
       
             if (Directory.Exists(labviewPath))
            {
                labviewIniBak = labviewiniFile;
                labviewIniBak += ".bak";
            }
            else
            {
                MessageBox.Show("LabVIEW 2016が見つかりませんでした。", "Error", MessageBoxButtons.OK);
                return;
            }

            if (File.Exists(labviewiniFile))
            {
             File.Copy(labviewiniFile, labviewIniBak, true);
             File.Delete(labviewiniFile); 
            }
            try
            {
              using (var resource = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resLabviewBak))
                        {
                            using (var file = new FileStream(labviewiniFile, FileMode.Create, FileAccess.Write))
                            {
                                resource.CopyTo(file);
                            }
                        }
                MessageBox.Show("設定ファイルのコピーが成功しました。", "成功", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("設定失敗", "失敗", MessageBoxButtons.OK);

            }
          
        }

        private void BtBoot_Click(object sender, EventArgs e)
        {
            Process.Start("msconfig.exe");
        }

        private void BtWinOpFeature_Click(object sender, EventArgs e)
        {
            Process.Start("OptionalFeatures.exe");
        }

        private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            frmHelp.SetDesktopLocation(this.DesktopLocation.X+18, this.DesktopLocation.Y+88);
             frmHelp.Show();
        }

        private void helpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            frmHelp.Hide();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
             if (this.WindowState == FormWindowState.Minimized)
                
            {
                frmFloat.Show();
                this.ShowInTaskbar = false;
        
                ////hide
                //this.Visible = false;

                ////notifyIcon
                //notifyIcon1.Visible = true;
            }
            else
            {
                this.Show();
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // Show In Taskbar
             this.ShowInTaskbar = true;

            //window visible
            this.Visible = true;

            //set the window state
            this.WindowState = FormWindowState.Normal;

            //Activate it
            this.Activate();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            //this.BackgroundImage = imageList1.Images[13];

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:k.li@sanyodenken.co.jp");
        }
    }
}
