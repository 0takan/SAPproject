using SaleAPproject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleAPproject.Data
{
    public interface IAdsRepository
    {
        Task<Ads> GetById(int id);
        Task<IEnumerable<Ads>> GetAll();
        Task<IEnumerable<Ads>> GetAll(string fields);
        Task<IEnumerable<Ads>> SortedByMinPrice(decimal price);
        Task<IEnumerable<Ads>> SortedByMaxPrice(decimal price);
        Task<IEnumerable<Ads>> SortedByAscendingCreatedDate();
        Task<IEnumerable<Ads>> SortedByDescendingCreatedDate();
        Task Add(Ads ads);
        Task<Ads> Update(Ads ads, string name);
        Task Delete(int id);
        Task Save();
    }
}
