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
    public class FieldRepository : IFieldRepository
    {
        public void Create(Field field) => UnitOfWork.Instance.FieldDAO.Create(field);

        public Task CreateAsync(Field field) => UnitOfWork.Instance.FieldDAO.CreateAsync(field);

        public void Delete(int id) => UnitOfWork.Instance.FieldDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.FieldDAO.DeleteAsync(id);

        public Field GetById(int id) => UnitOfWork.Instance.FieldDAO.GetById(id);

        public Task<Field> GetByIdAsync(int id) => UnitOfWork.Instance.FieldDAO.GetByIdAsync(id);

        public List<Field> GetList() => UnitOfWork.Instance.FieldDAO.GetList();

        public Task<List<Field>> GetListAsync() => UnitOfWork.Instance.FieldDAO.GetListAsync();

        public void Update(Field field) => UnitOfWork.Instance.FieldDAO.Update(field);

        public Task UpdateAsync(Field field) => UnitOfWork.Instance.FieldDAO.UpdateAsync(field);
    }
}
