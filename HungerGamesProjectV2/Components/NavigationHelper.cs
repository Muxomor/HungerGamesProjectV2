using HungerGamesProjectV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGamesProject.Components
{
    public static class NavigationHelper
    {
        public static void NavigateMainWindowFrameByRoute(string route)
        {
            App.mainWindowFrame.NavigationService.Navigate(new Uri(route, UriKind.Relative));
        }

        public static void NavigateAfterLogin(bool isAdm)
        {
            if (isAdm)
            {
                //тут пока заглушка
                //TODO: страница для админа, или дополнительная логика для отображения элментов на главной странице
                App.mainWindowFrame.NavigationService.Navigate(new Uri("Pages/UsersMainPage.xaml", UriKind.Relative));

            }
            else
            {
                
                App.mainWindowFrame.NavigationService.Navigate(new Uri("Pages/UsersMainPage.xaml", UriKind.Relative));
            }

        }

        //этот метод тут чтобы навигироваться до страницы авторизации(иными словами этот метод нужно вызывать при выходе из аккаунита)
        public static void NavigationToLogin()
        {
            App.mainWindowFrame.NavigationService.Navigate(new Uri("Pages/LoginPage.xaml", UriKind.Relative));
        }

        public static void NavigateUsersPagesByRoute(string route)
        {
            App.UserPageFrame.NavigationService.Navigate(new Uri(route, UriKind.Relative));
        }
    }
}
