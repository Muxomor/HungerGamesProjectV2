﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using HungerGamesProjectV2.Components.DB;

namespace HungerGamesProjectV2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HungerGamesEntities db = new HungerGamesEntities();
        public static Frame mainWindowFrame;
        public static Frame UserPageFrame;
    }
}
