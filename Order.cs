namespace FypStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [StringLength(160)]
        public string FirstName { get; set; }

        [StringLength(160)]
        public string LastName { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(40)]
        public string State { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(160)]
        public string Email { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderStatus { get; set; }

        public int Code { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        public int StoreId { get; set; }

        [StringLength(50)]
        public string BillingFirstName { get; set; }

        [StringLength(100)]
        public string BillingAddress { get; set; }

        [StringLength(50)]
        public string BillingCity { get; set; }

        [StringLength(50)]
        public string BillingState { get; set; }

        [StringLength(50)]
        public string BillingCountry { get; set; }

        [StringLength(10)]
        public string BillingPostalCode { get; set; }

        [StringLength(50)]
        public string BillingContactNumber { get; set; }

        [StringLength(50)]
        public string BillingLastName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Store Store { get; set; }

        public virtual User User { get; set; }
    }
}
