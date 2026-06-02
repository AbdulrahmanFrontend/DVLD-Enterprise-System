using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DVLD_Enterprise_System.UI.ViewModels;

namespace DVLD_Enterprise_System.UI.Views
{
    /// <summary>
    /// Interaction logic for SplashView.xaml
    /// </summary>
    public partial class SplashView : Window
    {
        private SplashViewModel _viewModel;

        public SplashView()
        {
            InitializeComponent();

            _viewModel = new SplashViewModel();

            SplashControl.DataContext = _viewModel.SplashData;

            DataContext = _viewModel;

            Loaded += SplashView_Loaded;
        }

        private async void SplashView_Loaded(object sender, RoutedEventArgs e)
            => await _viewModel.StartLoadingAsync();
    }
}
