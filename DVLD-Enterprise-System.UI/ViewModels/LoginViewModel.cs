using DevToolkit.BaseWPF.Commands;
using DevToolkit.BaseWPF.Services;
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
using System.Windows.Input;
using System.Windows.Navigation;

namespace DVLD_Enterprise_System.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        private readonly IAuthenticationService _authenticationService;

        public LoginViewModel()
        {
            _authenticationService = new AuthenticationService();

            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login()
        {
            Result<User> result = _authenticationService.Login(UserName, PasswordHash);

            if (result.IsSuccess)
            {
                //new DevToolkit.BaseWPF.Services.NavigationService().NavigateTo();
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(UserName)
                && !string.IsNullOrWhiteSpace(PasswordHash);
        }

        private string _userName = string.Empty;
        private string _password = string.Empty;

        public string UserName
        {
            get => _userName;
            set => _SetProperty(ref _userName, value);
        }

        public string PasswordHash
        {
            get => _password;
            set => _SetProperty(ref _password, value);
        }
    }
}
