using DevToolkit.BaseWPF.Commands;
using DevToolkit.BaseWPF.Services.Dialogs;
using DevToolkit.BaseWPF.ViewModels;
using DevToolkit.Core.Results;
using DVLD_Enterprise_System.BLL.Authentication;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace DVLD_Enterprise_System.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private RelayCommand _loginCommand;
        public ICommand LoginCommand => _loginCommand;
        private readonly IAuthenticationService _authenticationService;

        public LoginViewModel()
        {
            _authenticationService = new AuthenticationService();

            _loginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login()
        {
            Result<User> result = 
                _authenticationService.Login(UserName, Password);

            if (result.IsSuccess)
            {
                //new DevToolkit.BaseWPF.Services.NavigationService()
                //    .NavigateTo<MainView>();
            }
            else
            {
                IDialogService dialog = new DialogService();
                dialog.ShowError(result.Message);
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName)
                && !string.IsNullOrWhiteSpace(Password);
        }

        private string _userName = string.Empty;
        private string _password = string.Empty;
        private bool _rememberMe = false;
        private bool _showPassword = false;
        private string _errorMessage = string.Empty;

        public string UserName
        {
            get => _userName;
            set 
            {
                if (_SetProperty(ref _userName, value))
                    _loginCommand?.RaiseCanExecuteChanged();
            }
        }

        public string Password
        {
            get => _password;
            set 
            {
                if(_SetProperty(ref _password, value))
                    _loginCommand?.RaiseCanExecuteChanged(); 
            }
        }

        public bool RememberMe
        {
            get => _rememberMe;
            set => _SetProperty(ref _rememberMe, value);
        }

        public bool ShowPassword
        {
            get => _showPassword;
            set => _SetProperty(ref _showPassword, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => _SetProperty(ref _errorMessage, value);
        }
    }
}
