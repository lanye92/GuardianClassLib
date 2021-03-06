﻿using GuardianClassLib.Models.MainDb;
using GuardianClassLib.Models.MainDb.Activity;
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

        public DbSet<UserInfo> UserInfos { get; set; }

        public DbSet<RequestActivity> RequestActivity { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            //mb.Entity<UserInfo>().HasKey(t => t.PkId);
            //base.OnModelCreating(mb);
        }
    }
}
