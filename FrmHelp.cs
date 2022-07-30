using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCSetupTool
{
    public partial class FrmHelp : Form
    {
        public FrmHelp(int x,int y)
        {
            InitializeComponent();
            this.SetDesktopLocation(x, y);
        }
    }
}
