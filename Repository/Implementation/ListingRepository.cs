using Microsoft.VisualBasic.CompilerServices;
using Repository.Context;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kernel.Enumerations;

namespace Repository.Implementation
{
    public class ListingRepository : ManagerBase<Listing>, IListingRepository
    {
        public ListingRepository(FXBloomContext context) : base(context)
        {
        }
        public Task<IQueryable<Listing>> GetExpiredListing()
        {
            DateTime dateTime = DateTime.UtcNow.AddDays(-3);
            return GetAllAsync(e => e.DateCreated <= dateTime && (e.Status == ListingStatus.OPEN || e.Status == ListingStatus.FINALIZED));
        }

        public Task<bool> SaveChangesAsync()
        {
            return SaveAsync();
        }

        public void UpdateListings(List<Listing> listings)
        {
            UpdateRange(listings);
        }
    }
}
