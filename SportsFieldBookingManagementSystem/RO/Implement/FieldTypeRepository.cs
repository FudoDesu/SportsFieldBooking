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
    public class FieldTypeRepository : IFieldTypeRepository
    {
        public void Create(FieldType fieldType) => UnitOfWork.Instance.FieldTypeDAO.Create(fieldType);

        public Task CreateAsync(FieldType fieldType) => UnitOfWork.Instance.FieldTypeDAO.CreateAsync(fieldType);

        public void Delete(int id) => UnitOfWork.Instance.FieldTypeDAO.Delete(id);

        public Task DeleteAsync(int id) => UnitOfWork.Instance.FieldTypeDAO.DeleteAsync(id);

        public FieldType GetById(int id) => UnitOfWork.Instance.FieldTypeDAO.GetById(id);

        public Task<FieldType> GetByIdAsync(int id) => UnitOfWork.Instance.FieldTypeDAO.GetByIdAsync(id);

        public List<FieldType> GetList() => UnitOfWork.Instance.FieldTypeDAO.GetList();

        public Task<List<FieldType>> GetListAsync() => UnitOfWork.Instance.FieldTypeDAO.GetListAsync();

        public void Update(FieldType fieldType) => UnitOfWork.Instance.FieldTypeDAO.Update(fieldType);

        public Task UpdateAsync(FieldType fieldType) => UnitOfWork.Instance.FieldTypeDAO.UpdateAsync(fieldType);
    }
}
