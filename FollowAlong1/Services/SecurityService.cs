using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SideProject.Models;

namespace SideProject.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();
        UsersDAO daoobj = new UsersDAO();

        public SecurityService()
        {

        }

        public bool isValid(UserModel user)
        {
            return daoobj.finduser(user);
        }
    }
}
