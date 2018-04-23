using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class calc : Form
    {
        Point mouse_offset;
        private double op0, op1, op2, resultnum;
        private string opt="null";
        public bool bolNum(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                byte tempByte = Convert.ToByte(temp[i]);
                if ((tempByte < 48) || (tempByte > 57))
                    return false;
            }
            return true;
        }
    
        public calc()
        {
            InitializeComponent();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "7";
            }
            else
            {
                result.Text = "7";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            this.close.Image = this.closered.Image;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.Image = this.closetransp.Image;
        }

        private void calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos =calc.MousePosition;
                mousePos.Offset(mouse_offset.X,mouse_offset.Y );
                Location = mousePos;
            }
        }

        private void calc_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = calc.MousePosition;
                Point titleLoc = title.Location;
                mousePos.Offset(mouse_offset.X - titleLoc.X,mouse_offset.Y - titleLoc.Y);
                Location = mousePos;
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void calc_Load(object sender, EventArgs e)
        {
            this.result.Text = "0";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "8";
            }
            else
            {
                result.Text = "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "9";
            }
            else
            {
                result.Text = "9";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "4";
            }
            else
            {
                result.Text = "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "5";
            }
            else
            {
                result.Text = "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "6";
            }
            else
            {
                result.Text = "6";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "1";
            }
            else
            {
                result.Text = "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "2";
            }
            else
            {
                result.Text = "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "3";
            }
            else
            {
                result.Text = "3";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text != "0" & result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷" & result.Text != "除数不能为零" & result.Text != "溢出")
            {
                result.Text = result.Text + "0";
            }
            else
            {
                result.Text = "0";
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            this.result.Text = "0";
            opt = "null";
            op1 = 0;
            op2 = 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                return;
            }
            if (result.Text == "+" || result.Text == "－" || result.Text == "-" || result.Text == "×" || result.Text == "÷" || result.Text == "除数不能为零" || result.Text == "溢出")
            {
                return;
            }
            if (result.Text.Contains("E+") || result.Text.Contains("E")||result.Text.Contains("E-"))
            {
                return;
            }           
            if (result.Text.Contains("."))
            {
                return;
            }
            else
            {
                result.Text = result.Text + ".";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+"||result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if (result.Text == "除数不能为零" || result.Text == "-" || result.Text == "溢出")
            {
                return;
            }
            else if (result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷")
            {
                if (result.Text.Contains("%"))
                {
                    try
                    {
                        op0 = double.Parse(result.Text.Remove(result.Text.Length - 1, 1));
                        op1 = op0 * 0.01;
                    }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                else
                {
                    try { op1 = double.Parse(result.Text); }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                opt = "plus";
                result.Text = "+";
            }
            else
            {
                opt = "plus";
                result.Text = "+";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+" || result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if (result.Text == "除数不能为零" || result.Text == "-" || result.Text == "溢出")
            {
                return;
            }
            else if (result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷")
            {
                if (result.Text.Contains("%"))
                {
                    try
                    {
                        op0 = double.Parse(result.Text.Remove(result.Text.Length - 1, 1));
                        op1 = op0 * 0.01;
                    }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                else
                {
                    try { op1 = double.Parse(result.Text); }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                opt = "minus";
                result.Text = "－";
            }
            else
            {
                opt = "minus";
                result.Text = "－";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+" || result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if (result.Text == "除数不能为零" || result.Text == "-" || result.Text == "溢出")
            {
                return;
            }
            else if (result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷")
            {
                if (result.Text.Contains("%"))
                {
                    try
                    {
                        op0 = double.Parse(result.Text.Remove(result.Text.Length - 1, 1));
                        op1 = op0 * 0.01;
                    }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                else
                {
                    try { op1 = double.Parse(result.Text); }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                opt = "multiply";
                result.Text = "×";
            }
            else
            {
                opt = "multiply";
                result.Text = "×";
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+" || result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if (result.Text == "除数不能为零" || result.Text == "-" || result.Text == "溢出")
            {
                return;
            }
            else if (result.Text != "+" & result.Text != "－" & result.Text != "×" & result.Text != "÷")
            {
                if (result.Text.Contains("%"))
                {
                    try
                    {
                        op0 = double.Parse(result.Text.Remove(result.Text.Length - 1, 1));
                        op1 = op0 * 0.01; 
                    }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                else
                {
                    try { op1 = double.Parse(result.Text); }
                    catch
                    {
                        result.Text = "溢出";
                        opt = "null";
                    }
                }
                opt = "devide";
                result.Text = "÷";
            }
            else
            {
                opt = "devide";
                result.Text = "÷";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "－" || result.Text == "×" || result.Text == "÷" || result.Text == "除数不能为零" || result.Text == "溢出")
            {
                return;
            }
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+"||result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if (result.Text.Contains("%"))
            {
                try
                {
                    result.Text = result.Text.Remove(result.Text.Length - 1, 1);
                    op2 = double.Parse(result.Text);
                    op2 = op2 * 0.01;
                }
                catch
                {
                    result.Text = "溢出";
                    opt = "null";
                }
            }
            else
            {
                try { op2= double.Parse(result.Text); }
                catch
                {
                    result.Text = "溢出";
                    opt = "null";
                }
            }
            switch (opt)
            {
                case "null":
                    return;
                case "percent":
                    resultnum = op2;
                    break;
                case "plus":
                    resultnum = op1 + op2;
                    break;
                case "minus":
                    resultnum = op1 - op2;
                    break;
                case "multiply":
                    resultnum = op1 * op2;
                    break;
                case "devide":
                    if (op2 == 0)
                    {
                        result.Text = "除数不能为零";
                        return;
                    }
                    else
                    {
                        resultnum = op1 / op2;
                        break;
                    }
            }
            result.Text = resultnum.ToString();
            opt = "null";

        }

        private void negative_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("%"))
            {
                try
                {
                    result.Text = result.Text.Remove(result.Text.Length - 1, 1);
                    op0 = double.Parse(result.Text);
                    op0 = -op0;
                    result.Text = op0 + "%";
                }
                catch
                {
                    result.Text = "溢出";
                    opt = "null";
                }
                return;
            }
            if (result.Text == "除数不能为零" || result.Text == "溢出")
            {
                return;
            }
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+" || result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }
            if(result.Text=="-")
            {
                result.Text="0";
            }
            else if (result.Text != "+" & result.Text != "－"& result.Text != "×" & result.Text != "÷")
            {
                try
                {
                    op0 = double.Parse(result.Text);
                    op0 = -op0;
                    result.Text = op0.ToString();
                }
                catch
                {
                    result.Text = "溢出";
                    opt = "null";
                }
            }
            else
            {
                return;
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "－" || result.Text == "×" || result.Text == "÷")
            {
                result.Text = op1.ToString();
                return;
            }
            else if (result.Text == "除数不能为零" ||result.Text == "溢出")
            {
                result.Text="0";
            }
            else if (result.Text.Length<=1)
            {
                result.Text="0";
            }
            else
            {
                result.Text = result.Text.Remove(result.Text.Length-1,1);
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "－" || result.Text == "-" || result.Text == "×" || result.Text == "÷" || result.Text == "除数不能为零" || result.Text == "溢出")
            {
                return;
            }
            if (result.Text.Length >= 2)
            {
                if (result.Text.Substring(result.Text.Length - 2, 2) == "E+" || result.Text.Substring(result.Text.Length - 2, 2) == "E-")
                {
                    return;
                }
            }
            if (result.Text.Length >= 1)
            {
                if (result.Text.Substring(result.Text.Length - 1, 1) == "E")
                {
                    return;
                }
            }   
            if (result.Text.Contains("%"))
            {
                return;
            }
            else
            {
                result.Text = result.Text + "%";
                if(opt=="null")
                {
                    opt = "percent";
                }
            }
        }
        
    }
}
