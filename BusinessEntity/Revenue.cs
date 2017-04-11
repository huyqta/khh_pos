using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class Revenue
    {
        public Guid Id { get; set; }

        public DateTime RevenueDateTime { get; set; }

        public double RevenueValue { get; set; }
    }
}
