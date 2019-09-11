using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CalendarEvent.Models
{
    public partial class Cal_DBContext : DbContext
    {
        public Cal_DBContext()
        {
        }

        public Cal_DBContext(DbContextOptions<Cal_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCalevent> TblCalevent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("ConnectionStrings");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TblCalevent>(entity =>
            {
                entity.ToTable("tbl_calevent");

                entity.Property(e => e.EndsAt).HasColumnType("datetime");

                entity.Property(e => e.StatsAt).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);
            });
        }
    }
}
