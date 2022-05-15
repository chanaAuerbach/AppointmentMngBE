using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppointmentMngBE.Models
{
    public partial class AppointmentsManagementContext : DbContext
    {
        public AppointmentsManagementContext()
        {
        }

        public AppointmentsManagementContext(DbContextOptions<AppointmentsManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alert> Alerts { get; set; } = null!;
        public virtual DbSet<Apointment> Apointments { get; set; } = null!;
        public virtual DbSet<Business> Businesses { get; set; } = null!;
        public virtual DbSet<BusinessConfiguration> BusinessConfigurations { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<ServiceType> ServiceTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:sqlserver-hacwhite.database.windows.net,1433;Initial Catalog=AppointmentsManagement;Persist Security Info=False;User ID=HacWhaitDBadmin;Password= H1234567!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("ALERTS");

                entity.Property(e => e.AlertId).HasColumnName("alert_id");

                entity.Property(e => e.ApointmentId).HasColumnName("apointment_id");

                entity.Property(e => e.DateOfAlert)
                    .HasColumnType("date")
                    .HasColumnName("date_of_alert");

                entity.Property(e => e.StatusAlert)
                    .HasColumnType("text")
                    .HasColumnName("status_alert");

                entity.HasOne(d => d.Apointment)
                    .WithMany(p => p.Alerts)
                    .HasForeignKey(d => d.ApointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ALERTS__apointme__7B5B524B");
            });

            modelBuilder.Entity<Apointment>(entity =>
            {
                entity.ToTable("APOINTMENTS");

                entity.Property(e => e.ApointmentId).HasColumnName("apointment_id");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.FromDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("from_datetime");

                entity.Property(e => e.Status)
                    .HasColumnType("text")
                    .HasColumnName("status");

                entity.Property(e => e.UntilDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("until_datetime");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Apointments)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APOINTMEN__busin__787EE5A0");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Apointments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APOINTMEN__custo__797309D9");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.ToTable("BUSINESS");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.ExtentionNumber).HasColumnName("extention_number");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<BusinessConfiguration>(entity =>
            {
                entity.ToTable("BUSINESS_CONFIGURATION");

                entity.Property(e => e.BusinessConfigurationId).HasColumnName("business_configuration_id");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.OpeningHoursFromtime).HasColumnName("opening_hours_fromtime");

                entity.Property(e => e.OpeningHoursUntiltime).HasColumnName("opening_hours_untiltime");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.BusinessConfigurations)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BUSINESS___busin__74AE54BC");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMERS");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.BusinessId).HasColumnName("business_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("date_of_joining");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstNane)
                    .HasColumnType("text")
                    .HasColumnName("first_nane");

                entity.Property(e => e.LastName)
                    .HasColumnType("text")
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .HasColumnName("remark");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(50)
                    .HasColumnName("token_id");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMERS__busin__778AC167");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_SERVICEֹ_TYPE_service_id");

                entity.ToTable("SERVICEֹ_TYPE");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.Discription)
                    .HasColumnType("text")
                    .HasColumnName("discription");

                entity.Property(e => e.DurationInMinutes).HasColumnName("duration_in_minutes");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
