using Kernel;
using System;
using System.Collections.Generic;
using System.Text;
using static Kernel.Enumerations;

namespace Repository.Entity
{
    public class Bid : Entity<Guid>
    {
        public Guid CustomerId { get; private set; }
        public Guid ListingId { get; private set; }
        public NegotiationStatus Status { get; private set; }
        public DateTime DatePlaced { get; private set; }
        public DateTime DateCompleted { get; private set; }
        public DateTime DateCancelled { get; private set; }
        public bool BuyerTransferConfirmed { get; private set; }
        public bool SellerTransferConfirmed { get; private set; }
        public decimal BidAmount_Amount { get; private set; }
        public CurrencyType BidAmount_CurrencyType { get; private set; }
        public Guid AccountId { get; private set; }
        public string Reference { get; private set; }

        public Bid() : base(Guid.NewGuid())
        {

        }

        public void CancelBid()
        {
            Status = NegotiationStatus.CANCELED;
            DateCancelled = DateTime.UtcNow.AddHours(1);
        }
    }
}
