using BusinessModels;

namespace ConsoleApp
{
    public class Program
    {
        enum MenuChoice
        {
            Register = 1,
            Login = 2,
            GetUserDetails = 3,
            Exit = 4
        };
        public static void Main(string[] args)
        {
            Authentication authenticate = new Authentication();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(Literals.options);
                Console.Write(Literals.enterChoice);
                int choice = Convert.ToInt32(Console.ReadLine());
                switch((MenuChoice)choice)
                {
                    case MenuChoice.Register:
                        authenticate.Register();
                        break;
                    case MenuChoice.Login:
                        authenticate.Login();
                        break;
                    case MenuChoice.GetUserDetails:
                        authenticate.GetUser();
                        break;
                    case MenuChoice.Exit:
                        authenticate.Exit();
                        break;
                    default:
                        Console.WriteLine(Literals.invalidMsg);
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}