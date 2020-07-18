using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentApplication
{
    /// <summary>
    /// DB数据库工具类
    /// </summary>
    class DBUtil
    {

        /// <summary>
        /// 创建并打开一个数据连接
        /// </summary>
        /// <returns></returns>
        private static SqlConnection CreateConn()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.StudentProjectsConnectionString);//建立与数据集的连接
            conn.Open();//打开连接
            return conn;
        }

        /// <summary>
        /// 执行标准的sql增、删、改语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, null);
        }

        /// <summary>
        /// 执行参数化sql增、删、改语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] ps)
        {
            SqlConnection conn = CreateConn();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行标准sql查询语句，返回查询到的数据行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExecuteSelect(string sql)
        {
            return ExecuteSelect(sql, null);
        }

        /// <summary>
        /// 执行参数化sql查询语句，返回查询到的数据行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExecuteSelect(string sql, SqlParameter[] ps)
        {
            SqlConnection conn = CreateConn();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            try
            {
                if (ps != null)
                {
                    da.SelectCommand.Parameters.AddRange(ps);
                }
                DataSet ds = new DataSet();//初始化数据集对象
                da.Fill(ds);//执行语句
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行标准sql语句,返回一个结果表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecuteSelectDataTable(string sql)
        {
            return ExecuteSelectDataTable(sql, null);
        }

        /// <summary>
        /// 执行参数化sql语句,返回一个结果表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable ExecuteSelectDataTable(string sql, SqlParameter[] ps = null)
        {

            SqlConnection conn = CreateConn();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(read);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);
                return table;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>decimal
        public static DataTable ExecuteSelectPageDataTable(string sql, ref SqlParameter[] ps)
        {
            SqlConnection conn = CreateConn();
            SqlCommand cmd = new SqlCommand(sql, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                cmd.Parameters.AddRange(ps);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //public static SqlDataReader ExecuteReader(string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    SqlConnection conn = CreateConn();

        //    try
        //    {
        //        ProCommand(cmd, conn, cmdText, cmdType, cmdParms);
        //        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //        //cmd.Parameters.Clear();//放到这里，返回参数会被清空。
        //        return rdr;
        //    }
        //    catch
        //    {
        //        conn.Close();
        //        throw;
        //    }
        //}

        /// <summary>   
        /// 分页读取数据   
        /// </summary>   
        /// <param name="sql">select查询语句</param>   
        /// <param name="pageSize">每页显示数据数</param>   
        /// <param name="PageIndex">当前页码</param>   
        /// <param name="dt">存储数据的DataTable实例</param>   
        public static void PageDataTable(string sql, int pageSize, int PageIndex, DataTable dt)
        {
            //读取数据的开始索引   
            long startIndex = (PageIndex - 1) * pageSize;
            //读取数据的结束索引   
            long endIndex = PageIndex * pageSize - 1;
            //DataReader读取的当前数据行的索引   
            long readToIndex = -1;
            using (SqlConnection conn = CreateConn())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                //conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //数据源中的列数   
                int cols = dr.VisibleFieldCount;
                //构造DataTable结构   
                for (int i = 0; i < cols; i++)
                {
                    dt.Columns.Add(new DataColumn(dr.GetName(i), dr.GetFieldType(i)));
                }
                //读取数据，将数据一行一行添加到DataTable   
                while (dr.Read())
                {
                    readToIndex++;
                    //当DataReader指针在开始索引和结束索引闭区间时才读取数据构造DataRow   
                    //并添加到DataTable   
                    if (readToIndex >= startIndex && readToIndex <= endIndex)
                    {
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < cols; i++)
                        {
                            row[i] = dr[i];
                        }
                        dt.Rows.Add(row);
                    }
                }
                dr.Close();
            }
        }
    }
}
