using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using RegistrationLoginBusinessLayer;
using BusinessModels;
using RegistrationLoginBusinessModels;
using System.Web.Services.Description;

namespace Demo
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to implement Register Button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            BALAuthentication balAuth = new BALAuthentication();
            BALValidations valid = new BALValidations();

            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (valid.IsValidUsername(username) && valid.IsValidEmail(email) && valid.IsValidPassword(password))
            {
                if (!(balAuth.IsPasswordMatch(password, confirmPassword)))
                {
                    return;
                }
                else
                {
                    Response.Write(Literals.PasswordsMismatch);
                }
            }
            else
            {
                txtErrorMessage.Text = Literals.InvalidDetails;
                txtErrorMessage.Visible = true;
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO UserInformation (Username, EmailID, Password) VALUES (@Username, @EmailID, @Password)", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@EmailID", email);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
            }
            Response.Redirect("RegistrationSuccess.aspx");
        }
        /// <summary>
        /// Method to implement the functionality for sign in user
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        protected void btnAlreadyExist_Click(object obj, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
