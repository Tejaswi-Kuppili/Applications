using BusinessModels;
using DataLayer;

namespace DataLayer
{
    internal class DALAuthentication: IDALAuthentication
    {
        /// <summary>
        /// Storing user data and displaying all the usernames
        /// </summary>
        /// <param name="username"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="emailID"></param>
        /// <param name="password"></param>
        public void AddData(User user)
        {
            DataSource.users.Add(user);
        }

        public void GetObj()
        {
            for(int i = 0; i< DataSource.users.Count; i++)
            {
                Console.WriteLine(DataSource.users[i].UserName);
            }
        }
        /// <summary>
        /// Method to check the username is already existing in our database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserExist(User user)
        {
            for (int i = 0; i < DataSource.users.Count; i++)
            {
                if (DataSource.users[i].UserName == user.UserName)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Method to check the username and password matches with the existing database details
        /// </summary>
        /// <param name="user"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsLoginExist(User user, string UserName, string Password)
        {
            User userExist = DataSource.users.Find(u => u.UserName == UserName && u.Password == Password);
            if (userExist != null)
            {
                return true;
            }
            return false;
        }
    }
}