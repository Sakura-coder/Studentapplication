using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class VerificationCodeUtil
    {
        //制作计算型验证码
        private int X;//第一个数字
        private int Y;//第二个数字
        private string operatorCode;//运算符，例如加减乘除(不做除法，因为除法涉及小数，不便于用户填写)
        private Random r = new Random();//随机数生成器
        //private string vc;//数字型验证码

        public int Z { get; set; }//获取运算后的成果

        public string SetVerificationCode() 
        {
            X = r.Next(0, 20);//生成第一个数，范围在-50~50之间
            Y = r.Next(0, 20);//生成第二个数，范围在-50~50之间
            int i = r.Next(1, 4);//生成符号标识
            switch(i)
            {
                case 1: operatorCode = "加"; Z = X + Y; break;
                case 2: operatorCode = "减"; Z = X - Y; break;
                case 3: operatorCode = "乘"; Z = X * Y; break;
            }
            return X.ToString() + operatorCode + Y.ToString() + "= ?";
        }
        public string VCode()
        {
            Random r = new Random();//随机数生成器
            string vc = "";
            for (int i = 0; i < 6;i++)
            {
                vc += r.Next(0, 10);
            }
            return vc;
        }
    }
}
