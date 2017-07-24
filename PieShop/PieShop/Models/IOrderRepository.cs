using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
