namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Abuots = new HashSet<Abuot>();
            Blogs = new HashSet<Blog>();
            Carts = new HashSet<Cart>();
            formPayments = new HashSet<formPayment>();
            Roles = new HashSet<Role>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? is_active { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? photo_id { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(10)]
        public string passwork { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? update_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abuot> Abuots { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formPayment> formPayments { get; set; }

        public virtual Photo Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
