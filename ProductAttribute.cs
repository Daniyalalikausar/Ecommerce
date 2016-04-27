namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductAttribute")]
    public partial class ProductAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductAttribute()
        {
            ProductAttributeValues = new HashSet<ProductAttributeValue>();
        }

        public int ProductAttributeId { get; set; }

        public int? ProductId { get; set; }

        public int? ProductOptionId { get; set; }

        public byte? Required { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductOption ProductOption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    }
}
