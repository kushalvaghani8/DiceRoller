using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        { 
                return ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.diceroller")
                    .StartApp();
            
        }
    }
}
