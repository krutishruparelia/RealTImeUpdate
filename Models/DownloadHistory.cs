namespace Scheduler.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DownloadHistory : DbContext
    {
        public DownloadHistory()
            : base("name=DownloadHistory")
        {
        }

        public virtual DbSet<tbl_downloadhistory> tbl_downloadhistory { get; set; }
        public virtual DbSet<tbl_FTPDetails> tbl_FTPDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_downloadhistory>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_downloadhistory>()
                .Property(e => e.Msg)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FTPDetails>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FTPDetails>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FTPDetails>()
                .Property(e => e.Duration)
                .IsUnicode(false);
        }
    }
}
