using EShop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Services.Interface
{
    public interface IOrderService
    {
        public List<Order> getAllOrders();
        public Order getOrderDetails(BaseEntity model);
    }
}
