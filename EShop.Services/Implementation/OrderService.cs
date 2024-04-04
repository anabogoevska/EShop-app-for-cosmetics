using EShop.Domain;
using EShop.Domain.DomainModels;
using EShop.Repository.Implementation;

using EShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using EShop.Repository.Interface;

namespace EShop.Services
{
    public class OrderService : IOrderService
{
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
