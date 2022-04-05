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
    public class BidRepository : ManagerBase<Bid>, IBidRepository
    {
        public BidRepository(FXBloomContext context) : base(context)
        {

        }

        public Task<IQueryable<Bid>> GetExpiredBids()
        {
            DateTime date = DateTime.UtcNow.AddHours(1).AddMinutes(-5);
            return GetAllAsync(e => e.Status == NegotiationStatus.IN_PROGRESS
                                                    && e.DatePlaced <= date);
        }

        public Task<bool> SaveChangesAsync()
        {
            return SaveAsync();
        }

        public void UpdateBids(List<Bid> bids)
        {
            UpdateRange(bids);
        }
    }
}
