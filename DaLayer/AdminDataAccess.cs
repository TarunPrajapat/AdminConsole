using BoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaLayer
{
    public class AdminDataAccess
    {
        RegisterContext db = new RegisterContext();


        public List<AdminModel> GetData()
        {
            return db.AdminModels.ToList();
        }

        public AdminModel GetDataById(int? id)
        {
            AdminModel admin = null;
            if (id != null)
            {
                admin = db.AdminModels.Find(id);
            }
            return admin;
        }

        public void InsertData(AdminModel admin)
        {
            if (admin != null)
            {
                db.AdminModels.Add(admin);
                db.SaveChanges();
            }

        }

        public void RemoveData(AdminModel admin)
        {
            db.AdminModels.Remove(admin);
            db.SaveChanges();
        }
    }
}
