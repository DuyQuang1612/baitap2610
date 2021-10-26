using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    public partial class LTQLdbcontext : DbContext
    {
        public LTQLdbcontext() : base("name=LTQLdbcontext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().Property(e => e.Username).IsUnicode(false);
            modelBuilder.Entity<Account>().Property(e => e.Password).IsUnicode(false);
            modelBuilder.Entity<KhachHang>().Property(e => e.KhachHangID).IsUnicode(false);
            modelBuilder.Entity<KhachHang>().Property(e => e.KhachHangSodt).IsUnicode(false);


        }
    }
}