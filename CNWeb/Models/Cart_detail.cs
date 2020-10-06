namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cart_detail
    {
        [Key]
        [Column("cart_id , product_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cart_id___product_id { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public int? quantity { get; set; }

        public int? price { get; set; }

        public DateTime? create_at { get; set; }

        public int? cart_id { get; set; }

        public int? product_id { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}
