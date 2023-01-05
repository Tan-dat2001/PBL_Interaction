
using Microsoft.EntityFrameworkCore;

namespace PBL_Interaction.Entities
{
    public class DataContext : DbContext
    {   
        //DBset đại diện cho các data table
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure relationships between data tables.
            //BOOK
            modelBuilder.Entity<Book>()
                .HasOne<Category>(c => c.Category)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.CategoryId);
            modelBuilder.Entity<Book>()
                .HasOne<State>(s => s.State)
                .WithOne(b => b.Book)
                .HasForeignKey<Book>(b => b.StateId);

            //ORDER
            modelBuilder.Entity<Order>()
                .HasOne<Payment>(p => p.Payment)
                .WithOne(o => o.Order)
                .HasForeignKey<Order>(o => o.PaymentId);
            modelBuilder.Entity<Order>()
                .HasOne<User>(u => u.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.UserId);

            //ORDER DETAILS]
            modelBuilder.Entity<OrderDetail>().HasKey(x => new { x.BookId, x.OrderId});
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Book>(b => b.Book)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(od => od.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>(o => o.Order)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        

            //SHIPPER
            modelBuilder.Entity<Shipper>()
                .HasOne<User>(u => u.User)
                .WithOne(s => s.Shipper)
                .HasForeignKey<Shipper>(s => s.UserId);

            //USER
            modelBuilder.Entity<User>()
                .HasOne<Role>(r => r.Role)
                .WithOne(u => u.User)
                .HasForeignKey<User>(u => u.RoleId);
            modelBuilder.Entity<User>()
                .HasOne<State>(r => r.State)
                .WithOne(u => u.User)
                .HasForeignKey<User>(u => u.StateId);


            base.OnModelCreating(modelBuilder);
        }

    }
}