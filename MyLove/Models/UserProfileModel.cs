using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class UserProfileModel
    {
        private User_ user;
        public UserProfileModel(object user)
        {
            this.user = user as User_;
        }
    }
}
