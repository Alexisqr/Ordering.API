using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Commands.CheckoutOrder
{
    public class CheckoutOrderCommand : IRequest<int>
    {
        public string OrderName { get; set; } = default!;
        public int IDBook { get; set; }
        public int IDDiscount { get; set; }
    }
}
