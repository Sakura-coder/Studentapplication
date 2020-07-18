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
    public partial class UserLogin : Form
    {
        private VerificationCodeUtil v = new VerificationCodeUtil();//实例化验证码工具类的对象
        public static UserLogin login;//设计全局可调用的登录窗体对象，且不重复创建对象
        public UserLogin()
        {
            InitializeComponent();
            title.Parent = image;//设置父布局
            Minimize.Parent = image;//设置父布局
            Exit.Parent = image;//设置父布局
            Logo.Parent = image;//设置父布局
            Verification.Text = v.SetVerificationCode();//生成验证码
            UIUtil.SetFormRoundRectRgn(this, 3);
            UIUtil.OperForm(this);//淡入动画
            login = this;//保存当前窗体的实例化
        }

        private void GoRegister_Click(object sender, EventArgs e)
        {
            Form Register = new Register();
            /*Register.Show();*///以窗口形式弹出指定的窗体
            //Register.ShowDialog();//以对话框形式弹出指定的窗体
            UIUtil.CloseForm(this);//淡出动画方式隐藏当前窗体
            //Visible = false//隐藏当前窗体
            //创建注册窗体对象
            new Register().Show(this);//以注册窗体为当前窗体的子窗体形式，弹出注册窗体
            Verification.Text = v.SetVerificationCode();//刷新验证码
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            UIUtil.DragForm(this);//拖拽
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            image_MouseDown(sender, e);//调用图片被按下的事件.
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            String s = test();
            MessageBox.Show(s);
        }
        private String test()
        {
            MessageBox.Show("test");//弹窗
            return "test1";//返回值
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form Register = new Register();
            Register.Show(this);//以窗口形式弹出指定的窗体
            //Register.ShowDialog();//ShowDialog()以对话框形式弹出指定的窗体
            UIUtil.CloseForm(this);//淡出动画方式隐藏此窗体
            Hide();
        }

        private void GoLogin_Click(object sender, EventArgs e)
        {
            //登录检查
            //1,检查文本框不为空
            //2,检查验证码是否正确
            //3,检查用户名和密码是否匹配
            string user = User.Text.Trim();
            string pw = PasswordBox.Text.Trim();
            string code = VerificationBox.Text.Trim();
            if (!CheckUtil.CheckSring(user, pw, code))
            {
                MessageBox.Show("请将用户名，密码，验证码填写完");
            }
            else if (code != v.Z.ToString())
            {
                MessageBox.Show("加载失败，正确答案为:" + v.Z.ToString());
            }
            else if (!new UserInfoHelp().Login(user,pw))
            {
                MessageBox.Show("用户名和密码错误!");
            }
            else
            {
                string time = "今天是" + DateTime.Now.ToString("yyyy-MM-dd") + "," + DateTime.Now.ToString("dddd");
                MessageBox.Show("您好，"+UserInfo.UserName + "\n" + "先生/女士，您好，欢迎登录本系统" +"\n" + time) ;
                UIUtil.CloseForm(this);//将本窗体淡出
                new Home().Show();//主界面显示出来
            }
            PasswordBox.Text = "";//清空密码
            VerificationBox.Text = "";//清空答案
            Verification.Text = v.SetVerificationCode();//刷新验证码
        }

        private void FoundPwd_Click(object sender, EventArgs e)
        {
            Form UserRetrievePW = new UserRetrievePW();
            UIUtil.CloseForm(this);
            UserRetrievePW.Show(this);
        }

        private void Verification_Click(object sender, EventArgs e)
        {
            Verification.Text = v.SetVerificationCode();//生成验证码
        }
    }
}
