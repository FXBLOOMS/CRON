using System;
using System.Collections.Generic;
using System.Text;

namespace Kernel
{
    public static class Enumerations
    {
        public enum OnboardingRedirection
        {
            SETUP_2FA = 1,
            EMAIL_VERIFICATION = 2,
            PROCEED_TO_LOGIN = 3,
            FILL_FORM1 = 4,
            FILL_FORM2 = 5,
            PROCEED_TO_DASHBOARD = 7
        }
        public enum DocumentType
        {

            INTERNATIONAL_PASSPORT = 0,
            DRIVERS_LICENSE = 1,
            NIMC = 2,
            RESIDENCE_PERMIT = 3
        }

        public enum DocumentStatus
        {
            APPROVED = 1,
            PENDING = 2,
            REJECTED = 3,
            NOT_SUBMITTED = 4
        }

        public enum ListingStatus
        {
            OPEN = 1,
            REMOVED = 2,
            NEGOTIATION = 3,
            FINALIZED = 4
        }

        public enum NegotiationStatus
        {
            IN_PROGRESS = 1,
            CANCELED = 2,
            COMPLETED = 3
        }


        public enum CurrencyType
        {
            NGN = 1,
            EUR = 2
        }

        public enum CustomerStatus
        {
            CONFIRMED = 1,
            REJECTED = 2,
            PENDING = 3,
            NO_PROFILE = 4,
            SUSPENDED = 5
        }

        public enum AccountType
        {
            FOREIGN,
            DOMESTIC,
        }
    }
}
