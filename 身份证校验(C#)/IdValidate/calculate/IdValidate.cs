using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace calculate
{
    public partial class IdValidate : Form
    {
        Point mouse_offset;

        public IdValidate()
        {
            InitializeComponent();
        }



        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            this.close.Image = Properties.Resources.关闭1;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.Image = Properties.Resources.关闭;
        }

        private void calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
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
                Point mousePos = Control.MousePosition;
                Point titleLoc = title.Location;
                mousePos.Offset(mouse_offset.X - titleLoc.X, mouse_offset.Y - titleLoc.Y);
                Location = mousePos;
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void calc_Load(object sender, EventArgs e)
        {
            this.txtId.Text = "";
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (txtId.Text.Length == 17 && (e.KeyChar == 'X' || e.KeyChar == 'x') && !(txtId.Text.Contains("x") || txtId.Text.Contains("X")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Boolean flag=validateId();
            if (flag==false)
                return;
            getLocation();
            getMoreLocation();
            getSex();
            getBirth();
            getAge();
        }

        private Boolean validateId()
        {
            Regex regex = new Regex("[1-8][0-9]{5}[0-9]{11}[0-9||X||x]");	    
		    if(regex.IsMatch(txtId.Text)){
			    //出生年月校验
	            String date=txtId.Text.Substring(6, 8);
	            try {
	        		DateTime dt=DateTime.ParseExact(date,"yyyyMMdd",System.Globalization.CultureInfo.CurrentCulture);
			    } catch{
                    MessageBox.Show("身份证号出生年月编码" + date + "有误", "错误");
					return false;
			    }			
	            //第18位校验码校验
	            int[] w = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };  
	            int sum = 0;  
                char[] charArray=txtId.Text.ToCharArray();
	            for (int i = 0; i < w.Length; i++) {  
	                sum += ( charArray[i]- '0') * w[i];  
	            }  
	            // 用加出来和除以11，看余数是多少？  
	            char[] ch = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };       
	            int c = sum % 11;  
	            /* 
	             * 分别对应的最后 一位身份证的号码为 1－0－X－9－8－7－6－5－4－3－2。 
	            */  
	            char code = ch[c];  
	            char last = charArray[17];  
	            last = last == 'x' ? 'X' : last;
                if (!(last == code))
                {
                    DialogResult result=MessageBox.Show("第十八位校验位错误，是否自动更正？","错误",MessageBoxButtons.YesNo);
                    if(result==DialogResult.Yes)
                    {
                        txtId.Text = txtId.Text.Substring(0,17) +code.ToString();
                        return true;
                    }
                    return false;
                }
                MessageBox.Show("身份证号正确", "填写正确");
                return true;
		    }else{
                MessageBox.Show("身份证号错误", "填写错误");
                return false;
		    }
	    }

        private void getAge()
        {
            try
            {
                String date = txtId.Text.Substring(6, 8);
                DateTime dt = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                int intAge = Int32.Parse((DateTime.Now.Year).ToString()) - Int32.Parse(dt.Year.ToString());
                if (DateTime.Now.Month < dt.Month || (DateTime.Now.Month == dt.Month && DateTime.Now.Day < dt.Day))
                {
                    intAge--;
                }
                String strAge=intAge.ToString();
                lblAgeState.Text = strAge +"岁";
            }
            catch
            {
                lblAgeState.Text = "暂无信息";
                return;
            }
        }

        private void getBirth()
        {      
            try
            {
                String date = txtId.Text.Substring(6, 8);
                DateTime dt = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                lblDateState.Text = dt.ToString("yyyy年MM月dd日");
            }
            catch
            {
                lblDateState.Text="暂无信息";
                return;
            }		
        }

        private void getLocation()
        {
            try
            {
                String str = txtId.Text.Substring(0, 2);
                if (str == "11")
                {
                    lblLocationState.Text = "北京市";
                }
                else if (str == "12")
                {
                    lblLocationState.Text = "天津市";
                }
                else if (str == "13")
                {
                    lblLocationState.Text = "河北省";
                }
                else if (str == "14")
                {
                    lblLocationState.Text = "山西省";
                }
                else if (str == "15")
                {
                    lblLocationState.Text = "内蒙古自治区";
                }
                else if (str == "21")
                {
                    lblLocationState.Text = "辽宁省";
                }
                else if (str == "22")
                {
                    lblLocationState.Text = "吉林省";
                }
                else if (str == "23")
                {
                    lblLocationState.Text = "黑龙江省";
                }
                else if (str == "31")
                {
                    lblLocationState.Text = "上海市";
                }
                else if (str == "32")
                {
                    lblLocationState.Text = "江苏省";
                }
                else if (str == "33")
                {
                    lblLocationState.Text = "浙江省";
                }
                else if (str == "34")
                {
                    lblLocationState.Text = "安徽省";
                }
                else if (str == "35")
                {
                    lblLocationState.Text = "福建省";
                }
                else if (str == "36")
                {
                    lblLocationState.Text = "江西省";
                }
                else if (str == "37")
                {
                    lblLocationState.Text = "山东省";
                }
                else if (str == "41")
                {
                    lblLocationState.Text = "河南省";
                }
                else if (str == "42")
                {
                    lblLocationState.Text = "湖北省";
                }
                else if (str == "43")
                {
                    lblLocationState.Text = "湖南省";
                }
                else if (str == "44")
                {
                    lblLocationState.Text = "广东省";
                }
                else if (str == "45")
                {
                    lblLocationState.Text = "广西省";
                }
                else if (str == "46")
                {
                    lblLocationState.Text = "海南省";
                }
                else if (str == "50")
                {
                    lblLocationState.Text = "重庆市";
                }
                else if (str == "51")
                {
                    lblLocationState.Text = "四川省";
                }
                else if (str == "52")
                {
                    lblLocationState.Text = "贵州省";
                }
                else if (str == "53")
                {
                    lblLocationState.Text = "云南省";
                }
                else if (str == "54")
                {
                    lblLocationState.Text = "西藏自治区";
                }
                else if (str == "61")
                {
                    lblLocationState.Text = "陕西省";
                }
                else if (str == "62")
                {
                    lblLocationState.Text = "甘肃省";
                }
                else if (str == "63")
                {
                    lblLocationState.Text = "青海省";
                }
                else if (str == "64")
                {
                    lblLocationState.Text = "宁夏回族自治区";
                }
                else if (str == "65")
                {
                    lblLocationState.Text = "新疆维吾尔自治区";
                }
                else if (str == "71")
                {
                    lblLocationState.Text = "台湾省";
                }
                else if (str == "81")
                {
                    lblLocationState.Text = "香港特别行政区";
                }
                else if (str == "82")
                {
                    lblLocationState.Text = "澳门特别行政区";
                }
                else
                {
                    lblLocationState.Text = "暂无信息";
                }
            }
            catch
            {
                return;
            }
        }

        private void getMoreLocation()
        {
            try
            {
                String str = txtId.Text.Substring(2, 4);
                if (lblLocationState.Text == "北京市")
                {
                    
                }
                else if (lblLocationState.Text == "天津市")
                {
                    
                }
                else if (lblLocationState.Text =="河北省")
                {
                    ;
                }
                else if ( lblLocationState.Text == "山西省")
                {
                   ;
                }
                else if (lblLocationState.Text == "内蒙古自治区")
                {
                    
                }
                else if (lblLocationState.Text == "辽宁省")
                {
                    ;
                }
                else if (lblLocationState.Text == "吉林省")
                {
                   ;
                }
                else if (lblLocationState.Text == "黑龙江省")
                {
                    ;
                }
                else if ( lblLocationState.Text == "上海市")
                {
                    if (str == "0101")
                    {
                        lblLocationState.Text = lblLocationState.Text + "黄浦区";
                    }
                    else if (str == "0102")
                    {
                        lblLocationState.Text = lblLocationState.Text + "黄浦区";
                    }
                    else if (str == "0103")
                    {
                        lblLocationState.Text = lblLocationState.Text + "黄浦区";
                    }
                    else if (str == "0104")
                    {
                        lblLocationState.Text = lblLocationState.Text + "徐汇区";
                    }            
                    else if (str == "0105")
                    {
                        lblLocationState.Text = lblLocationState.Text + "长宁区";
                    }
                    else if (str == "0106")
                    {
                        lblLocationState.Text = lblLocationState.Text + "静安区";
                    }
                    else if (str == "0107")
                    {
                        lblLocationState.Text = lblLocationState.Text + "普陀区";
                    }
                    else if (str == "0108")
                    {
                        lblLocationState.Text = lblLocationState.Text + "静安区";
                    }
                    else if (str == "0109")
                    {
                        lblLocationState.Text = lblLocationState.Text + "虹口区";
                    }
                    else if (str == "0110")
                    {
                        lblLocationState.Text = lblLocationState.Text + "杨浦区";
                    }
                    else if (str == "0111")
                    {
                        lblLocationState.Text = lblLocationState.Text + "宝山区";
                    }
                    else if (str == "0112")
                    {
                        lblLocationState.Text = lblLocationState.Text + "闵行区";
                    }
                    else if (str == "0113")
                    {
                        lblLocationState.Text = lblLocationState.Text + "宝山区";
                    }
                    else if (str == "0114")
                    {
                        lblLocationState.Text = lblLocationState.Text + "嘉定区";
                    }
                    else if (str == "0115")
                    {
                        lblLocationState.Text = lblLocationState.Text + "浦东新区";
                    }
                    else if (str == "0116")
                    {
                        lblLocationState.Text = lblLocationState.Text + "金山区";
                    }
                    else if (str == "0117")
                    {
                        lblLocationState.Text = lblLocationState.Text + "松江区";
                    }
                    else if (str == "0118")
                    {
                        lblLocationState.Text = lblLocationState.Text + "青浦区";
                    }
                    else if (str == "0119")
                    {
                        lblLocationState.Text = lblLocationState.Text + "浦东新区";
                    }
                    else if (str == "0120")
                    {
                        lblLocationState.Text = lblLocationState.Text + "奉贤区";
                    }
                    else if (str == "0151")
                    {
                        lblLocationState.Text = lblLocationState.Text + "崇明区";
                    }
                    else if (str == "0220")
                    {
                        lblLocationState.Text = lblLocationState.Text + "";
                    }
                    else if (str == "0221")
                    {
                        lblLocationState.Text = lblLocationState.Text + "闵行区";
                    }
                    else if (str == "0222")
                    {
                        lblLocationState.Text = lblLocationState.Text + "嘉定区";
                    }
                    else if (str == "0223")
                    {
                        lblLocationState.Text = lblLocationState.Text + "宝山区";
                    }
                    else if (str == "0224")
                    {
                        lblLocationState.Text = lblLocationState.Text + "浦东新区";
                    }
                    else if (str == "0225")
                    {
                        lblLocationState.Text = lblLocationState.Text + "浦东新区";
                    }
                    else if (str == "0226")
                    {
                        lblLocationState.Text = lblLocationState.Text + "奉贤区";
                    }
                    else if (str == "0227")
                    {
                        lblLocationState.Text = lblLocationState.Text + "松江区";
                    }
                    else if (str == "0228")
                    {
                        lblLocationState.Text = lblLocationState.Text + "金山区";
                    }
                    else if (str == "0229")
                    {
                        lblLocationState.Text = lblLocationState.Text + "青浦区";
                    }
                    else if (str == "0230")
                    {
                        lblLocationState.Text = lblLocationState.Text + "崇明区";
                    }
                }
                else if (lblLocationState.Text == "江苏省")
                {
                    ;
                }
                else if (lblLocationState.Text == "浙江省")
                {
                    ;
                }
                else if (lblLocationState.Text == "安徽省")
                {
                    ;
                }
                else if (lblLocationState.Text == "福建省")
                {
                    ;
                }
                else if (lblLocationState.Text == "江西省")
                {
                    ;
                }
                else if (lblLocationState.Text == "山东省")
                {
                    ;
                }
                else if (lblLocationState.Text == "河南省")
                {
                    ;
                }
                else if (lblLocationState.Text == "湖北省")
                {
                    
                }
                else if (lblLocationState.Text == "湖南省")
                {
                    ;
                }
                else if (lblLocationState.Text == "广东省")
                {
                    ;
                }
                else if (lblLocationState.Text == "广西省")
                {
                    ;
                }
                else if (lblLocationState.Text == "海南省")
                {
                    ;
                }
                else if (lblLocationState.Text == "重庆市")
                {
                   ;
                }
                else if (lblLocationState.Text == "四川省")
                {
                    ;
                }
                else if (lblLocationState.Text == "贵州省")
                {
                    ;
                }
                else if (lblLocationState.Text == "云南省")
                {
                    ;
                }
                else if (lblLocationState.Text == "西藏自治区")
                {
                    ;
                }
                else if (lblLocationState.Text == "陕西省")
                {
                    ;
                }
                else if (lblLocationState.Text == "甘肃省")
                {
                    ;
                }
                else if (lblLocationState.Text == "青海省")
                {
                    ;
                }
                else if (lblLocationState.Text == "宁夏回族自治区")
                {
                    ;
                }
                else if (lblLocationState.Text == "新疆维吾尔自治区")
                {
                    ;
                }
                else if (lblLocationState.Text == "台湾省")
                {
                    ;
                }
                else if (lblLocationState.Text == "香港特别行政区")
                {
                    ;
                }
                else if (lblLocationState.Text == "澳门特别行政区")
                {
                    ;
                }
                
            }
            catch
            {
                return;
            }
        }

        private void getSex()
        {
            try
            {
                int num = Int32.Parse(txtId.Text.Substring(16, 1));
                num = num % 2;
                if (num == 0)
                {
                    lblSexState.Text = "女";
                }
                else
                {
                    lblSexState.Text = "男";
                }
            }
            catch
            {
                return;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 5)
            {
                getLocation();
                getMoreLocation();
            }
            if (txtId.Text.Length > 1 && txtId.Text.Length <=5)
            {
                getLocation();
                
            }
            if (txtId.Text.Length > 13)
            {
                getBirth();
                getAge();
            }
            if (txtId.Text.Length > 16)
            {
                getSex();
            }
            if (txtId.Text.Length<=16)
            {
                lblSexState.Text = "暂无信息";                
            }
            if (txtId.Text.Length <=13)
            {
                lblAgeState.Text = "暂无信息";
                lblDateState.Text = "暂无信息";         
            }
            if (txtId.Text.Length <= 5)
            {
                getLocation();
            }
            if (txtId.Text.Length <= 1)
            {
                lblLocationState.Text = "暂无信息";
            }
           
        }
    }
}
