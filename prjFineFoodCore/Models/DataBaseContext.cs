using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace prjFineFoodCore.Models
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PocketList> PocketLists { get; set; }
        public virtual DbSet<PocketListAction> PocketListActions { get; set; }
        public virtual DbSet<PocketListDetail> PocketListDetails { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantSubtype> RestaurantSubtypes { get; set; }
        public virtual DbSet<RestaurantType> RestaurantTypes { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TypeReference> TypeReferences { get; set; }
        public virtual DbSet<Viplevel> Viplevels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DataBase;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("ActionType");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.Property(e => e.BannerName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BannerPhoto)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Banners)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banners_Restaurant");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("City");

                entity.Property(e => e.CityPhoto).HasMaxLength(300);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Context).IsRequired();

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Members");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Post");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.DiscountDescription).HasMaxLength(40);

                entity.Property(e => e.InvalidDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Photo).HasMaxLength(300);

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.ValidDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_Restaurant");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Photo).HasMaxLength(300);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foods_Restaurant");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.MemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemberID");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MemberPhoto).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ViplevelId).HasColumnName("VIPLevelID");

                entity.HasOne(d => d.Viplevel)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.ViplevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Members_VIPLevels");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_Orders_Coupons");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Members");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderStatus");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Payments");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Restaurant");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Foods");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Orders");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.OrderStatus1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("OrderStatus");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PocketList>(entity =>
            {
                entity.Property(e => e.PocketListId).HasColumnName("PocketListID");

                entity.Property(e => e.IsPublic).HasColumnName("isPublic");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PocketListName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.PocketLists)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketLists_Members");
            });

            modelBuilder.Entity<PocketListAction>(entity =>
            {
                entity.HasKey(e => e.ActionRecordId);

                entity.Property(e => e.ActionRecordId).HasColumnName("ActionRecordID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PocketListId).HasColumnName("PocketListID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.PocketListActions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketListActions_ActionType");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.PocketListActions)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketListActions_Members");

                entity.HasOne(d => d.PocketList)
                    .WithMany(p => p.PocketListActions)
                    .HasForeignKey(d => d.PocketListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketListActions_PocketLists");
            });

            modelBuilder.Entity<PocketListDetail>(entity =>
            {
                entity.ToTable("PocketListDetail");

                entity.Property(e => e.PocketListDetailId).HasColumnName("PocketListDetailID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.PocketListId).HasColumnName("PocketListID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.PocketListDetails)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_PocketListDetail_Cities");

                entity.HasOne(d => d.PocketList)
                    .WithMany(p => p.PocketListDetails)
                    .HasForeignKey(d => d.PocketListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketListDetail_PocketLists");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.PocketListDetails)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PocketListDetail_Restaurant");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Photos).HasMaxLength(300);

                entity.Property(e => e.PostContent).IsRequired();

                entity.Property(e => e.PostDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_Members");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_Restaurant");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_Region");

                entity.Property(e => e.ZipCode).ValueGeneratedNever();

                entity.Property(e => e.AdminDisct)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions_Cities");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CloseTime).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.OpenTime).HasMaxLength(40);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.Photos).HasMaxLength(300);

                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RestaurantAccount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RestaurantName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.WeekDayOff).HasMaxLength(40);

                entity.HasOne(d => d.ZipCodeNavigation)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.ZipCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Restaurant_Regions");
            });

            modelBuilder.Entity<RestaurantSubtype>(entity =>
            {
                entity.Property(e => e.RestaurantSubtypeId).HasColumnName("RestaurantSubtypeID");

                entity.Property(e => e.RestaurantSubtype1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("RestaurantSubtype");

                entity.Property(e => e.RestaurantTypeId).HasColumnName("RestaurantTypeID");

                entity.HasOne(d => d.RestaurantType)
                    .WithMany(p => p.RestaurantSubtypes)
                    .HasForeignKey(d => d.RestaurantTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RestaurantSubtypes_RestaurantTypes");
            });

            modelBuilder.Entity<RestaurantType>(entity =>
            {
                entity.Property(e => e.RestaurantTypeId).HasColumnName("RestaurantTypeID");

                entity.Property(e => e.Types)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.FoodId).HasColumnName("FoodID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.ShoppingCarts)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCarts_Foods");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.ShoppingCarts)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCarts_Members");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.ShoppingCarts)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCarts_Restaurant");
            });

            modelBuilder.Entity<TypeReference>(entity =>
            {
                entity.HasKey(e => e.ReferenceId);

                entity.ToTable("TypeReference");

                entity.Property(e => e.ReferenceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReferenceID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.RestaurantSubtypeId).HasColumnName("RestaurantSubtypeID");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.TypeReferences)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeReference_Restaurant");

                entity.HasOne(d => d.RestaurantSubtype)
                    .WithMany(p => p.TypeReferences)
                    .HasForeignKey(d => d.RestaurantSubtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeReference_RestaurantSubtypes");
            });

            modelBuilder.Entity<Viplevel>(entity =>
            {
                entity.ToTable("VIPLevels");

                entity.Property(e => e.ViplevelId).HasColumnName("VIPLevelID");

                entity.Property(e => e.Viplevel1).HasColumnName("VIPLevel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
