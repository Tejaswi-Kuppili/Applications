using System;
using System.Text.RegularExpressions;
using BusinessModels;
using RegistrationLoginDataLayer;

namespace RegistrationLoginBusinessModels
{
    public class BALValidations
    {
        /// <summary>
        /// Method to check whether the username is valid with the correct format
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsValidUsername(string username)
        {
            char first = username[0];

            if (Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,15}$"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method to check the Email ID  entered is valid with correct format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method to check the password entered is valid with correct password setting policy
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidPassword(string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{5,}$"))
            {
                return true;
            }
            return false;
        }
        
    }
}
