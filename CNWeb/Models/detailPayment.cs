namespace CNWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("detailPayment")]
    public partial class detailPayment
    {
        [Key]
        [Column("id_formPayment , id_Product")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_formPayment___id_Product { get; set; }

        public int? id_form { get; set; }

        public int? id_product { get; set; }

        public virtual formPayment formPayment { get; set; }

        public virtual Product Product { get; set; }
    }
}
