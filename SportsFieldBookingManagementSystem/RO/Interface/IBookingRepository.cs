using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IBookingRepository
    {
        List<Booking> GetList();
        Task<List<Booking>> GetListAsync();
        Booking GetById(int id);
        Task<Booking> GetByIdAsync(int id);
        void Create(Booking booking);
        Task CreateAsync(Booking booking);
        void Update(Booking booking);
        Task UpdateAsync(Booking booking);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
