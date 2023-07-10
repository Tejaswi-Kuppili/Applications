using BusinessModels;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Checks whether the user details are stored and also checks if they are valid or not 
    /// </summary>
    public class BALAuthentication
    {
        DataFactory dataFactory = new DataFactory();
        /// <summary>
        /// Method to check whether the password and confirm password are matched or not
        /// </summary>
        /// <param name="user"></param>
        /// <param name="confirm_password"></param>
        /// <returns></returns>
        public bool CheckInputs(User user)
        {
            BALValidations valid = new BALValidations();
            if (!(valid.IsValidUsername(user.UserName) && valid.IsValidMobile(user.MobileNumber) && valid.IsValidEmail(user.EmailID) && valid.IsValidPassword(user.Password)))
            {
                return true;
            }
            return false;

        }   
        /// <summary>
        /// Method to check the username is already existing in our database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserExist(User user)
        {
            IDALAuthentication IDALAuth = dataFactory.GetObj();
            return IDALAuth.IsUserExist(user);
        }
        /// <summary>
        /// Method to check the username and password matches with the existing database details
        /// </summary>
        /// <param name="user"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsExist(User user, string username, string password)
        {
            IDALAuthentication IDALAuth = dataFactory.GetObj();
            return IDALAuth.IsLoginExist(user, username, password);
        }
        public void details(User user)
        {
            IDALAuthentication IDALAuth = dataFactory.GetObj();
            IDALAuth.AddData(user);
        }
        public User GetUserDetails(User user, string UserName, string Password)
        {
            IDALAuthentication IDALAuth = dataFactory.GetObj();
            return IDALAuth.GetDetails(UserName, Password);
        }
    }
}