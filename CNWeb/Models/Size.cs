namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Size")]
    public partial class Size
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? product_id { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public virtual Product Product { get; set; }
    }
}
