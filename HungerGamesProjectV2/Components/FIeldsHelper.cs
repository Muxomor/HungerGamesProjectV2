using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGamesProject.Components
{
    public static class FIeldsHelper
    {
        public static bool CheckField(string Text)
        {
            if(string.IsNullOrEmpty(Text))
            {
                return false;
            }
            else
            {
                return true;    
            }
        }

        public static bool CheckTwoFields(string text, string text1)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckPasswordConfirmation(string password, string confirmPassword)
        {
            if(string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                return false;
            }
            else
            {
                if(confirmPassword == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
