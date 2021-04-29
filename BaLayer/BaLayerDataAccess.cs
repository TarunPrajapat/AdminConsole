using BoLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaLayer
{
    public class BaLayerDataAccess
    {
        DaLayer.AdminDataAccess  data = new DaLayer.AdminDataAccess();

        public List<AdminModel> GetAdmins()
        {
            return data.GetData();
        }

        public AdminModel GetAdminById(int? id)
        {
            AdminModel admin = null;
            if (id != null)
            {
                admin = data.GetDataById(id);
            }
            return admin;
        }

        public string InsertAdmin(AdminModel admin)
        {
            if (admin != null)
            {
                data.InsertData(admin);
            }
            return "Data Inserted Successfully";
        }
        public string RemoveAdmin(AdminModel admin)
        {

                data.RemoveData(admin);
            return "Data Removed Successfully";
        }

    }
}
