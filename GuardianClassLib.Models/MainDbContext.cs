using GuardianClassLib.Models.MainDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("Name=MainData") { }

        public DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<UserInfo>().HasKey(t => t.PkId);
        }
    }
}
