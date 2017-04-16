using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class ImportDetail
    {
        public Guid Id { get; set; }

        public Guid ImportId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public double Quantity { get; set; }

        public int UnitId { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }
    }
}
