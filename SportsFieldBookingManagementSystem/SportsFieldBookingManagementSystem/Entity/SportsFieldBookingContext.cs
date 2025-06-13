using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Entity;

public partial class SportsFieldBookingContext : DbContext
{
    public SportsFieldBookingContext()
    {
    }

    public SportsFieldBookingContext(DbContextOptions<SportsFieldBookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Field> Fields { get; set; }

    public virtual DbSet<FieldType> FieldTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    public string GetConnectionString()
    {
        string connectionString = null;
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        connectionString = config["ConnectionString:DefaultConnection"];
        return connectionString;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Booking__73951ACD1B2E8A44");

            entity.ToTable("Booking");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.BookingStatus).HasMaxLength(10);
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.TotalMoney).HasColumnType("money");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Field).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.FieldId)
                .HasConstraintName("FK_FieldID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.TransactionId)
                .HasConstraintName("FK_TransactionID");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserID");
        });

        modelBuilder.Entity<Field>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PK__Field__C8B6FF27528680C8");

            entity.ToTable("Field");

            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.FieldAddress).HasMaxLength(50);
            entity.Property(e => e.FieldName).HasMaxLength(50);
            entity.Property(e => e.FieldPrice).HasColumnType("money");
            entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");

            entity.HasOne(d => d.FieldType).WithMany(p => p.Fields)
                .HasForeignKey(d => d.FieldTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FieldTypeID");
        });

        modelBuilder.Entity<FieldType>(entity =>
        {
            entity.HasKey(e => e.FieldTypeId).HasName("PK__FieldTyp__74418A826BA2B3A7");

            entity.ToTable("FieldType");

            entity.Property(e => e.FieldTypeId).HasColumnName("FieldTypeID");
            entity.Property(e => e.FieldTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A51D870E1");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(20);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A4BB9C4DABC");

            entity.ToTable("Transaction");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionAmmount).HasColumnType("money");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionMethod).HasMaxLength(20);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCAC08C42FAD");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(10);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
