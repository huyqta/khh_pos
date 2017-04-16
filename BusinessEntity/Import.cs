using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public partial class Import
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Import()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }

        public Guid Id { get; set; }

        public string ImportCode { get; set; }

        public DateTime ImportDateTime { get; set; }

        public string Description { get; set; }

        public double TotalPrice { get; set; }

        public int VendorId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
