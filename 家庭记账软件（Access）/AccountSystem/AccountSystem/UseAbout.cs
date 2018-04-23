using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class UseAbout : Form
    {
        public UseAbout()
        {
            InitializeComponent();
        }

        private void UseAbout_Load(object sender, EventArgs e)
        {
            cmbRange.Text = "添加帐户";
        }

        private void cmbRange_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "添加帐户")
            {
                lbContent.Text = "1.添加帐户分为两种模式，管理员用户模式和普通用户模式\n"+
                "2.管理员模式下可添加管理员账号，普通用户模式下仅能添加普通用户账号\n"+
                "3.用户名、密码、昵称为必填项目，不能为空\n"+
                "4.账号添加成功后,用户名不能修改";
            }
            else if (cmbRange.Text == "删除帐户")
            {
                lbContent.Text = "1.删除帐户仅供管理员账号使用\n" +
                "2.选择下拉列表中的用户名可让文本框自动显示选中帐户信息\n" +
                "3.账号删除成功后,收支数据仍然保留\n" +
                "4.管理员账户可通过删除、修改收支记录功能删除、修改保留的收支数据";
            }
            else if (cmbRange.Text == "修改帐户信息")
            {
                lbContent.Text = "1.修改帐户分为两种模式，管理员用户模式和普通用户模式\n" +
                "2.管理员模式下可修改所有账号，普通用户模式下仅能修改自己的用户账号\n" +
                "3.用户名、密码、昵称为必填项目，不能为空\n" +
                "4.管理员模式下可将非管理员帐户提升为管理员帐户，也可将自己或管理员帐户降为普通帐户";
            }
            else if (cmbRange.Text == "添加收支记录")
            {
                lbContent.Text = "1.添加收支记录分为两种模式，管理员用户模式和普通用户模式\n" +
                "2.管理员模式下可添加所有账号的收支记录，普通用户模式下仅能添加自己的收支记录\n" +
                "3.用户名、收支时间、金额、收支项目为必填项目，不能为空\n" +
                "4.收支类型分为收入、支出两种类型";
            }
            else if (cmbRange.Text == "删除收支记录")
            {
                lbContent.Text = "1.删除收支记录分为两种模式，管理员用户模式和普通用户模式\n" +
                "2.管理员模式下可删除所有账号的收支记录，普通用户模式下仅能删除自己的收支记录\n" +
                "3.删除时根据数据号删除相应数据，删除的收支记录不可恢复\n" +
                "4.记录删除后若其它窗体仍有余存，可通过刷新按钮更新数据";
            }
            else if (cmbRange.Text == "修改收支记录")
            {
                lbContent.Text = "1.修改收支记录分为两种模式，管理员用户模式和普通用户模式\n" +
                "2.管理员模式下可添加所有账号的收支记录，普通用户模式下仅能添加自己的收支记录\n" +
                "3.修改时根据数据号删除相应数据，收支时间、金额、收支项目为必填项目，不能为空\n" +
                "4.记录修改后若其它窗体仍有余存，可通过刷新按钮更新数据";
            }
            else if (cmbRange.Text == "重置密码")
            {
                lbContent.Text = ""; lbContent.Text = "1.密码重置仅能重置当前用户的密码\n" +
                 "2.管理员帐户下可通过打开修改帐户信息功能修改其他用户的密码，但不能修改自己的密码\n" +
                 "3.重置密码需输入原密码并重复输入新密码\n" +
                 "4.密码修改完成后重置密码窗体将关闭，主窗体仍处于登录状态";
            }
            else
            {
                lbContent.Text = "1.本程序采用Access数据库，不用安装配置数据库环境，装有.Net4.0即可使用\n" +
                 "2.本程序的数据库文件accountsystem.mdb需放置在程序的同一目录下，否则将不能使用\n" +
                 "3.若删除数据库mdb文件，所有数据将会丢失，程序也将不能使用\n" +
                 "4.本程序由上海健康医学院软件技术专业李夏伟编制并作为毕业设计使用";
            }
        }
    }
}
