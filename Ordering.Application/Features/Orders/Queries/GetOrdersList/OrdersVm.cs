using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Queries.GetOrdersList
{
    public class OrdersVm
    {
        public int IDOrder { get; set; }
        public string OrderName { get; set; } = default!;
        public int IDBook { get; set; }
        public int IDDiscount { get; set; }
    }
}
