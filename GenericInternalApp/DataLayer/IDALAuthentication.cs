using BusinessModels;

namespace DataLayer
{
    public interface IDALAuthentication
    {
        public void AddData(User user);
        public void GetObj();
        public bool IsUserExist(User user);
        public bool IsLoginExist(User user, string Username, string Password);
        public User GetDetails(string UserName, string Password);
    }
}
