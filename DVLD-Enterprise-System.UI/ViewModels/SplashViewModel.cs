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
        private string _title = string.Empty;
        private string _statusText = string.Empty;
        private string _subTitle = string.Empty;
        private string _versionText = string.Empty;
        private int _progressValue = 0;
        private double _Opacity = 0;

        public string Title
        {
            get => _title;
            set
            {
                if(_title == value)
                    return;

                _title = value;
                OnPropertyChanged();
            }
        }

        public string StatusText
        {
            get => _statusText;
            set
            {
                if(_statusText == value)
                    return;

                _statusText = value;
                OnPropertyChanged();
            }
        }

        public string SubTitle
        {
            get => _subTitle;
            set
            {
                if (_subTitle == value)
                    return;

                _subTitle = value;
                OnPropertyChanged();
            }
        }

        public string VersionText
        {
            get => _versionText;
            set
            {
                if (_versionText == value)
                    return;

                _versionText = value;
                OnPropertyChanged();
            }
        }

        public int ProgressValue
        {
            get => _progressValue;
            set
            {
                if(_progressValue == value)
                    return;

                _progressValue = value;
                OnPropertyChanged();
            }
        }

        public double Opacity
        {
            get => _Opacity;
            set
            {
                if (_Opacity == value)
                    return;

                _Opacity = value;
                OnPropertyChanged();
            }
        }

        public SplashViewModel()
        {
            Title = "DVLD Enterprise System";
            SubTitle = "Driving & Vehicle License Department";
            VersionText = "Version 1.0.0";
            StatusText = "Initializing...";
            Opacity = 0;
        }

        public async Task StartLoadingAsync()
        {
            for (Opacity = 0; Opacity < 1; Opacity += 0.1d)
                await Task.Delay(10);

            for (int i = 0; i <= 100; i++)
            {
                ProgressValue = i;

                if (i <= 20)
                    StatusText = "Initializing Modules...";
                else if (i <= 40)
                    StatusText = "Loading Configuration...";
                else if (i <= 60)
                    StatusText = "Loading Services...";
                else if (i <= 80)
                    StatusText = "Connecting Database...";
                else if (i < 100)
                    StatusText = "Preparing Interface...";
                else
                    StatusText = "System Ready...";

                await Task.Delay(40);
            }

            for (Opacity = 1; Opacity > 0; Opacity -= 0.1d)
                await Task.Delay(10);
        }
    }
}
