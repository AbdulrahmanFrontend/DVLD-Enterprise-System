using DevToolkit.BaseWPF.Commands;
using DevToolkit.BaseWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DVLD_Enterprise_System.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login()
        {
            // login logic
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName)
                && !string.IsNullOrWhiteSpace(Password);
        }

        private string _userName = string.Empty;
        private string _password = string.Empty;

        public string UserName
        {
            get => _userName;
            set => _SetProperty(ref _userName, value);
        }

        public string Password
        {
            get => _password;
            set => _SetProperty(ref _password, value);
        }
    }
}
