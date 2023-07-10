using BusinessLayer;
using BusinessModels;

namespace ConsoleApp
{
    public class Authentication
    {
        public bool Register()
        {
            BALAuthentication balAuth = new BALAuthentication();
            User user = new User();
            Console.Write(Literals.enterUsername);
            user.UserName = Console.ReadLine();

            if (balAuth.IsUserExist(user))
            {
                Console.WriteLine(Literals.usernamealreadyexist);
                return false;
            }

            Console.Write(Literals.enterPhoneNo);
            user.MobileNumber = Console.ReadLine();
            Console.Write(Literals.enterEmailID);
            user.EmailID = Console.ReadLine();
            Console.Write(Literals.enterPassword);
            user.Password = Console.ReadLine();
            Console.Write(Literals.confirmPassword);
            string confirm_password = Console.ReadLine();

            while (user.Password != confirm_password)
            {
                Console.WriteLine(Literals.passwordNotMatched);
                string reEnterPassword = Console.ReadLine();
                confirm_password = reEnterPassword;
            }

            if (balAuth.CheckInputs(user))
            {
                Console.WriteLine(Literals.invalidDetails);
                Console.WriteLine(Literals.checkDetails);
                //Register();
                //return false;
            }
            else
            {
                Console.WriteLine(Literals.regSuccessfulMsg);
                balAuth.details(user);
            }
            return false;
        }
        public bool GetUser()
        {
            BALAuthentication balAuth = new BALAuthentication();
            User user = new User();
            Console.Write(Literals.enterUsername);
            string UserName = Console.ReadLine();
            Console.Write(Literals.enterPassword);
            string Password = Console.ReadLine();
            user = balAuth.GetUserDetails(user, UserName, Password);

            if(user != null)
            {
                Console.WriteLine("User Name: "+user.UserName+"\nEmail ID: "+user.EmailID+"\nMobile Number: "+user.MobileNumber);
            }
            else
            {
                Console.WriteLine(Literals.invalidUsernamePassword);
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