using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Settings
{
    /// <summary>
    /// will use various configuration settings. 
    /// These will initially be stored in the
    /// Web.config of the Web.MVC project but
    /// could change, so create a component that 
    /// abstracts away from the actual
    /// implementation of where configuration settings are placed. 
    /// </summary>
   public interface IAppSettings
    {
       string LoggerName { get; }
    }
}
