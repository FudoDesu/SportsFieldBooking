using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class FieldDAO : GenericDAO<Field>
    {
        public FieldDAO() { }
        public FieldDAO(SportsFieldBookingContext context) => _context = context;
    }
}
