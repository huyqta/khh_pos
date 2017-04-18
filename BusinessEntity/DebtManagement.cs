using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class DebtManagement
    {
        public Guid Id { get; set; }
        /// <summary>
        /// CustomerId or VendorId
        /// </summary>
        public int PartnerId { get; set; }
        /// <summary>
        /// OrderId or ImportId
        /// </summary>
        public Guid ReceiptId { get; set; }
        public double DebtAmount { get; set; }
        public bool isDone { get; set; }
    }
}
