namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            Users = new HashSet<User>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? blog_id { get; set; }

        public int? product_id { get; set; }

        public int? about_id { get; set; }

        [StringLength(50)]
        public string file { get; set; }

        public virtual Abuot Abuot { get; set; }

        public virtual Blog Blog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        public virtual Product Product { get; set; }
    }
}
