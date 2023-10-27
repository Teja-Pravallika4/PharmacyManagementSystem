using PharmacyManagement.Model;
using PharmacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Services
{
    public class AdminService
    {

        private readonly AdminDAL _admin;
        public AdminService(AdminDAL admin)
        {
            _admin = admin;
        }

        public Doctor GetDoctor(String doctorID)
        {
            var item = _admin.GetDoctor(doctorID);
            return item;
        }
    }
}
