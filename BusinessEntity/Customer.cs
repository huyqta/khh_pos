using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surrogate { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Telephone { get; set; }

        public string TaxNumber { get; set; }

        public string FaxNumber { get; set; }

        public bool isCompany { get; set; }

        public string Description { get; set; }
    }
}
