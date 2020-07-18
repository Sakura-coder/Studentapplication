using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    class MailUtil
    {
        private string smtpService = "smtp.qq.com"; //smtp协议
        private string sendEmail = "1041251729@qq.com";//发件人
        private string receiveEmail;//收件人
        private string sendPW = "wkxhphjewcsqbbbe"; //第三方登录码
        private SmtpClient smtpClient = new SmtpClient();//决定使用SMTP协议,所以实例化一个SMTP客户端

        private VerificationCodeUtil v = new VerificationCodeUtil(); //生成验证码工具类
        public string Code { get; set; }//验证码

        //使用QQ邮箱发送验证码，返回true为发送成功，返回false为发送失败

        public bool QQ(string s)
        {
            receiveEmail = s;//获取用户填写的邮件地址
            smtpClient.Host = smtpService;//设置服务器对应的SMTP邮件协议
            //构建发件地址和收件地址
            MailAddress sendAddress = new MailAddress(sendEmail, "来自 学生信息管理系统的验证码");//发件人
            MailAddress receiverAddress = new MailAddress(receiveEmail);//收件人

            //构造一个email的message对象和内容信息
            MailMessage message = new MailMessage(sendAddress, receiverAddress);
            message.Subject = "找回密码专用";//主题(标题)
            message.SubjectEncoding = Encoding.UTF8;//主题的字符编码
            Code = v.VCode();//工具类生成验证码
            message.Body = "非常重要!请勿泄露!" + "\n" + "您的验证码:" + Code + "\n" + "时间戳" + DateTime.Now;//邮件内容
            message.BodyEncoding = Encoding.UTF8;//内容的字符编码

            //设置邮件的信息 如登陆密码 帐号

            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; //邮件发送方式:通过网络发送到smtp服务器
            //如果服务器支持安全连接,则将安全连接设为true
            smtpClient.EnableSsl = true;//SSL加密
            try
            {
                //发件人信息
                smtpClient.UseDefaultCredentials = false;//使用默认凭据，则为true，否则为false
                NetworkCredential senderCredential = new NetworkCredential(sendEmail, sendPW);//发件人地址，发件人授权码
                smtpClient.Credentials = senderCredential;//发件人身份验证
                smtpClient.Send(message);//发送邮件
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//发送失败
                return false;
            }
            finally
            {
                message.Dispose();
            }
        }
    }
}
