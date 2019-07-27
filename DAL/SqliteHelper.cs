using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;

namespace DAL
{
    public static class SqliteHelper
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["cater"].ConnectionString;
        public static  DataTable GetList(string sql,params SQLiteParameter[] ps) {
            //构造连接对象
            using (SQLiteConnection conn = new SQLiteConnection(connStr)) {
                //SQLiteCommand cmd = new SQLiteCommand(sql,conn);
                
                //SQLiteDataReader reader = cmd.ExecuteReader();
                //构建桥接器对象
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                //数据表对象
                adapter.SelectCommand.Parameters.AddRange(ps);
                conn.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;



            }



        }
        public static int ExecuteNonQuery(string sql,params SQLiteParameter[] ps) {
            using (SQLiteConnection conn = new SQLiteConnection(connStr)) {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();
                return cmd.ExecuteNonQuery();

            }

        }
    }
}
