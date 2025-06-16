using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryObject.Interface
{
    public interface IFieldRepository
    {
        List<Field> GetList();
        Task<List<Field>> GetListAsync();
        Field GetById(int id);
        Task<Field> GetByIdAsync(int id);
        void Create(Field field);
        Task CreateAsync(Field field);
        void Update(Field field);
        Task UpdateAsync(Field field);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
