using PharmacyManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Repository
{
    public interface IAdminRepository
    {
        Doctor GetDoctor(string doctorID);
    }
}
