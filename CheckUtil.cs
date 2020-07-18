using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentApplication
{
    class CheckUtil
    {
        /// <summary>
        /// 验证中国大陆手机号码，返回true表示是，返回false表示不是
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsPhone(string mobile)//验证中国大陆手机号码
        {
            return Regex.IsMatch(mobile, @"^(13|14|15|16|18|19|17)\d{9}$");
        }

        /// <summary>
        /// 验证电子邮箱地址，返回true表示是，返回false表示不是
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, "^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
        }

        /// <summary>
        /// 用于检查字符串变量是否有数据，返回true表示有数据，返回false表示无数据(空)
        /// </summary>
        /// <param name="tx"></param>
        /// <returns></returns>
        public static bool CheckSring(params string[] tx)
        {
            foreach (string temp in tx)
            {
                if (temp == "")
                {
                    return false;
                }
                
            }
            return true;
        }

        /// <summary>
        /// 验证中英文姓名，返回true表示是，返回false表示不是
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsName(string name)
        {
            return Regex.IsMatch(name, "^([\\u4e00-\\u9fa5]{1,20}|[a-zA-Z\\.\\s]{1,20})$");
        }

        internal static bool CheckSring(string id, string name, string v, object dept, string sex)
        {
            throw new NotImplementedException();
        }
    }
}
