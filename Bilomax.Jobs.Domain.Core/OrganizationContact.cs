using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
    public class OrganizationContact: GenericUser
    {
        public Organization Employer { get; set; }
        private void TagHdwihRecruit(int recruitId)
        {

        }
        public void ContactHdwihRecruit(int recruitId) { }
    }
}
