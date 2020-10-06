namespace CNWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Data")
        {
        }

        public virtual DbSet<Abuot> Abuots { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Cart_detail> Cart_detail { get; set; }
        public virtual DbSet<Category_type> Category_type { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<detailPayment> detailPayments { get; set; }
        public virtual DbSet<formPayment> formPayments { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_category> Product_category { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abuot>()
                .HasMany(e => e.Photos)
                .WithOptional(e => e.Abuot)
                .HasForeignKey(e => e.about_id);

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Photos)
                .WithOptional(e => e.Blog)
                .HasForeignKey(e => e.blog_id);

            modelBuilder.Entity<Cart>()
                .HasMany(e => e.Cart_detail)
                .WithOptional(e => e.Cart)
                .HasForeignKey(e => e.cart_id);

            modelBuilder.Entity<Category_type>()
                .HasMany(e => e.Product_category)
                .WithOptional(e => e.Category_type)
                .HasForeignKey(e => e.category_type_id);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.Replies)
                .WithOptional(e => e.Comment)
                .HasForeignKey(e => e.comment_id);

            modelBuilder.Entity<formPayment>()
                .HasMany(e => e.detailPayments)
                .WithOptional(e => e.formPayment)
                .HasForeignKey(e => e.id_form);

            modelBuilder.Entity<Photo>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Photo)
                .HasForeignKey(e => e.photo_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Cart_detail)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Colors)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.detailPayments)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.id_product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Photos)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sizes)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<Product_category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Product_category)
                .HasForeignKey(e => e.product_category_id);

            modelBuilder.Entity<Role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.passwork)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Abuots)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Blogs)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Carts)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.formPayments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Roles)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.user_id);
        }
    }
}
