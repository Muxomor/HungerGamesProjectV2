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
using HungerGamesProject.Components;
using HungerGamesProjectV2.Components;

namespace HungerGamesProjectV2.Pages
{
    /// <summary>
    /// Логика взаимодействия для VotesPage.xaml
    /// </summary>
    public partial class VotesPage : Page
    {
        public VotesPage()
        {
            InitializeComponent();
        }

        private void CreateVotingBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationHelper.NavigateUsersPagesByRoute("Pages/CreateVote.xaml");
        }
    }
}
