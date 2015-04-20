using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bilomax.Generic.Infrastructure.Settings
{
   public class WebAppSettings : IAppSettings
    {
       public string LoggerName { get { return ConfigurationManager.AppSettings["LoggerName"]; } }
    }
}
