using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehiculosMaui.Services
{
    public interface IApiService<T> where T : class
    {
        Task<List<T>> GetAllAsync(string endpoint);
        Task<T?> GetByIdAsync(string endpoint, int id);
        Task<T?> CreateAsync(string endpoint, T entity);
        Task<bool> UpdateAsync(string endpoint, int id, T entity);
        Task<bool> DeleteAsync(string endpoint, int id);
    }
}
