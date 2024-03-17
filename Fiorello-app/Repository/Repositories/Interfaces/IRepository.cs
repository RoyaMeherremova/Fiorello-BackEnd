using Domain.Common;
using System;
using System.Linq.Expressions;


namespace Repository.Repositories.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int? id);    
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> expression = null);



    }
}
