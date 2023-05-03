using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FrontDesk.Models;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=602112db.postgres.database.azure.com;Database=postgres;Username=myadmin;Password=AdminLover69");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("pg_catalog", "azure")
            .HasPostgresExtension("pg_catalog", "pgaadauth")
            .HasPostgresExtension("pg_cron");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("customer_pk");

            entity.ToTable("customer", "dat154");

            entity.HasIndex(e => e.Email, "customer_email_key").IsUnique();

            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reservation_pk");

            entity.ToTable("reservation", "dat154");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Roomnumber).HasColumnName("roomnumber");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");

            entity.HasOne(d => d.RoomnumberNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Roomnumber)
                .HasConstraintName("room_fk");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("username_fk");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Roomnumber).HasName("room_pk");

            entity.ToTable("room", "dat154");

            entity.Property(e => e.Roomnumber).HasColumnName("roomnumber");
            entity.Property(e => e.Numberofbeds).HasColumnName("numberofbeds");
            entity.Property(e => e.Reserved).HasColumnName("reserved");
            entity.Property(e => e.Roomtype)
                .HasMaxLength(255)
                .HasColumnName("roomtype");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tasks_pk");

            entity.ToTable("tasks", "dat154");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Roomnumber).HasColumnName("roomnumber");
            entity.Property(e => e.Task1)
                .HasMaxLength(255)
                .HasColumnName("task");

            entity.HasOne(d => d.RoomnumberNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.Roomnumber)
                .HasConstraintName("roomnumber_fk");
        });
        modelBuilder.HasSequence("jobid_seq", "cron");
        modelBuilder.HasSequence("runid_seq", "cron");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
