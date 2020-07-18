using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class UserRetrievePW : Form
    {
        public UserRetrievePW()
        {
            InitializeComponent();
            title.Parent = Image;
            Minimize.Parent = Image;
            Exit.Parent = Image;
            FoundPwd.Parent = Image;
    }
        private string UserHint = "注册时填写的用户名";
        private string MyNameHint = "注册时填写的姓名";
        private string EmailHint = "关联的邮箱地址";
        private string PhoneHint = "关联的手机号码";
        private string VcHint = "验证码（6位数字）";
        private int vcTime = 60;//计时数
        private string Code;//6位验证码
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseEventArgs e)
        {
            UIUtil.DragForm(this);//拖拽
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            Image_MouseDown(sender, e);
        }

        private void FoundPwd_MouseDown(object sender, MouseEventArgs e)
        {
            Image_MouseDown(sender, e);
        }

        private void FoundPwd_MouseDown_1(object sender, MouseEventArgs e)
        {
            Image_MouseDown(sender, e);
        }

        private void EmailPhoneBox_Enter(object sender, EventArgs e)
        {
            EmailPhoneLabel.ForeColor = Color.DeepSkyBlue;
            if (EmailPhoneBox.Text == EmailHint)
            {
                EmailPhoneBox.Text = "";
                EmailPhoneBox.ForeColor = Color.Black;
            }
        }

        private void EmailPhoneBox_Leave(object sender, EventArgs e)
        {
            EmailPhoneLabel.ForeColor = Color.Gray;
            if (EmailPhoneBox.Text == "")
            {
                EmailPhoneBox.Text = EmailHint;
                EmailPhoneBox.ForeColor = Color.Gray;
            }
        }

        private void EmailRadio_CheckedChanged(object sender, EventArgs e)
        {
            EmailPhoneBox.MaxLength = 100;
            if(!CheckTextBox(EmailPhoneBox))
            {
                EmailPhoneBox.Text = EmailHint;
            }
        }
        private bool CheckTextBox (params TextBox[] tx)
        {
            foreach (TextBox t in tx)
            {
                string temp = t.Text.Trim();
                if(temp == "")
                {
                    return false;
                }
                if(temp == UserHint || temp == MyNameHint || temp == PhoneHint || temp == VcHint || temp == EmailHint)
                {
                    return false;
                }
            }
            return true;
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            UserLable.ForeColor = Color.DeepSkyBlue;
            if(UserBox.Text == UserHint)
            {
                UserBox.Text = "";
                UserBox.ForeColor = Color.Black; 
            }
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            UserLable.ForeColor = Color.Gray;
            if (UserBox.Text == "")
            {
                UserBox.Text = UserHint;
                UserBox.ForeColor = Color.Gray;
            }
        }

        private void MyNameBox_Enter(object sender, EventArgs e)
        {
            MyNameLabel.ForeColor = Color.DeepSkyBlue;
            if (MyNameBox.Text == MyNameHint)
            {
                MyNameBox.Text = "";
                MyNameBox.ForeColor = Color.Black;
            }
        }

        private void MyNameBox_Leave(object sender, EventArgs e)
        {
            MyNameLabel.ForeColor = Color.Gray;
            if (MyNameBox.Text == "")
            {
                MyNameBox.Text = MyNameHint;
                MyNameBox.ForeColor = Color.Gray;
            }
        }

        private void VcBox_Enter(object sender, EventArgs e)
        {
            VcLabel.ForeColor = Color.DeepSkyBlue;
            if (VcBox.Text == VcHint)
            {
                VcBox.Text = "";
                VcBox.ForeColor = Color.Black;
            }
        }

        private void VcBox_Leave(object sender, EventArgs e)
        {
            VcBox.ForeColor = Color.Gray;
            if (VcBox.Text == "")
            {
                VcBox.Text = VcHint;
                VcBox.ForeColor = Color.Gray;
            }
        }

        private void VcButton_Click(object sender, EventArgs e)
        {
            if(CheckTextBox(EmailPhoneBox))//检查是否填写数据
            {
                string s = EmailPhoneBox.Text;
                if(EmailRadio.Checked)//如果为true,则说明选择的是邮箱
                {
                    if (CheckUtil.IsEmail(s))//判断是否为真实邮箱，为true则是
                    {
                        //if()验证是否为该用户注册时绑定的邮箱地址
                        //{
                        MailUtil mailUtil = new MailUtil();//创建邮件工具类的对象
                        if (mailUtil.QQ(s))
                        {
                            VcButton.Enabled = false;//禁用按钮
                            timer1.Enabled = true;//开启一分钟计时器
                            MessageBox.Show("发送成功");
                            Code = mailUtil.Code;
                        }
                        else MessageBox.Show("发送失败");
                        //}
                        //else MessageBox.Show("用户名 与 邮箱地址 不匹配");
                    }
                    else MessageBox.Show("此邮箱地址不正确，请重新填写!","邮箱地址有误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else //否则，选择的是手机
                {
                    if (CheckUtil.IsPhone(s))//是否为中国大陆号码，为true则是
                    {
                        if (true)//验证是否为该用户注册时绑定的
                        {
                            if (SMSAPI.GoSMS(s))//发送验证码到手机
                            {
                                VcButton.Enabled = false;//禁用按钮
                                timer1.Enabled = true;//开启一分钟计时器
                                MessageBox.Show("发送成功!");
                                Code = SMSAPI.Code;
                            }
                            else MessageBox.Show(SMSAPI.Code);//发送失败，给出错误信息
                        }
                        else MessageBox.Show("用户名与手机号码不匹配!");
                    }
                    else MessageBox.Show("此手机号码不是中国大陆手机号码,请重新填写!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(vcTime == 0)
            {
                timer1.Enabled = false;//关闭计时器
                VcButton.Enabled = true;//启用按钮
                VcButton.Text = "未收到？重新发送验证码";
                vcTime = 60;//重置计时数
            }
            else
            {
                vcTime -= 1;//减法计数
                VcButton.Text = "已发送验证码(" + vcTime.ToString() + "秒)";//设置文本为“已发送短信（X秒后重发）”
            }
        }

        private void GoUpdatePW_Click(object sender, EventArgs e)
        {
            string user = UserBox.Text.Trim();
            string name = MyNameBox.Text.Trim();
            string email_Phone = EmailPhoneBox.Text.Trim();
            string code = VcBox.Text.Trim();
            string s;//s有两种值，电子邮箱，手机号码
            if (EmailRadio.Checked) s = "电子邮箱"; else s = "手机号码";
            if(!CheckUtil.CheckSring(user,name,email_Phone,code))//验证所有文本框均不空且不为默认值，为空则返回false，注意，取反
            {
                MessageBox.Show("用户名丶姓名丶手机号码丶验证码均为必填项", "必填项", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (code != Code)
            {
                MessageBox.Show("验证码不匹配，请检查" + s + "接收的6位验证码", "验证码错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new UserInfoHelp().RetrievePassword(user,name,email_Phone))
            {
                MessageBox.Show("您填写的用户名，姓名，" + s + "，三者信息不匹配，请修改后再尝试", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UIUtil.CloseForm(this);
                Close();
                new updatePassword().Show();
            }
        }
    }
}