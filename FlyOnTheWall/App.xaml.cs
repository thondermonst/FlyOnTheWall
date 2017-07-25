using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using FlyOnTheWall.Views;
using FlyOnTheWall.ViewModels;

namespace FlyOnTheWall
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainView _mainView;

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            var mainViewModel = MainViewModel.Instance;

            _mainView = new MainView();
            _mainView.DataContext = mainViewModel;
            _mainView.Show();
        }

        private void ApplicationExit(object sender, ExitEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
