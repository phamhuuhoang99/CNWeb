namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formPayment")]
    public partial class formPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public formPayment()
        {
            detailPayments = new HashSet<detailPayment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? user_id { get; set; }

        public int? total { get; set; }

        public int? moneya_ship { get; set; }

        public int? shipper_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? update_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailPayment> detailPayments { get; set; }

        public virtual User User { get; set; }
    }
}
