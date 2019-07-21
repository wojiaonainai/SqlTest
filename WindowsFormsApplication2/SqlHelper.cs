/*
 描述：操作数据库功能类及函数
 作者：XXXX
 创建时间：XXXX-XX-XX
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WindowsFormsApplication2
{
   public class SqlHelper
    {

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>查询集合</returns>
        public static DataSet QuerybySql(string sql)
        {
            string ConnStr =ConfigurationSettings.AppSettings["ConnStr"].ToString();
            SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();

            SqlDataAdapter Adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);

            conn.Close();
            return ds;
        }
        

        /// <summary>
        /// 执行添加、修改、删除sql语句
        /// </summary>
        /// <param name="sql">增删改sql语句</param>
        /// <returns>影响的行数</returns>
        public static int ExecuteSql(string sql) {
            string ConnStr = ConfigurationSettings.AppSettings["ConnStr"].ToString(); SqlConnection conn = new SqlConnection(ConnStr);
            conn.Open();

            SqlCommand comm = new SqlCommand(sql, conn);
            int iRet=comm.ExecuteNonQuery();

            conn.Close();

            return iRet;
        }
    }
}