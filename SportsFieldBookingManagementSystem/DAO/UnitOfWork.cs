using BusinessObject.Entity;
using DataAccessObject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        private static readonly object locker = new object();
        public static UnitOfWork Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UnitOfWork();
                    }
                    return instance;
                }
            }
        }

        private BookingDAO _bookingDAO;
        private FieldDAO _fieldDAO;
        private FieldTypeDAO _fieldTypeDAO;
        private RoleDAO _roleDAO;
        private TransactionDAO _transactionDAO;
        private UserDAO _userDAO;

        private SportsFieldBookingContext context;

        public UnitOfWork()
        {
            _bookingDAO = new BookingDAO();
            _fieldDAO = new FieldDAO();
            _fieldTypeDAO = new FieldTypeDAO();
            _roleDAO = new RoleDAO();
            _transactionDAO = new TransactionDAO(); 
            _userDAO = new UserDAO();
        }
        public BookingDAO BookingDAO
        {
            get
            {
                return _bookingDAO ??= new BookingDAO(context);
            }
        }

        public FieldDAO FieldDAO
        {
            get
            {
                return _fieldDAO ??= new FieldDAO(context);
            }
        }

        public FieldTypeDAO FieldTypeDAO
        {
            get
            {
                return _fieldTypeDAO ??= new FieldTypeDAO(context);
            }
        }

        public RoleDAO RoleDAO
        {
            get
            {
                return _roleDAO ??= new RoleDAO(context);
            }
        }

        public TransactionDAO TransactionDAO
        {
            get
            {
                return _transactionDAO ??= new TransactionDAO(context);
            }
        }

        public UserDAO UserDAO
        {
            get
            {
                return _userDAO ??= new UserDAO(context);
            }
        }
    }
}
