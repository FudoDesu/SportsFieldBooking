using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class BookingDAO : GenericDAO<Booking>
    {
        public BookingDAO() { }
        public BookingDAO(SportsFieldBookingContext context) => _context = context;
    }
}
