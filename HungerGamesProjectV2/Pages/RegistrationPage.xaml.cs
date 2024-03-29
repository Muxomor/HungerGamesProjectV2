using HungerGamesProject.Components;
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
using HungerGamesProjectV2.Components.DB;
using HungerGamesProjectV2;

namespace HungerGamesProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationHelper.NavigationToLogin();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            users.login = LoginTB.Text;
            if (PasswordPB.Password == ConfirmPassPB.Password)
            { 
                users.password = ConfirmPassPB.Password;
                if (Rolecb.SelectedItem.ToString() == "Участник")
                { 
                    users.role = 2;
                }
                else if (Rolecb.SelectedItem.ToString() == "Болельщик")
                { 
                    users.role = 3; 
                }
                if(TryAddUser(users))
                {
                    App.db.Users.Add(users);
                    App.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show($"Пользователь с логином {users.login} уже существует");
                }
                NavigationHelper.NavigationToLogin();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
                ConfirmPassPB.Clear();
            }
            
        }
        private bool TryAddUser(Users user)
        {
            if (App.db.Users.Any(x => x.login == LoginTB.Text))
            {
                return false;
            }
            else
            {
                App.db.Users.Add(user);
                return true;
            }
        }
    }
}
