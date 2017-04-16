namespace BusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public string ProductName { get; set; }

        public int ProductId { get; set; }

        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        public double Quantity { get; set; }

        public string UnitName { get; set; }

        public int UnitId { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }
    }
}
