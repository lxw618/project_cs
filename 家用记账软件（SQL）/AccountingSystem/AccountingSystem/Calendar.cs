using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingSystem
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lbTime.Text = "现在时刻：" + DateTime.Now.ToLongTimeString();
        }
    }
}
