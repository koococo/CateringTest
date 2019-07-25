using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class ManagerInfoBLL
    {
        ManagerInfoDal Managerinfodal = new ManagerInfoDal();
        public List<ManagerInfo> GetList() {

          return  Managerinfodal.GetList();

        }
        public bool Add(ManagerInfo InsertData) {
          return  Managerinfodal.Insert(InsertData)>0;



        }
        public bool Remove(int id) {
            return Managerinfodal.DeleteById(id) > 0;

        }
        public bool Modifier(ManagerInfo mi) {
            return Managerinfodal.UpData(mi) > 0;
        }


    }
}
