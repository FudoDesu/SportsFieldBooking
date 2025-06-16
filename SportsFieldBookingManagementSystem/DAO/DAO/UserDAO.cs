using BusinessObject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class UserDAO : GenericDAO<User>
    {
        public UserDAO() { }
        public UserDAO(SportsFieldBookingContext context) => _context = context;

        public User Login(string email, string password)
        {
            //var db = new SportsFieldBookingContext();
            using (var db = new SportsFieldBookingContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
                return user;
            }
        }

        public async Task<User> LoginAsync(string email, string password)
        {
            //var db = new SportsFieldBookingContext();
            using (var db = new SportsFieldBookingContext())
            {
                var user = await db.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
                return user;
            }
        }
    }
}
