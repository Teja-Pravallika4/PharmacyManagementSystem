using PharmacyManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Repository
{
    public interface IDrugRepository
    {
        List<Drug> GetAllDrugs();
        Drug GetDrugById(int id);
        void DeleteDrug(int id);
        void UpdateDrug(int id, Drug drug);
        string AddDrug(Drug drugs);
    }
}
