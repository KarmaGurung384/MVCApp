using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CRMApp.Core.Contract.Repository
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsyn(T entity);
        Task<int> UpdateAsyn(T entity);
        Task<int> DeleteAsyn(int id);
        Task<T> GetByIdAsync (int id);
        Task<IEnumerable<T>> GetAllAsync();


    }
}
