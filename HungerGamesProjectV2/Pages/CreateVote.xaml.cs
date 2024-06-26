﻿using HungerGamesProjectV2.Components.DB;
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
            EventNameCB.ItemsSource = App.db.Hunger_Events.ToArray();
           // Users[] players = App.db.Votes.Select(x => x.Players.Users.name).ToArray();
            player1CB.ItemsSource = App.db.Players.ToArray().Select(x => x.Users.login);
            player2CB.ItemsSource = App.db.Players.ToArray().Select(x => x.Users.login);
        }

        private void CreateVoteBtn_Click(object sender, RoutedEventArgs e)
        {
            string player1_login = player1CB.SelectedValue.ToString();
            var idOne = from p in App.db.Players where p.Users.login == player1_login select p.player_id;
            var idTwo = from p in App.db.Players where p.Users.login == player2CB.SelectedValue.ToString() select p.player_id;
            //var player1_userid =Convert.ToInt32(App.db.Users.Where(x => x.login == player1_login).ToString());
            //var player1_id = Convert.ToInt32(App.db.Players.Where(x=>x.id_user== player1_userid));
            //var player2_userid = Convert.ToInt32(App.db.Players.Where(x => x.Users.login == player2CB.SelectedValue.ToString()));

            Votes vote = new Votes();
            vote.player1_id = idOne.First();
            vote.player2_id = idTwo.First();
            vote.player1_votes_qnt = 0;
            vote.player2_votes_qnt = 0;
            vote.vote_title = TitleTb.Text;
            App.db.Votes.Add(vote);
            App.db.SaveChanges();
            
        }
    }
}
