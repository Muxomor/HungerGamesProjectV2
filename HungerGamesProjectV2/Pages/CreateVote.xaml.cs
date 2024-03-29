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

namespace HungerGamesProjectV2.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateVote.xaml
    /// </summary>
    public partial class CreateVote : Page
    {
        
        public CreateVote()
        {
            InitializeComponent();
            //EventNameCB.ItemsSource = App.db.Hunger_Events.ToArray();
           // Users[] players = App.db.Votes.Select(x => x.Players.Users.name).ToArray();
            player1CB.ItemsSource = App.db.Players.ToArray().Select(x => x.Users.login);
        }
    }
}
