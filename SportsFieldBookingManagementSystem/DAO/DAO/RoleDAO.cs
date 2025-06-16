using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class RoleDAO : GenericDAO<Role>
    {
        public RoleDAO() { }
        public RoleDAO(SportsFieldBookingContext context) => _context = context;
    }
}
