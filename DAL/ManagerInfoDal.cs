using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerInfoDal
    {
        public List<ManagerInfo> GetList(ManagerInfo mi)
        {
            List<SQLiteParameter> listP = new List<SQLiteParameter>();
 
            string sql = "SELECT *FROM managerinfo";
            if (mi!=null) {
                sql += " WHERE mname = @mname AND mpwd=@mpwd";
                listP.Add(new SQLiteParameter("@mname",mi.MName));
                listP.Add(new SQLiteParameter("@mpwd", mi.MPwd));
            }
            DataTable table = SqliteHelper.GetList(sql, listP.ToArray());
            //构造集合对象
            List<ManagerInfo> list = new List<ManagerInfo>();
            foreach (DataRow item in table.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    Mid = Convert.ToInt32(item["mid"]),
                    MName = item["mname"].ToString(),
                    MPwd = item["mpwd"].ToString(),
                    MType = Convert.ToInt32(item["mtype"]),




                });
            }
            return list;


        }
        public int Insert(ManagerInfo mi)
        {
           
            string sql = "insert into managerinfo(mname,mpwd,mtype)values(@name,@pwd,@type)";
            SQLiteParameter[] ps ={
            new SQLiteParameter("@name",mi.MName),
            new SQLiteParameter("@pwd",  Md5Helper.GetMd5(mi.MPwd)),
            new SQLiteParameter("@type",mi.MType),
                    };
            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }
        public int DeleteById(int id)
        {
            string sql = "DELETE FROM managerinfo where mid = @mid";
            SQLiteParameter p = new SQLiteParameter("@mid", id);
            return  SqliteHelper.ExecuteNonQuery(sql,p);
        }
        public int UpData(ManagerInfo mi) {
            string sql = "UPDATE managerinfo SET ";
            List<SQLiteParameter> p = new List<SQLiteParameter>();
            if (!(mi.MPwd=="*****")) {
                sql += "mpwd =@mpwd,";
                p.Add(new SQLiteParameter("@mpwd", mi.MPwd));
            }
            
           sql+= "mtype =@mtype,mname= @mname where mid =@mid";

            p.Add(new SQLiteParameter("@mtype", mi.MType));
            p.Add(new SQLiteParameter("@mname", mi.MName));
            p.Add(new SQLiteParameter("@mid", mi.Mid));
            var q = p.ToArray();
            return SqliteHelper.ExecuteNonQuery(sql,q);
        }
    }
}
