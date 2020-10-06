namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abuot")]
    public partial class Abuot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Abuot()
        {
            Photos = new HashSet<Photo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string content { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? update_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }

        public virtual User User { get; set; }
    }
}
