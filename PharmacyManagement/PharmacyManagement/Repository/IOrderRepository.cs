using PharmacyManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagement.Repository
{
    public interface IOrderRepository
    {

        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void DeleteOrder(int id);
        void UpdateOrder(int id, Order drug);
        string AddOrder(Order drugs);
    }
}
