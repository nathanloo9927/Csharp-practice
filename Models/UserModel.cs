using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SideProject.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
