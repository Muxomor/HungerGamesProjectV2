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
                if(App.db.Users.Any(x=>x.login == LoginTB.Text && x.password == PasswordTB.Password))
                {
                    if (App.db.Users.Any(x=>x.login == LoginTB.Text && x.role == 1))
                        {NavigationHelper.NavigateAfterLogin(true);}
                    else { 
                        NavigationHelper.NavigateAfterLogin(false);
                        var user  = App.db.Users.First(x=>x.login==LoginTB.Text); 
                        App.CurrentUser =user;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }

            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void LoginTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
