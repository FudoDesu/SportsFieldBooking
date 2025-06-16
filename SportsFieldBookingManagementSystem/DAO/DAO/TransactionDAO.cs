using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class TransactionDAO : GenericDAO<Transaction>
    {
        public TransactionDAO() { }
        public TransactionDAO(SportsFieldBookingContext context) => _context = context;
    }
}
