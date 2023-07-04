namespace BusinessModels
{
    /// <summary>
    /// All String Literals stored in a class to avoid complexity in the code
    /// </summary>
    public static class Literals
    {
        //Program.cs String Literals
        public static string options = "1. Register\n2. Login\n3. Exit";
        public static string enterChoice = "Enter your choice: ";
        public static string invalidMsg = "Invalid choice. Please try again.";

        //Authentication.cs String Literals
        public static string enterUsername = "Enter a username: ";
        public static string usernamealreadyexist = "Username already exists. Please choose a different username.";
        public static string enterPhoneNo = "Enter your phone number: ";
        public static string enterEmailID = "Enter your email ID: ";
        public static string enterPassword = "Enter password: ";
        public static string confirmPassword = "Confirm password: ";
        public static string loginSuccessfulMsg = "Login successful...\n,--.   ,--.      ,--.                             \r\n|  |   |  |,---. |  |,---. ,---. ,--,--,--.,---.  \r\n|  |.'.|  | .-. :|  | .--'| .-. ||        | .-. : \r\n|   ,'.   \\   --.|  \\ `--.' '-' '|  |  |  \\   --. \r\n'--'   '--'`----'`--'`---' `---' `--`--`--'`----'";
        public static string invalidUsernamePassword = "Invalid Username or password ! Please try again...";
        public static string afterLoginChoices = "\n1. Logout\n2. Exit\nEnter your choice: ";
        public static string loggedoutSuccessfulMsg = "You have been logged out !";
        public static string exitMsg = "Good Bye User !";

        // BALAuthentication.cs String Literals        
        public static string passwordNotMatched = "Password doesn't match !\nRe-enter the Password";
        public static string invalidDetails = "Invalid Details...\n1. The Username characters should contain atleast 3 characters utpo 15 characters\n2. Mobile Number format should be Indian with 10 digits\n3. Email ID format should be xxxxx@gmail.com\n4. Password Setting Policy:\n          a)Password should contain atleast one UpperCase and one LowerCase letter.\n          b)Password should be minimum of 5 characters.\n          c)Password should contain a special character\n          d)Password should contain atleast a number";
        public static string checkDetails = "Please check the details and re-enter";
        public static string regSuccessfulMsg = "Registration successful...You can now login with your credentials !";
    }
}
