using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PCSetupTool
{
    public partial class FrmStatup : Form
    {
        string taskPara;
        public FrmStatup()
        {
            InitializeComponent();
        }

        private void FrmStatup_DragDrop(object sender, DragEventArgs e)
        {
            comboBox1.Items.Insert(0, ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
            comboBox1.SelectedIndex = 0;
        }


        private void FrmStatup_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OfdSelectAPP.Filter = "exe files (*.exe)|*.exe|lnk files (*.lnk)|*.lnk";
            //string windir = Environment.SystemDirectory; // C:\windows\system32
            OfdSelectAPP.InitialDirectory = Path.GetPathRoot(Environment.SystemDirectory);
            Debug.Print(Environment.NewLine);
            if (OfdSelectAPP.ShowDialog() == DialogResult.OK)
            {
                string sFileName = OfdSelectAPP.FileName;
                comboBox1.Items.Insert(0, sFileName);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void OfdSelectAPP_FileOk(object sender, CancelEventArgs e)
        {
            ////OfdSelectAPP;
            //comboBox1.Items.Insert(0, ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
            //comboBox1.SelectedIndex = 0;
        }

        private void BtTask_Click(object sender, EventArgs e)
        {

            Process.Start("taskschd.msc ");

            //Process.Start("control", "schedtasks");
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            string tst="";
            int secon = (int)numericUpDown1.Value;
            if (secon >= 60)
            {

            }
            else
            {
                tst = String.Format("0000:{0,2}",secon.ToString());
            }

          
            if (comboBox1.SelectedItem != null)
            {


                taskPara = "/Delete /TN PCToolStartupTask1 /F";
                taskPara = "/Delete /TN PCToolStartupTask2 /F";

                Debug.Print(taskPara);
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = "schtasks";
                    proc.StartInfo.Arguments = taskPara;
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.Verb = "runas";
                    proc.Start();
                    Thread.Sleep(500);
                    //Process.Start("schtasks", taskPara);
                    if (checkBox1.Checked == true)
                    {
                    taskPara = "/Create /SC ONLOGON /TN PCToolStartupTask /delay " + tst + " /TR " + comboBox1.SelectedItem.ToString();
                    }
                    taskPara = "/Create /SC ONLOGON /TN PCToolStartupTask /delay " + tst + " /TR " + comboBox1.SelectedItem.ToString();
                    Debug.Print(taskPara);
                    Process proc1 = new Process();
                    proc.StartInfo.FileName = "schtasks";
                    proc.StartInfo.Arguments = taskPara;
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.Verb = "runas";
                    proc.Start();

                }
                catch (Exception)
                {
                    MessageBox.Show("失敗しました。\nタスクスケジューラをで確認してください。（Failed）","失敗", MessageBoxButtons.OK);



                }
         
               
                //schtasks /Create /SC ONLOGON /TN TheTest /delay 0000:10 /TR C:\Users\Shenzhong\Desktop\WinTools.exe
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBoxUseName.Enabled = true;
                textBoxPws.Enabled = true;
            }
            else
            {
                comboBoxUseName.Enabled = false;
                textBoxPws.Enabled = false;

            }
           
         }
    }
}
