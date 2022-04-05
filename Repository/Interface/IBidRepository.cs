using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBidRepository
    {
        Task<IQueryable<Bid>> GetExpiredBids();
        void UpdateBids(List<Bid> bids);
        Task<bool> SaveChangesAsync();
    }
}
