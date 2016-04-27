namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        [StringLength(50)]
        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public int? ShippingCharges { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public decimal? Total { get; set; }

        public int StoreId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }
    }
}
