namespace BusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        //public virtual Category Category { get; set; }

        public string ImageUrl { get; set; }

        public double DefaultPrice { get; set; }

        public string Description { get; set; }

        public int UnitId { get; set; }

        public byte[] ImageBinary { get; set; }

        public bool isCheckInventory { get; set; }
    }
}
