using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class ListingUpdater
    {
        private readonly IListingRepository _listingRepo;
        private readonly IBidRepository _bidRepo;
        private static Object lockObject = new Object();
        public ListingUpdater(IListingRepository listingRepo, IBidRepository bidRepo)
        {
            _listingRepo = listingRepo ?? throw new ArgumentNullException(nameof(listingRepo));
            _bidRepo = bidRepo ?? throw new ArgumentNullException(nameof(bidRepo));
        }

        public void CancelExpiredBids()
        {
            lock (lockObject)
            {
                var data = _listingRepo.GetExpiredListing().Result;
                var expiredListings = data.ToList();
                Parallel.ForEach(expiredListings, listing =>
                {
                    listing.RemoveListing();
                });

                _listingRepo.UpdateListings(expiredListings);

                var expiredBids = _bidRepo.GetExpiredBids().Result;
                Parallel.ForEach(expiredBids, bid =>
                {
                    bid.CancelBid();
                });

                _bidRepo.UpdateBids(expiredBids.ToList());

                _ = _bidRepo.SaveChangesAsync().Result;
            }

        }
    }
}
