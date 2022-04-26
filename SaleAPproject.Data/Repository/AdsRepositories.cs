using Microsoft.EntityFrameworkCore;
using SaleAPproject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SaleAPproject.Data.Repository
{
    public class AdsRepositories : IAdsRepository
    {
        private readonly SaleAPDbContext _saleAPDbContext;

        public AdsRepositories(SaleAPDbContext saleAPDbContext)
        {
            _saleAPDbContext = saleAPDbContext;
        }

        public Task Add(Ads ads)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Ads>> GetAll()
        {
            var adsList = await _saleAPDbContext.Ads.ToListAsync();

            if (adsList != null)
            {
                return adsList;
            }

            return null;
        }

        public /*async*/ Task<IEnumerable<Ads>> GetAll(string fields)
        {
            //var ads = await _saleAPDbContext.Ads.ToListAsync(fields);

            //if (ads != null)
            //{
            //    return ads;
            //}

            return null;
        }

        public async Task<Ads> GetById(int id)
        {
            var ads = await _saleAPDbContext.Ads.FirstOrDefaultAsync(x => x.Id == id);

            if (ads != null)
            {
                return ads;
            }

            return null;
        }

        public async Task Save() => await _saleAPDbContext.SaveChangesAsync();

        public async Task<IEnumerable<Ads>> SortedByAscendingCreatedDate()
        {
            var adsList = await _saleAPDbContext.Ads.ToListAsync();

            adsList.OrderByDescending(x => x.Created)
                .ToList();

            if (adsList != null)
            {
                return adsList;
            }

            return null;
        }

        public async Task<IEnumerable<Ads>> SortedByDescendingCreatedDate()
        {
            var adsList = await _saleAPDbContext.Ads.ToListAsync();

            adsList.OrderBy(x=>x.Created)
                .ToList();

            if (adsList != null)
            {
                return adsList;
            }

            return null;
        }

        public async Task<IEnumerable<Ads>> SortedByMaxPrice()
        {
            var adsList = await _saleAPDbContext.Ads.ToListAsync();

            adsList.GroupBy(x => x.Price)
                .OrderByDescending(group => group
                .Max(x => x.Price));

            if (adsList != null)
            {
                return adsList;
            }

            return null;
        }

        public async Task<IEnumerable<Ads>> SortedByMinPrice()
        {
            var adsList = await _saleAPDbContext.Ads.ToListAsync();

            adsList.GroupBy(x => x.Price)
                .OrderByDescending(group => group
                .Min(x => x.Price));

            if (adsList != null)
            {
                return adsList;
            }

            return null;
        }

        public async Task<Ads> Update(Ads ads, string name)
        {
            var _ads = await _saleAPDbContext.Ads.FirstOrDefaultAsync(x => x.Id == ads.Id);

            if (ads != null)
            {
                _ads.Name = name;
                _saleAPDbContext.Ads.Add(ads);

                return _ads;
            }

            return null;
        }
    }
}
