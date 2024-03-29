using HungerGamesProject.Components;
using HungerGamesProjectV2;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HungerGamesProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindowFrame.Navigate(new Uri("Pages/RegistrationPage.xaml",UriKind.Relative));
        }


        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FIeldsHelper.CheckTwoFields(LoginTB.Text,PasswordTB.Password))
            {
                //NavigationHelper.NavigateAfterLogin();
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void RegBtn_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
