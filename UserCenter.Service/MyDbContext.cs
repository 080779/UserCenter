using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UserCenter.Service.Config;
using UserCenter.Service.Entity;

namespace UserCenter.Service
{
    [Serializable]
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseMySQL("Server=192.168.31.114;database=zszdb;uid=root;pwd=root");
            optionsBuilder.UseMySQL("Server=192.168.1.104;database=zszdb;uid=root;pwd=root");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppInfoConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new UserGroupConfig());
        }
        public DbSet<AppInfoEntity> AppInfos { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserGroupEntity> UserGroups { get; set; }
    }
}
