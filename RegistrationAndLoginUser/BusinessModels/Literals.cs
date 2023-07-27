using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
using System.Security.Policy;

namespace BusinessModels
{
    /// <summary>
    /// All String Literals stored in a class to avoid complexity in the code
    /// </summary>
    public static class Literals
    {
        public static string PasswordsMismatch = "Passwords do not match!";
        public static string InvalidDetails= "Invalid Details...\n1.The Username characters should contain atleast 3 characters utpo 15 characters\n2.Email ID format should be xxxxx@gmail.com\n3.Password Setting Policy:\n a)Password should contain atleast one UpperCase and one LowerCase letter.\n b)Password should be minimum of 5 characters.\n c)Password should contain a special character\n d)Password should contain atleast a number";
        public static string DatabaseError = "An error occurred in the database";
        public static string UnexpectedError = "An unexpected error occured";
        public static string MailSubject = "Password Reset Link";
        public static string MailBody = "Click the link below to reset your password:\n\n";
        public static string ResetLinkSent = "Password reset link has been sent to your email";
        public static string SendingResetEmailError = "An error occurred while sending the password reset email";
    }
}
