using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilomax.Generic.Infrastructure.Settings
{
    /// <summary>
    ///This class uses method injection to inject 
    ///a valid IApplicationSettings instance 
    ///and has a single static GetApplicationSettings. 
    ///The reason for the static method and the method
    ///injection over constructor injection is to 
    ///allow  services and other classes to use 
    ///the ApplicationSettings Factory without having 
    ///to add it to the class’s constructor. 
    ///This keeps the infrastructure concerns out of your service layer
    /// 
    /// </summary>
   public class ApplicationSettingsFactory
    {
       private static IAppSettings _appSettings;
       public static void InitializeApplicationSettingsFactory(IAppSettings appsettings)
       {
           _appSettings = appsettings;
       }
       public static IAppSettings GetApplicationSettings()
       {
           return _appSettings;
       }
    }
}
