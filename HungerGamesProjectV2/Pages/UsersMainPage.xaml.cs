using HungerGamesProject.Components;
using HungerGamesProjectV2;
using HungerGamesProjectV2.Components.DB;
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
    /// Логика взаимодействия для UsersMainPage.xaml
    /// </summary>
    public partial class UsersMainPage : Page
    {
        public UsersMainPage()
        {
            InitializeComponent();
            App.UserPageFrame = this.GameInfoFrame;
            
            //var user = (from p in App.db.Users where p.id == App.CurrentUser select p) as Users;
            loginTB.Text = App.CurrentUser.login;
            NameTB.Text = App.CurrentUser.name;
            RoleTB.Text = App.CurrentUser.Roles.role_name;
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationHelper.NavigationToLogin();
        }

        private void VotingBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationHelper.NavigateUsersPagesByRoute("Pages/VotesPage.xaml");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
