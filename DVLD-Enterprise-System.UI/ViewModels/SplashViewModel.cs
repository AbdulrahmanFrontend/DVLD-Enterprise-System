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
        private string _statusText;

        public string StatusText
        {
            get => _statusText;
            set
            {
                _statusText = value;
                OnPropertyChanged();
            }
        }

        public SplashViewModel()
        {
            StatusText = "Loading DVLD...";
        }
    }
}
