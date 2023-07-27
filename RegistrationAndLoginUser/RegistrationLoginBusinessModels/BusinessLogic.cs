using RegistrationLoginDataLayer;
using BusinessModels;

namespace RegistrationLoginBusinessLayer
{
    public class BusinessLogic
    {
        private readonly UserDataAccess userDataAccess;

        public BusinessLogic()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool AuthenticateUser(string username, string password)
        {
            BALAuthentication BALAuth = new BALAuthentication();
            string storedEncryptedPassword = userDataAccess.GetPasswordByUsername(username);
            string storedPassword = BALAuth.DecryptPassword(storedEncryptedPassword);
            if (storedPassword == password)
            {
                return true;
            }
            return false;
        }
    }
}
