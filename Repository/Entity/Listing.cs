using Kernel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static Kernel.Enumerations;

namespace Repository.Entity
{
    public class Listing : Entity<Guid>
    {
        public decimal AmountAvailable_Amount { get; private set; }
        public CurrencyType AmountAvailable_CurrencyType { get; private set; }
        public decimal AmountNeeded_Amount { get; private set; }
        public CurrencyType AmountNeeded_CurrencyType { get; private set; }
        //private List<Bid> _bids;
        //public IReadOnlyCollection<Bid> Bids => _bids;
        public DateTime DateCreated { get; private set; }
        public DateTime DateFinalized { get; private set; }
        public ListingStatus Status { get; private set; }

        public decimal MinExchangeAmount_Amount { get; private set; }
        public CurrencyType MinExchangeAmount_CurrencyType { get; private set; }
        public decimal ExchangeRate { get; private set; }
        public string ListedBy { get; private set; }
        public Guid CustomerId { get; private set; }
        public string Bank { get; private set; }
        public Guid SellersAccountId { get; private set; }
        public string Reference { get; private set; }
        //public Guid WalletId { get; private set; }

        public Listing() : base(Guid.NewGuid())
        {
           // _bids = new List<Bid>();
        }

        public void RemoveListing()
        {
            Status = ListingStatus.REMOVED;
        }
    }
}
