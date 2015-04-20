using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace Hdwih.Jobs.Domain.Core
{
   public class PostingDetails
    {
       public EmploymentPosition PositionSpecifiction { get; set; }
       DateTime PostedDate { get; set; }
       DateTime ClosingDate { get; set; }
       OrganizationContact ContactPerson { get; set; }
       



    }
}
