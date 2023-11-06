﻿
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence;

public interface IOrderRepository : IAsyncRepository<Orders>
{
    Task<IEnumerable<Orders>> GetOrdersByOrderName(string orderName);
}