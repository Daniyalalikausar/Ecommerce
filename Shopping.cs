namespace FypStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Shopping : DbContext
    {
        public Shopping()
            : base("name=Shopping")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductOption> ProductOptions { get; set; }
        public virtual DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<SubSubCategory> SubSubCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VoteLog> VoteLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.CartId)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.BillingCity)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.BillingState)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.BillingCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Colors)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Votes)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductAttributeValue>()
                .Property(e => e.Weight)
                .HasPrecision(15, 8);

            modelBuilder.Entity<ProductOptionValue>()
                .HasMany(e => e.ProductAttributeValues)
                .WithOptional(e => e.ProductOptionValue)
                .HasForeignKey(e => e.ProductOptionId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.SubCatName)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.SubCategory)
                .HasForeignKey(e => e.SubCategoryId);

            modelBuilder.Entity<SubSubCategory>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.SubSubCategory)
                .HasForeignKey(e => e.SubSubCategoryId);

            modelBuilder.Entity<User>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.IsApproved)
                .IsUnicode(false);

            modelBuilder.Entity<VoteLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}
