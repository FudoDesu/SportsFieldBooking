using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface ITransactionRepository
    {
        List<Transaction> GetList();
        Task<List<Transaction>> GetListAsync();
        Transaction GetById(int id);
        Task<Transaction> GetByIdAsync(int id);
        void Create(Transaction transaction);
        Task CreateAsync(Transaction transaction);
        void Update(Transaction transaction);
        Task UpdateAsync(Transaction transaction);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
