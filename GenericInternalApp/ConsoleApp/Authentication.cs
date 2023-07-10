using BusinessLayer;
using BusinessModels;

namespace ConsoleApp
{
    public class Authentication
    {
        public bool Register()
        {
            BALAuthentication balAuth = new BALAuthentication();
            User businessUser = new User();

            Console.Write(Literals.enterUsername);

            businessUser.UserName = Console.ReadLine();

            if (balAuth.IsUserExist(businessUser))
            {
                Console.WriteLine(Literals.usernamealreadyexist);
                return false;
            }

            Console.Write(Literals.enterPhoneNo);
            businessUser.MobileNumber = Console.ReadLine();
            Console.Write(Literals.enterEmailID);
            businessUser.EmailID = Console.ReadLine();
            Console.Write(Literals.enterPassword);
            businessUser.Password = Console.ReadLine();
            Console.Write(Literals.confirmPassword);
            string confirm_password = Console.ReadLine();
            while (businessUser.Password != confirm_password)
            {
                Console.WriteLine(Literals.passwordNotMatched);
                string reEnterPassword = Console.ReadLine();
                confirm_password = reEnterPassword;
            }
            if (balAuth.CheckInputs(businessUser))
            {
                Console.WriteLine(Literals.invalidDetails);
                Console.WriteLine(Literals.checkDetails);
                //Register();
                //return false;
            }
            else
            {
                Console.WriteLine(Literals.regSuccessfulMsg);
                balAuth.details(businessUser);
            }
            return false;
        }
        public bool Login()
        {
            BALAuthentication balAuth = new BALAuthentication();
            User user = new User();
            Console.Write(Literals.enterUsername);
            string UserName = Console.ReadLine();
            Console.Write(Literals.enterPassword);
            string Password = Console.ReadLine();

            if (balAuth.IsExist(user, UserName, Password))
            {
                Console.WriteLine(Literals.loginSuccessfulMsg);
            }
            else
            {
                Console.WriteLine(Literals.invalidUsernamePassword);
                return false;
            }

            Console.WriteLine(Literals.afterLoginChoices);
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Logout();
            }
            else if (ch == 2)
            {
                Exit();
            }
            else
            {
                Console.WriteLine(Literals.invalidMsg);
            }
            return false;
        }
        public bool Logout()
        {
            Console.WriteLine(Literals.loggedoutSuccessfulMsg);
            return false;
        }
        public bool Exit()
        {
            Console.WriteLine(Literals.exitMsg);
            Environment.Exit(0);
            return false;
        }
    }
}