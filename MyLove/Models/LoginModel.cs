using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class LoginModel
    {
        private IEnumerable<User_> users;
        private IEnumerable<Admin_> admins;
        public LoginModel()
        {
            Users = coursachEntities.GetContext().User_;
            Admins = coursachEntities.GetContext().Admin_;
        }

        public IEnumerable<User_> Users { get => users; set => users = value; }
        public IEnumerable<Admin_> Admins { get => admins; set => admins = value; }
    }
}
