using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    /// <summary>
    /// User用户表的帮助类，具有增改查用户信息的功能
    /// </summary>
    class UserInfoHelp
    {
        private string sql;//SQL语句
        private SqlParameter[] sqlParameters;//参数化查询数组

        /// <summary>
        /// 根据指定的列，检查值是否存在，存在返回true，不存在返回false
        /// </summary>
        /// <param name="row">列</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public bool SelectColumn(string column,string value)
        {
            sql = "select * from Users where " + column + "=@value";
            sqlParameters = new SqlParameter[1];//初始化参数位
            sqlParameters[0] = new SqlParameter("@value", value);//将值传入参数中
            if (DBUtil.ExecuteSelect(sql, sqlParameters) > 0)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// 查询用户名是否存在，存在返回true，不存在返回false
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SelectUserID(string id)
        {
            return SelectColumn("UserID", id);
        }
        /// <summary>
        /// 查询手机号码是否存在，存在返回true，不存在返回false
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool SelectPhone (string phone)
        {
            return SelectColumn("Phone", phone);
        }
        /// <summary>
        /// 查询电子邮箱是否存在，存在返回true，不存在返回false
        /// </summary>
        public bool SelectEmail(string email)
        {
            return SelectColumn("Email", email);
        }
        /// <summary>
        /// 注册用户 成功返回true 失败返回false
        /// </summary>
        /// <param name="id">用户名</param>
        /// <param name="pw">密码</param>
        /// <param name="name">姓名</param>
        /// <param name="phone">电话号码</param>
        /// <param name="email">电子邮箱</param>
        /// <returns></returns>
        public bool Register(string id,string pw,string name,string phone,string email)
        {
            sql = "insert into Users values(@id,@pw,@name,@phone,@email)";
            sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", id);
            sqlParameters[1] = new SqlParameter("@pw", pw);
            sqlParameters[2] = new SqlParameter("@name", name);
            sqlParameters[3] = new SqlParameter("@phone", phone);
            sqlParameters[4] = new SqlParameter("@email", email);
            if (DBUtil.ExecuteNonQuery(sql, sqlParameters) == 1)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// 登录检查，成功返回true，失败返回false
        /// </summary>
        /// <param name="id">用户名</param>
        /// <param name="pw">密码</param>
        /// <returns></returns>
        public bool Login(string id,string pw)
        {
            sql = "select * from Users where UserID=@id and Password=@pw";
            sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id",id);
            sqlParameters[1] = new SqlParameter("@pw",pw);
            try//监视这段代码，捕获异常
            {
                DataRow dataRow = DBUtil.ExecuteSelectDataTable(sql, sqlParameters).Rows[0];//获取数据表中第一行
                new UserInfo(dataRow);//将用户信息装载到UserInfo类，用于系统后续使用用户信息的界面，如果没有会抛出异常
                return true;
            }
            catch//如果发生异常，就在此处处理
            {
                return false;
            }
        }
        /// <summary>
        /// 用回找回密码信息匹配，匹配成功返回true，匹配失败返回false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email_phone"></param>
        /// <returns></returns>
        public bool RetrievePassword (string id,string name, string email_phone)
        {
            sql = "select * from Users where UserID=@id and Name=@name and (Phone=@key or Email=@key)";
            sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@id", id);
            sqlParameters[1] = new SqlParameter("@name", name);
            sqlParameters[2] = new SqlParameter("@key", email_phone);
            try//监视这段代码，捕获异常
            {
                DataRow dataRow = DBUtil.ExecuteSelectDataTable(sql, sqlParameters).Rows[0];//获取数据表中第一行，如果没有会抛出异常
                new UserInfo(dataRow);//将用户信息装载到UserInfo类，用于找回密码下一步的修改密码,检查用户的新密码是否是旧密码
                return true;
            }
            catch//如果发生异常，就在此处处理
            {
                return false;
            }
        }
    }
}