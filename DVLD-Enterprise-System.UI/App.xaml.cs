using DevToolkit.BaseWPF.Services.Navigation;
using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.Registry;
using DevToolkit.Logging.Providers;
using DVLD_Enterprise_System.BLL.Startup;
using DVLD_Enterprise_System.UI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DVLD_Enterprise_System.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(
            object sender, 
            StartupEventArgs e)
        {
            DataConfiguration.Configure(ConfigurationManager
                .ConnectionStrings["ConnectionString"]?
                .ConnectionString?.ToString());

            EventLogger.SourceName = "DVLD-Enterprise-System";

            RegistryConfiguration.CompanyName = "Abdulrahman Nasser";
            RegistryConfiguration.ApplicationName = "DVLD-Enterprise-System";

            DbManager.Initialize(
                DevToolkit.Data.Core.DbProviderFactory.DbProvider.SqlServer);

            SplashView splash = new SplashView();

            splash.Show();

            await Task.Delay(7000);

            StartupService startupService = new StartupService();

            INavigationService navigation = new NavigationService();

            if (startupService.IsAdminFound().IsSuccess)
            { 
                navigation.NavigateTo<LoginView>(splash); 
            }
            else
                navigation.NavigateTo<RegisterAdminView>(splash);
        }
    }
}
