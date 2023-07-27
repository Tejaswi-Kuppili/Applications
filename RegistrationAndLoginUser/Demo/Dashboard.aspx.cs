using RegistrationLoginBusinessLayer;
using System;

namespace Demo
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to implement the Dashboard page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRef_Click(object sender, EventArgs e)
        {
            var button = (System.Web.UI.WebControls.Button)sender;
            int buttonNumber = int.Parse(button.CommandArgument);

            switch ((MenuChoice)buttonNumber)
            {
                case MenuChoice.CSharpCorner:
                    Response.Redirect("https://www.c-sharpcorner.com/UploadFile/18fc30/understanding-the-basics-of-ado-net/#:~:text=ADO.NET%20is%20a%20set,to%20retrieve%20and%20manipulate%20data.");
                    break;
                case MenuChoice.Javatpoint:
                    Response.Redirect("https://www.javatpoint.com/ado-net-tutorial");
                    break;
                case MenuChoice.Microsoft:
                    Response.Redirect("https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/");
                    break;
                case MenuChoice.DotNetTutorials:
                    Response.Redirect("https://dotnettutorials.net/course/ado-net-tutorial-for-beginners-and-professionals/");
                    break;
                case MenuChoice.CompleteCSharpTutorial:
                    Response.Redirect("https://www.completecsharptutorial.com/ado-net/");
                    break;
                case MenuChoice.RedirectToPage:
                    Response.Redirect("Register.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}
