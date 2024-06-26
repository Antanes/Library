﻿using LinqSpecs;
using Microsoft.EntityFrameworkCore;
using OrderingService.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingService.Domain.Aggregates.OrderAggregate
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order Add(Order order);
        void Update(Order order);
        Task<Order> GetAsync(Guid orderId);
        Task<IEnumerable<Order>> ListAllAsync();
        Task<IEnumerable<Order>> ListAll(Specification<Order> spec);
        
    }
}
