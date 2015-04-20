using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hdwih.Jobs.Domain.Core
{
   public class UserAccountProfile
    {
        private int _numberOfResumesAllowed;
        private bool _isAccountStillActive;
        
        public int AccountId { get; set; }
        public AccountType AccountType { get; set; }
       // public DateTime OpenDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public bool IsAccountStillActive() 
        {
           return _isAccountStillActive = ClosedDate == null ? true : false;

        }
        public int GetNumberOfResumesAllowed()
        {
            if(this.AccountType.Equals(AccountType.Free))
            { 
                _numberOfResumesAllowed = 1;
            }
            if (this.AccountType.Equals(AccountType.Basic))
            {
                _numberOfResumesAllowed = 3;
            }
            if(this.AccountType.Equals(AccountType.Premium))
            {
                _numberOfResumesAllowed = 6;
            }

            return _numberOfResumesAllowed;
        }
        
    }
}
