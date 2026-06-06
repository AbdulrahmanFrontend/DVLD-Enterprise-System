using DevToolkit.BaseWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.UI.ViewModels
{
    public class SplashViewModel : BaseViewModel
    {
        private double _opacity = 0;

        public SplashScreenViewModel SplashData { get; private set; } = 
            new SplashScreenViewModel
            {
                LogoPath = "/Assets/Images/dvld-logo-light.png",
                Title = "DVLD Enterprise System",
                SubTitle = "Driving & Vehicle License Department",
                Version = "Version 1.0.0",
                StatusMessage = "Initializing...",
                ProgressValue = 0,
            };

        public double Opacity
        {
            get => _opacity;
            set => _SetProperty<double>(ref _opacity, value);
        }

        public async Task StartLoadingAsync()
        {
            for (int i = 0; i <= 10; i++)
            {
                Opacity = i / 10.0;

                await Task.Delay(10);
            }

            for (int i = 0; i <= 100; i++)
            {
                SplashData.ProgressValue = i;

                if (i <= 20)
                    SplashData.StatusMessage = "Initializing Modules...";
                else if (i <= 40)
                    SplashData.StatusMessage = "Loading Configuration...";
                else if (i <= 60)
                    SplashData.StatusMessage = "Loading Services...";
                else if (i <= 80)
                    SplashData.StatusMessage = "Connecting Database...";
                else if (i < 100)
                    SplashData.StatusMessage = "Preparing Interface...";
                else
                    SplashData.StatusMessage = "System Ready...";

                await Task.Delay(50);
            }

            for (int i = 10; i >= 0; i--)
            {
                Opacity = i / 10.0;

                await Task.Delay(10);
            }
        }
    }
}
