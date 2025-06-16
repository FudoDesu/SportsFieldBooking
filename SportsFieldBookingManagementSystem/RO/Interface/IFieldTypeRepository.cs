using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IFieldTypeRepository
    {
        List<FieldType> GetList();
        Task<List<FieldType>> GetListAsync();
        FieldType GetById(int id);
        Task<FieldType> GetByIdAsync(int id);
        void Create(FieldType fieldType);
        Task CreateAsync(FieldType fieldType);
        void Update(FieldType fieldType);
        Task UpdateAsync(FieldType fieldType);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
