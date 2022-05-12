using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class RegistrationModel
    {
        private DbSet<User_> users;
        private DbSet<Admin> admins;
        public RegistrationModel()
        {
            Users = coursachEntities.GetContext().Set<User_>();
            Admins = coursachEntities.GetContext().Set<Admin>();
        }

        public DbSet<User_> Users { get => users; set => users = value; }
        public DbSet<Admin> Admins { get => admins; set => admins = value; }

        public void AddUser(User_ user)
        {
            Users.Add(user);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
