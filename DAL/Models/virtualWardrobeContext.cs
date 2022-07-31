using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class virtualWardrobeContext : DbContext
    {
        public virtualWardrobeContext()
        {
        }

        public virtualWardrobeContext(DbContextOptions<virtualWardrobeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Closet> Closet { get; set; }
        public virtual DbSet<Clothing> Clothing { get; set; }
        public virtual DbSet<ClothingTypes> ClothingTypes { get; set; }
        public virtual DbSet<Matching> Matching { get; set; }
        public virtual DbSet<MatchingDeatails> MatchingDeatails { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<Sets> Sets { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }
        public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Using> Using { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SV7G2KC\\MSSQLSERVER02;Database=virtualWardrobe;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatName)
                    .HasColumnName("catName")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Closet>(entity =>
            {
                entity.ToTable("closet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClosetDesc)
                    .HasColumnName("closetDesc")
                    .IsUnicode(false);

                entity.Property(e => e.ClosetNane)
                    .HasColumnName("closet_nane")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clothing>(entity =>
            {
                entity.ToTable("clothing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ClothingName)
                    .HasColumnName("clothing_name")
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .IsUnicode(false);

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.SetId).HasColumnName("setId");

                entity.Property(e => e.ShelfId).HasColumnName("shelfId");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK__clothing__catego__37A5467C");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK__clothing__kind__36B12243");

                entity.HasOne(d => d.SeasonNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.Season)
                    .HasConstraintName("FK__clothing__season__38996AB5");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK__clothing__setId__3A81B327");

                entity.HasOne(d => d.Shelf)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.ShelfId)
                    .HasConstraintName("FK__clothing__shelfI__3B75D760");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__clothing__userId__398D8EEE");
            });

            modelBuilder.Entity<ClothingTypes>(entity =>
            {
                entity.ToTable("clothingTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matching>(entity =>
            {
                entity.ToTable("matching");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MatchName)
                    .HasColumnName("match_name")
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<MatchingDeatails>(entity =>
            {
                entity.ToTable("matchingDeatails");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlternateClothing).HasColumnName("alternateClothing");

                entity.Property(e => e.ClothingId).HasColumnName("clothingId");

                entity.Property(e => e.NatchKod).HasColumnName("natchKod");

                entity.HasOne(d => d.AlternateClothingNavigation)
                    .WithMany(p => p.MatchingDeatailsAlternateClothingNavigation)
                    .HasForeignKey(d => d.AlternateClothing)
                    .HasConstraintName("FK__matchingD__alter__403A8C7D");

                entity.HasOne(d => d.Clothing)
                    .WithMany(p => p.MatchingDeatailsClothing)
                    .HasForeignKey(d => d.ClothingId)
                    .HasConstraintName("FK__matchingD__cloth__3F466844");

                entity.HasOne(d => d.NatchKodNavigation)
                    .WithMany(p => p.MatchingDeatails)
                    .HasForeignKey(d => d.NatchKod)
                    .HasConstraintName("FK__matchingD__natch__3E52440B");
            });

            modelBuilder.Entity<Seasons>(entity =>
            {
                entity.ToTable("seasons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SeasonName)
                    .HasColumnName("season_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sets>(entity =>
            {
                entity.ToTable("sets");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .IsUnicode(false);

                entity.Property(e => e.SetName)
                    .HasColumnName("set_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.ToTable("shelf");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClosetId).HasColumnName("closetId");

                entity.Property(e => e.ShelfDesc)
                    .HasColumnName("shelfDesc")
                    .IsUnicode(false);

                entity.HasOne(d => d.Closet)
                    .WithMany(p => p.Shelf)
                    .HasForeignKey(d => d.ClosetId)
                    .HasConstraintName("FK__shelf__closetId__33D4B598");
            });

            modelBuilder.Entity<SystemSettings>(entity =>
            {
                entity.ToTable("systemSettings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FrequencyOfUse).HasColumnName("frequencyOfUse");

                entity.Property(e => e.UseChip).HasColumnName("useChip");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BearthYear).HasColumnName("bearthYear");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Using>(entity =>
            {
                entity.ToTable("using");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClothingId).HasColumnName("clothingId");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("returnDate")
                    .HasColumnType("date");

                entity.Property(e => e.UsingDate)
                    .HasColumnName("usingDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Clothing)
                    .WithMany(p => p.Using)
                    .HasForeignKey(d => d.ClothingId)
                    .HasConstraintName("FK__using__clothingI__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
