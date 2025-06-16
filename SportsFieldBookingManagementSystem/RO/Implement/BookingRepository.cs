using BusinessObject.Entity;
using DataAccessObject;
using RepositoryObject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Implement
{
    public class BookingRepository : IBookingRepository
    {
        public void Create(Booking booking) => UnitOfWork.Instance.BookingDAO.Create(booking);

        public Task CreateAsync(Booking booking) => UnitOfWork.Instance.BookingDAO.CreateAsync(booking);

        public void Delete(int id) => UnitOfWork.Instance.BookingDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.BookingDAO.DeleteAsync(id);

        public Booking GetById(int id) => UnitOfWork.Instance.BookingDAO.GetById(id);

        public Task<Booking> GetByIdAsync(int id) => UnitOfWork.Instance.BookingDAO.GetByIdAsync(id); 

        public List<Booking> GetList() => UnitOfWork.Instance.BookingDAO.GetList();

        public Task<List<Booking>> GetListAsync() => UnitOfWork.Instance.BookingDAO.GetListAsync();

        public void Update(Booking booking) => UnitOfWork.Instance.BookingDAO.Update(booking);

        public Task UpdateAsync(Booking booking) => UnitOfWork.Instance.BookingDAO.UpdateAsync(booking);
    }
}
