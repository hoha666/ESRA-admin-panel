using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebWare.Models
{
    public partial class ipdbContext : DbContext
    {
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCategoryType> TblCategoryType { get; set; }
        public virtual DbSet<TblEsra> TblEsra { get; set; }
        public virtual DbSet<TblFile> TblFile { get; set; }
        public virtual DbSet<TblGame> TblGame { get; set; }
        public virtual DbSet<TblGameCategory> TblGameCategory { get; set; }
        public virtual DbSet<TblOrganizationBonyad> TblOrganizationBonyad { get; set; }
        public virtual DbSet<TblPictogram> TblPictogram { get; set; }
        public virtual DbSet<TblPlatform> TblPlatform { get; set; }
        public virtual DbSet<TblScreenshotType> TblScreenshotType { get; set; }
        public virtual DbSet<TblSourceType> TblSourceType { get; set; }
        public virtual DbSet<TblVersion> TblVersion { get; set; }
        public virtual DbSet<TblVersionCategory> TblVersionCategory { get; set; }
        public virtual DbSet<TblVersionEsra> TblVersionEsra { get; set; }
        public virtual DbSet<TblVersionGenre> TblVersionGenre { get; set; }
        public virtual DbSet<TblVersionPictogram> TblVersionPictogram { get; set; }
        public virtual DbSet<TblVersionPublisherProducers> TblVersionPublisherProducer { get; set; }
        public virtual DbSet<TblVersionScreenshot> TblVersionScreenshot { get; set; }
        //[Function(FunctionType.TableValuedFunction, nameof(func_GetGameIntroduction_HBL), Schema = dbo)]
        //public static DbSet<GGI> func_GetGameIntroduction_HBL()
        //{
        //    throw new NotImplementedException();
        //}

        public ipdbContext(DbContextOptions<ipdbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<TblVersionScreenshot>(entity =>
            {
                entity.ToTable("tblVersionScreenshot");


            });
            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tblCategory");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.IdCategoryTypeNavigation)
                    .WithMany(p => p.TblCategory)
                    .HasForeignKey(d => d.IdCategoryType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCategory_tblCategoryType");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK_tblGenre_tblGenre");
            });

            modelBuilder.Entity<TblCategoryType>(entity =>
            {
                entity.ToTable("tblCategoryType");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEsra>(entity =>
            {
                entity.ToTable("tblEsra");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.HasOne(d => d.IdHeadNavigation)
                    .WithMany(p => p.InverseIdHeadNavigation)
                    .HasForeignKey(d => d.IdHead)
                    .HasConstraintName("FK_tblEsra_tblEsra");
            });

            modelBuilder.Entity<TblFile>(entity =>
            {
                entity.ToTable("tblFile");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.UploadDateTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<TblGame>(entity =>
            {
                entity.ToTable("tblGame");

                entity.HasIndex(e => new { e.Id, e.Name })
                    .HasName("index_name");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Name2).HasMaxLength(100);

                entity.Property(e => e.PublishDateTime).HasColumnType("datetime");

                entity.Property(e => e.WebSite).HasMaxLength(2000);

                entity.HasOne(d => d.IdProducerNavigation)
                    .WithMany(p => p.TblGame)
                    .HasForeignKey(d => d.IdProducer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGame_tblOrganizationBonyad");
            });

            modelBuilder.Entity<TblGameCategory>(entity =>
            {
                entity.ToTable("tblGameCategory");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblOrganizationBonyad>(entity =>
            {
                entity.ToTable("tblOrganizationBonyad");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BusinessLicensesExpireDateTime).HasColumnType("datetime");

                entity.Property(e => e.EconomicCode).HasMaxLength(50);

                entity.Property(e => e.IdCeo).HasColumnName("IdCEO");

                entity.Property(e => e.LicenseNumber).HasMaxLength(100);

                entity.Property(e => e.LinkEmail).HasMaxLength(200);

                entity.Property(e => e.LinkPhone).HasMaxLength(50);

                entity.Property(e => e.ManagerPhone).HasMaxLength(50);

                entity.Property(e => e.NationalId)
                    .HasColumnName("NationalID")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasColumnType("char(10)");

                entity.Property(e => e.RegistrationDateTime).HasColumnType("datetime");

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

                entity.HasOne(d => d.IdForeignPublisherNavigation)
                    .WithMany(p => p.InverseIdForeignPublisherNavigation)
                    .HasForeignKey(d => d.IdForeignPublisher)
                    .HasConstraintName("FK_tblOrganizationBonyad_tblOrganizationBonyad");
            });

            modelBuilder.Entity<TblPictogram>(entity =>
            {
                entity.ToTable("tblPictogram");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.IdHeadNavigation)
                    .WithMany(p => p.InverseIdHeadNavigation)
                    .HasForeignKey(d => d.IdHead)
                    .HasConstraintName("FK_tblPictogram_tblPictogram");
            });

            modelBuilder.Entity<TblPlatform>(entity =>
            {
                entity.ToTable("tblPlatform");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblScreenshotType>(entity =>
            {
                entity.ToTable("tblScreenshotType");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSourceType>(entity =>
            {
                entity.ToTable("tblSourceType");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblVersion>(entity =>
            {
                entity.ToTable("tblVersion");

                entity.Property(e => e.AddDate)
                    .HasColumnName("addDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBasket)
                    .HasColumnName("idBasket")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IntroductionMin).HasMaxLength(1000);

                entity.Property(e => e.OldId)
                    .HasColumnName("OldID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDateTime).HasColumnType("datetime");

                entity.Property(e => e.VersionCode).HasMaxLength(50);

                entity.HasOne(d => d.IdGameNavigation)
                    .WithMany(p => p.TblVersion)
                    .HasForeignKey(d => d.IdGame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersion_tblGame");

                entity.HasOne(d => d.IdProducerNavigation)
                    .WithMany(p => p.TblVersion)
                    .HasForeignKey(d => d.IdProducer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersion_tblOrganizationBonyad");

                entity.HasOne(d => d.IdSourceTypeNavigation)
                    .WithMany(p => p.TblVersion)
                    .HasForeignKey(d => d.IdSourceType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersion_tblSourceType");
            });

            modelBuilder.Entity<TblVersionCategory>(entity =>
            {
                entity.HasKey(e => new { e.IdVersion, e.IdCategory });

                entity.ToTable("tblVersionCategory");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.TblVersionCategory)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionCategory_tblCategory");

                entity.HasOne(d => d.IdVersionNavigation)
                    .WithMany(p => p.TblVersionCategory)
                    .HasForeignKey(d => d.IdVersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionCategory_tblVersion");
            });

            modelBuilder.Entity<TblVersionEsra>(entity =>
            {
                entity.ToTable("tblVersionEsra");

                entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdEsraNavigation)
                    .WithMany(p => p.TblVersionEsraIdEsraNavigation)
                    .HasForeignKey(d => d.IdEsra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionEsra_tblEsra");

                entity.HasOne(d => d.IdSystemNavigation)
                    .WithMany(p => p.TblVersionEsraIdSystemNavigation)
                    .HasForeignKey(d => d.IdSystem)
                    .HasConstraintName("FK_tblVersionEsra_tblEsra1");

                entity.HasOne(d => d.IdVersionNavigation)
                    .WithMany(p => p.TblVersionEsra)
                    .HasForeignKey(d => d.IdVersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionEsra_tblVersion");
            });

            modelBuilder.Entity<TblVersionPublisherProducers>(entity =>
            {
                entity.ToTable("tblVersionPublisherProducers");
                entity.HasKey(e => new { e.ObjectId, e.VersionId });

            });

            modelBuilder.Entity<TblVersionGenre>(entity =>
            {
                entity.HasKey(e => new { e.IdVersion, e.IdGenre });

                entity.ToTable("tblVersionGenre");

                entity.HasOne(d => d.IdGenreNavigation)
                    .WithMany(p => p.TblVersionGenre)
                    .HasForeignKey(d => d.IdGenre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionGenre_tblGenre");

                entity.HasOne(d => d.IdVersionNavigation)
                    .WithMany(p => p.TblVersionGenre)
                    .HasForeignKey(d => d.IdVersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionGenre_tblVersion");
            });

            modelBuilder.Entity<TblVersionPictogram>(entity =>
            {
                entity.HasKey(e => new { e.IdVersion, e.IdPictogram, e.IdUser });

                entity.ToTable("tblVersionPictogram");

                entity.Property(e => e.IsSuggestion).HasColumnName("isSuggestion");

                entity.HasOne(d => d.IdPictogramNavigation)
                    .WithMany(p => p.TblVersionPictogram)
                    .HasForeignKey(d => d.IdPictogram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionPictogram_tblPictogram");

                entity.HasOne(d => d.IdVersionNavigation)
                    .WithMany(p => p.TblVersionPictogram)
                    .HasForeignKey(d => d.IdVersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionPictogram_tblVersion");
            });

            modelBuilder.Entity<TblVersionScreenshot>(entity =>
            {
                entity.HasKey(e => new { e.IdVersion, e.IdFile });

                entity.ToTable("tblVersionScreenshot");

                entity.HasOne(d => d.IdScreenshotTypeNavigation)
                    .WithMany(p => p.TblVersionScreenshot)
                    .HasForeignKey(d => d.IdScreenshotType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVersionScreenshot_tblScreenshotType");
            });
        }

      
    }
}
