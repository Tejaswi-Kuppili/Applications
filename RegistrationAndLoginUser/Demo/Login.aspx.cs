using System;
using BusinessModels;
using RegistrationLoginBusinessLayer;

namespace Demo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to implement the Login Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessLogic BusinessLogic = new BusinessLogic();
            string username = txtUsername.Text.Trim();
            string password = txtLoginPassword.Text;

            //Authenticates the username and password
            if (BusinessLogic.AuthenticateUser(username, password))
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                txtErrorMessage.Text = Literals.InvalidDetails;
                txtErrorMessage.Visible = true;
            }
        }
        /// <summary>
        /// Button to implement the Register button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
        /// <summary>
        /// Method to show the error message
        /// </summary>
        /// <param name="message"></param>
        private void ShowErrorMessage(string message)
        {
            txtErrorMessage.Text = message;
            txtErrorMessage.Visible = true;
        }
    }
}