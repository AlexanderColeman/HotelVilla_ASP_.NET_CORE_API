using HotelVillaAPI.Models;
using System.Linq.Expressions;

namespace HotelVillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
