namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductAttributeValue")]
    public partial class ProductAttributeValue
    {
        public int ProductAttributeValueId { get; set; }

        public int? ProductAttributeId { get; set; }

        public int? ProductId { get; set; }

        public int? ProductOptionId { get; set; }

        public int? ProductOptionValueId { get; set; }

        public int Quantity { get; set; }

        public decimal? Weight { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }

        public virtual ProductOption ProductOption { get; set; }

        public virtual ProductOptionValue ProductOptionValue { get; set; }
    }
}
