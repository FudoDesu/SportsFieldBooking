using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model.UserModel
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
    }
}
