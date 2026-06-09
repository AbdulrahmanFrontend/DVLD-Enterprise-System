using DevToolkit.BaseWPF.Commands;
using DevToolkit.BaseWPF.ViewModels;
using DevToolkit.Core.Results;
using DVLD_Enterprise_System.UI.Services;
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
        private readonly AuthenticationService _authenticationService;

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login()
        {
            Result result = _authenticationService.Login(UserName);

            if (result.IsSuccess)
            {
                // Navigate to MainView
            }
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
