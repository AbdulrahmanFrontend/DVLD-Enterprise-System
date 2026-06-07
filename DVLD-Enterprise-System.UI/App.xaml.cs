using DevToolkit.BaseWPF.Services;
using DVLD_Enterprise_System.UI.Services;
using DVLD_Enterprise_System.UI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SplashView splash = new SplashView();

            splash.Show();

            StartupService startupService = new StartupService();

            if (startupService.HasUsers())
                new NavigationService().NavigateTo<LoginView>(splash);
            else
                new NavigationService().NavigateTo<RegisterAdminView>(splash);
        }
    }
}
