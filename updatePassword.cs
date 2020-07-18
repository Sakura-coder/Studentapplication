using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class updatePassword : Form
    {
        public updatePassword()
        {
            InitializeComponent();
        }
        private string PwdHint = "输入密码";
        private string OKPwdHint = "确认密码";

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == PwdHint)
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = PwdHint;
                Password.ForeColor = Color.Black;
            }
        }

        private void OKPassword_Enter(object sender, EventArgs e)
        {
            if (OKPassword.Text == OKPwdHint)
            {
                OKPassword.Text = "";
                OKPassword.ForeColor = Color.Black;
            }
        }

        private void OKPassword_Leave(object sender, EventArgs e)
        {
            if (OKPassword.Text == "")
            {
                OKPassword.Text = OKPwdHint;
                OKPassword.ForeColor = Color.Black;
            }
        }

        private void Plane_MouseDown(object sender, MouseEventArgs e)
        {
            UIUtil.DragForm(this);//拖拽
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            Plane_MouseDown(sender, e);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UIUtil.CloseForm(this);
            UIUtil.OperForm(Owner);
            //Owner.Visible = true; //将拥有此窗体的父窗体显示出来
            this.Dispose();//释放资源
            this.Close();//关闭当前窗体
        }
    }
}
