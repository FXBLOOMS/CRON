using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IListingRepository
    {
        Task<IQueryable<Listing>> GetExpiredListing();
        void UpdateListings(List<Listing> listings);
        Task<bool> SaveChangesAsync();
    }
}
