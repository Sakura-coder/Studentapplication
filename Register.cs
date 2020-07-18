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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            logo.Parent = image;
            RegisterImage.Parent = image;
            label1.Parent = image;
            label2.Parent = image;
            label3.Parent = image;
            label4.Parent = image;
            label5.Parent = image;
            label6.Parent = image;
            label7.Parent = image;
            Minimize.Parent = image;
            Exit.Parent = image;
            User.Parent = image;
            Password.Parent = image;
            OKPassword.Parent = image;
            Phone.Parent = image;
            MyName.Parent = image;
            Email.Parent = image;
            UIUtil.OperForm(this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UIUtil.CloseForm(this);
            UIUtil.OperForm(Owner);
            //Owner.Visible = true; //将拥有此窗体的父窗体显示出来
            this.Dispose();//释放资源
            this.Close();//关闭当前窗体
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            UIUtil.DragForm(this);
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            UIUtil.DragForm(this);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string user = User.Text.Trim();//用户名
            string pw = Password.Text.Trim();//密码
            string okpw = OKPassword.Text.Trim();//确认密码
            string phone = Phone.Text.Trim();//手机号码
            string name = MyName.Text.Trim();//名字
            string email = Email.Text.Trim();//邮箱
            if(!CheckUtil.CheckSring(user,pw,okpw,phone,name,email))//检测到各个文本框为空
            {
                MessageBox.Show("请填写注册信息,不要留空");
            }
            else if (user.Length<4 || pw.Length<4 || okpw.Length<4)//如果用户名，密码，确认密码文本框输入长度小于4
            {
                MessageBox.Show("用户名和密码的长度应在4~6位");
            }
            else if(pw!=okpw)//检测到密码和确认密码不一致
            {
                MessageBox.Show("两次密码不一致，请修改并牢记您的密码");
            }
            else if (!CheckUtil.IsPhone(phone))//检测到不是手机号码
            {
                MessageBox.Show("该号码不是中国大陆手机号码，暂不支持注册");
            }
            else if (!CheckUtil.IsName(name))//检测到不是真实姓名
            {
                MessageBox.Show("请输入真实姓名!");
            }
            else if (!CheckUtil.IsEmail(email))//检测到不是邮箱
            {
                MessageBox.Show("请输入正确的电子文档");
            }
            else if (new UserInfoHelp().SelectUserID(user))
            {
                MessageBox.Show("该用户名已被注册，请更换后重试");
            }
            else if (new UserInfoHelp().SelectPhone(phone))
            {
                MessageBox.Show("该手机号码已被使用");
            }
            else if (new UserInfoHelp().SelectEmail(email))
            {
                MessageBox.Show("该电子邮箱已被使用");
            }
            else if(new UserInfoHelp().Register(user, pw, name, phone, email))
            {
                MessageBox.Show("注册失败,原因未知,请检查网络和您填写的信息,请稍后再试");
            }
            else
            {
                MessageBox.Show(name + "先生/女士,您的账号" + user + "注册成功!" + '\n' + "注册成功!" + '\n' + "请牢记您的账号和密码，如若遗忘，请通过找回密码功能重置密码");
                MessageBox.Show("接下来将带您返回到登录界面");
                Owner.Tag = user;
                Exit_Click(sender, e);
            }
        }

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            //除英文和数字之外不允许输入
            if(e.KeyChar == '\b' || char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false; //不处理此次事件，对输入的字符放行
            }
            else
            {
                e.Handled = true; //处理这次事件，对输入的字符拦截
            }
        }
    }
}
