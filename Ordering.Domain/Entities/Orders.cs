using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Entities
{
    public class Orders 
    {
        [Key]
        public int IDOrder { get; set; }
        public string OrderName { get; set; } = default!;
        public int IDBook { get; set; }
        public int IDDiscount { get; set; }
    }
}
