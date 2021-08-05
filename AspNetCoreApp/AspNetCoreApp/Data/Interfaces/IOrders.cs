using AspNetCoreApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Data.Interfaces
{
    public interface IOrders
    {
        void CreateOrder(Order order);
    }
}
