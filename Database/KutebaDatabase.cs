﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;
using Database;

namespace Database
{

    public class KutebaDatabase:DbContext
    {
        
        public KutebaDatabase() : base("name=KutebaDB") {
            System.Data.Entity.Database.SetInitializer<KutebaDatabase>(new DBInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Previlage> Prevlages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<GroupPrevilage> GroupPrevilages { get; set; }
    }
}
