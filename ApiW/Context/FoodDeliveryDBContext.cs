using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiW.Models
{
    public partial class FoodDeliveryDBContext : DbContext
    {
        public FoodDeliveryDBContext()
        {
        }

        public FoodDeliveryDBContext(DbContextOptions<FoodDeliveryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Doljnost> Doljnosts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderList> OrderLists { get; set; }
        public virtual DbSet<OtdelKadrov> OtdelKadrovs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<TechHelper> TechHelpers { get; set; }
        public virtual DbSet<TypeOfDeliver> TypeOfDelivers { get; set; }
        public virtual DbSet<TypeOfPaying> TypeOfPayings { get; set; }
        public virtual DbSet<VidachaZp> VidachaZps { get; set; }
        public virtual DbSet<VidachaZpHistory> VidachaZpHistories { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Database=FoodDeliveryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("Client");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Firdname).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doljnost>(entity =>
            {
                entity.HasKey(e => e.IdDoljnost);

                entity.ToTable("Doljnost");

                entity.HasIndex(e => e.Name, "UQ_Doljnost_Name")
                    .IsUnique();

                entity.Property(e => e.IdDoljnost).HasColumnName("ID_Doljnost");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Order");

                entity.Property(e => e.IdOrder).HasColumnName("ID_Order");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.IdOrderList).HasColumnName("ID_OrderList");

                entity.Property(e => e.IdRestaurant).HasColumnName("ID_Restaurant");

                entity.Property(e => e.IdStaff).HasColumnName("ID_Staff");

                entity.Property(e => e.IdTypeOfPay).HasColumnName("ID_TypeOfPay");

                entity.Property(e => e.IdTypeofDeliver).HasColumnName("ID_TypeofDeliver");

                entity.Property(e => e.OrderCost)
                    .HasColumnType("money")
                    .HasColumnName("Order_cost");

                
            });

            modelBuilder.Entity<OrderList>(entity =>
            {
                entity.HasKey(e => e.IdOrderList);

                entity.ToTable("Order_List");

                entity.Property(e => e.IdOrderList).HasColumnName("ID_OrderList");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

               
            });

            modelBuilder.Entity<OtdelKadrov>(entity =>
            {
                entity.HasKey(e => e.IdPerson);

                entity.ToTable("Otdel_Kadrov");

                entity.HasIndex(e => e.Inn, "UQ_Otdel_Kadrov_INN")
                    .IsUnique();

                entity.HasIndex(e => e.Snils, "UQ_Otdel_Kadrov_Snils")
                    .IsUnique();

                entity.Property(e => e.IdPerson).HasColumnName("ID_Person");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FirdName).IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdDoljnost).HasColumnName("ID_Doljnost");

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NumberPas).HasColumnName("Number_Pas");

                entity.Property(e => e.SeriaPas).HasColumnName("Seria_Pas");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .IsUnicode(false);

               
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.ToTable("Product");

                entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.HasKey(e => e.IdRestaurant);

                entity.ToTable("Restaurant");

                entity.Property(e => e.IdRestaurant).HasColumnName("ID_Restaurant");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechHelper>(entity =>
            {
                entity.HasKey(e => e.IdTecHelp);

                entity.ToTable("Tech_helper");

                entity.Property(e => e.IdTecHelp).HasColumnName("ID_TecHelp");

                entity.Property(e => e.IdClient).HasColumnName("ID_Client");

                entity.Property(e => e.IdStaff).HasColumnName("ID_Staff");

                entity.Property(e => e.Request)
                    .IsRequired()
                    .IsUnicode(false);

                
            });

            modelBuilder.Entity<TypeOfDeliver>(entity =>
            {
                entity.HasKey(e => e.IdTypeofDeliver);

                entity.ToTable("Type_of_Deliver");

                entity.Property(e => e.IdTypeofDeliver).HasColumnName("ID_TypeofDeliver");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeOfPaying>(entity =>
            {
                entity.HasKey(e => e.IdTypeOfPay);

                entity.ToTable("Type_of_Paying");

                entity.Property(e => e.IdTypeOfPay).HasColumnName("ID_TypeOfPay");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VidachaZp>(entity =>
            {
                entity.HasKey(e => e.IdDoc);

                entity.ToTable("VidachaZP");

                entity.Property(e => e.IdDoc).HasColumnName("ID_Doc");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdPerson).HasColumnName("ID_Person");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .IsUnicode(false);

                
            });

            modelBuilder.Entity<VidachaZpHistory>(entity =>
            {
                entity.HasKey(e => e.DocId)
                    .HasName("PK_Check_history");

                entity.ToTable("VidachaZP_history");

                entity.Property(e => e.DocId)
                    .ValueGeneratedNever()
                    .HasColumnName("Doc_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.IdStaff);

                entity.ToTable("Staff");

                entity.Property(e => e.IdStaff).HasColumnName("ID_Staff");

                entity.Property(e => e.Firdname).IsUnicode(false);

                entity.Property(e => e.IdDoljnost).HasColumnName("ID_Doljnost");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .IsUnicode(false);

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
