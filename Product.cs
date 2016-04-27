namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Carts = new HashSet<Cart>();
            ProductAttributes = new HashSet<ProductAttribute>();
            ProductAttributeValues = new HashSet<ProductAttributeValue>();
            VoteLogs = new HashSet<VoteLog>();
        }
        [Key]

        public int ProductId { get; set; }

        public int? CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public int? SubSubCategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        public DateTime? Submitted { get; set; }

        public int? StoreId { get; set; }

        [StringLength(50)]
        public string DeliveryDate { get; set; }

        [StringLength(50)]
        public string ShippingCharges { get; set; }

        public int? ProvinceId { get; set; }

        public int? CityId { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        [StringLength(50)]
        public string Colors { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string PaypalEmail { get; set; }

        [StringLength(50)]
        public string Votes { get; set; }

        public long? PageViews { get; set; }

        [StringLength(50)]
        public string Condition { get; set; }

        [StringLength(100)]
        public string ImagePath2 { get; set; }

        [StringLength(100)]
        public string ImagePath3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual Category Category { get; set; }

        public virtual City City { get; set; }

        public virtual Province Province { get; set; }

        public virtual Store Store { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual SubSubCategory SubSubCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoteLog> VoteLogs { get; set; }
    }
}
