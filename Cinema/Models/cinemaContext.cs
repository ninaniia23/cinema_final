using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cinema.Models
{
    public partial class cinemaContext : DbContext
    {
        public cinemaContext()
        {
        }

        public cinemaContext(DbContextOptions<cinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CumRap> CumRaps { get; set; } = null!;
        public virtual DbSet<KeHoachChieu> KeHoachChieus { get; set; } = null!;
        public virtual DbSet<LichChieu> LichChieus { get; set; } = null!;
        public virtual DbSet<Phim> Phims { get; set; } = null!;
        public virtual DbSet<PhongChieu> PhongChieus { get; set; } = null!;
        public virtual DbSet<Rap> Raps { get; set; } = null!;
        public virtual DbSet<SuatChieu> SuatChieus { get; set; } = null!;
        public virtual DbSet<TheLoai> TheLoais { get; set; } = null!;
        public virtual DbSet<ViTriNgoi> ViTriNgois { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=cinema;Trusted_Connection=True;user=sa;password=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CumRap>(entity =>
            {
                entity.HasKey(e => e.MaCum)
                    .HasName("PK__CumRap__3DC85095224D75CD");

                entity.ToTable("CumRap");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.TenCum).HasMaxLength(50);
            });

            modelBuilder.Entity<KeHoachChieu>(entity =>
            {
                entity.HasKey(e => new { e.MaPhim, e.MaCum, e.NgayKhoiChieu, e.NgayKetThuc })
                    .HasName("PK__KeHoachC__EC5C5A94D49AC49F");

                entity.ToTable("KeHoachChieu");

                entity.Property(e => e.NgayKhoiChieu).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.HasOne(d => d.MaCumNavigation)
                    .WithMany(p => p.KeHoachChieus)
                    .HasForeignKey(d => d.MaCum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KeHoachCh__MaCum__4D94879B");

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.KeHoachChieus)
                    .HasForeignKey(d => d.MaPhim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KeHoachCh__MaPhi__4CA06362");
            });

            modelBuilder.Entity<LichChieu>(entity =>
            {
                entity.HasKey(e => new { e.MaPhim, e.MaRap, e.NgayChieu })
                    .HasName("PK__LichChie__E8858F53145FAC5B");

                entity.ToTable("LichChieu");

                entity.Property(e => e.NgayChieu).HasColumnType("date");

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.LichChieus)
                    .HasForeignKey(d => d.MaPhim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichChieu__MaPhi__5070F446");

                entity.HasOne(d => d.MaRapNavigation)
                    .WithMany(p => p.LichChieus)
                    .HasForeignKey(d => d.MaRap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichChieu__MaRap__5165187F");
            });

            modelBuilder.Entity<Phim>(entity =>
            {
                entity.HasKey(e => e.MaPhim)
                    .HasName("PK__Phim__4AC03DE3AA13CE3B");

                entity.ToTable("Phim");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.QuocGia).HasMaxLength(255);

                entity.Property(e => e.TacGia).HasMaxLength(255);

                entity.Property(e => e.TenPhim).HasMaxLength(50);

                entity.HasOne(d => d.MaSuatNavigation)
                    .WithMany(p => p.Phims)
                    .HasForeignKey(d => d.MaSuat)
                    .HasConstraintName("FK__Phim__MaSuat__5EBF139D");

                entity.HasOne(d => d.MaTheLoaiChinhNavigation)
                    .WithMany(p => p.Phims)
                    .HasForeignKey(d => d.MaTheLoaiChinh)
                    .HasConstraintName("FK__Phim__MaTheLoaiC__45F365D3");

                entity.HasMany(d => d.MaTheLoais)
                    .WithMany(p => p.MaPhims)
                    .UsingEntity<Dictionary<string, object>>(
                        "PhimTheLoaiPhu",
                        l => l.HasOne<TheLoai>().WithMany().HasForeignKey("MaTheLoai").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PhimTheLo__MaThe__49C3F6B7"),
                        r => r.HasOne<Phim>().WithMany().HasForeignKey("MaPhim").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PhimTheLo__MaPhi__48CFD27E"),
                        j =>
                        {
                            j.HasKey("MaPhim", "MaTheLoai").HasName("PK__PhimTheL__F7B3C2D7F72023AD");

                            j.ToTable("PhimTheLoaiPhu");

                            j.IndexerProperty<int>("MaPhim").ValueGeneratedOnAdd();
                        });
            });

            modelBuilder.Entity<PhongChieu>(entity =>
            {
                entity.HasKey(e => e.MaPhongChieu)
                    .HasName("PK__PhongChi__121FC6E26306A4CE");

                entity.ToTable("PhongChieu");

                entity.Property(e => e.TenPhongChieu).HasMaxLength(10);
            });

            modelBuilder.Entity<Rap>(entity =>
            {
                entity.HasKey(e => e.MaRap)
                    .HasName("PK__Rap__3961207F2907D05C");

                entity.ToTable("Rap");

                entity.HasOne(d => d.MaCumNavigation)
                    .WithMany(p => p.Raps)
                    .HasForeignKey(d => d.MaCum)
                    .HasConstraintName("FK__Rap__MaCum__3F466844");

                entity.HasOne(d => d.MaPhongChieuNavigation)
                    .WithMany(p => p.Raps)
                    .HasForeignKey(d => d.MaPhongChieu)
                    .HasConstraintName("FK__Rap__MaPhongChie__403A8C7D");
            });

            modelBuilder.Entity<SuatChieu>(entity =>
            {
                entity.HasKey(e => e.MaSuat)
                    .HasName("PK__SuatChie__A69D0241A460E03C");

                entity.ToTable("SuatChieu");

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.SuatChieus)
                    .HasForeignKey(d => d.MaPhim)
                    .HasConstraintName("FK__SuatChieu__MaPhi__5FB337D6");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__TheLoai__D73FF34AD8A5E873");

                entity.ToTable("TheLoai");

                entity.Property(e => e.TenTheLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<ViTriNgoi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViTriNgoi");

                entity.Property(e => e.MaViTri).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
