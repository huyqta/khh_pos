using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class SaleStatistic
    {
        public Guid Id { get; set; }

        public string OrderCode { get; set; }

        public Guid OrderDetailId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int UnitId { get; set; }

        public string UnitName { get; set; }

        public int Quanlity { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }

        public double Revenue { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
    }
}
