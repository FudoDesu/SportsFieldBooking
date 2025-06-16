using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class FieldTypeDAO : GenericDAO<Field>
    {
        public FieldTypeDAO() { }
        public FieldTypeDAO(SportsFieldBookingContext context) => _context = context;
    }
}
