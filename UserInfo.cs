using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class UserInfo
    {
        public static string User { get; set; }
        public static string Pw { get; set; }
        public static string UserName { get; set; }
        public static string Phone { get; set; }
        public static string Email { get; set; }
        public UserInfo(DataRow loginInfo)
        {
            User = loginInfo[0].ToString();//用户名
            Pw = loginInfo[1].ToString();//密码
            Phone = loginInfo[2].ToString();//手机号码
            UserName = loginInfo[3].ToString();//姓名
            Email = loginInfo[4].ToString();//电子邮箱
        }
    }
}
