using PharmacyManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Repository
{
    public interface ISupplierRepository
    {
        List<Supplier> ShowAllSuppliers();
        string AddSupplier(Supplier supplier);
        string UpdateSupplier(int supplierId, Supplier supplier);
        Supplier GetSupplier(int supplierId);
        Supplier DeleteSupplier(int supplierId);

    }
}
