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
    public class TransactionRepository : ITransactionRepository
    {
        public void Create(Transaction transaction) => UnitOfWork.Instance.TransactionDAO.Create(transaction);

        public Task CreateAsync(Transaction transaction) => UnitOfWork.Instance.TransactionDAO.CreateAsync(transaction);

        public void Delete(int id) => UnitOfWork.Instance.TransactionDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.TransactionDAO.DeleteAsync(id);

        public Transaction GetById(int id) => UnitOfWork.Instance.TransactionDAO.GetById(id);

        public Task<Transaction> GetByIdAsync(int id) => UnitOfWork.Instance.TransactionDAO.GetByIdAsync(id);

        public List<Transaction> GetList() => UnitOfWork.Instance.TransactionDAO.GetList();

        public Task<List<Transaction>> GetListAsync() => UnitOfWork.Instance.TransactionDAO.GetListAsync();

        public void Update(Transaction transaction) => UnitOfWork.Instance.TransactionDAO.Update(transaction);

        public Task UpdateAsync(Transaction transaction) => UnitOfWork.Instance.TransactionDAO.UpdateAsync(transaction);
    }
}
