using BusinessModels;
using RegistrationLoginBusinessLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Application
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BALAuthentication balAuth = new BALAuthentication();
            string username = txtUsername.Text.Trim().ToLower();
            string newPassword = txtPwd.Text;
            string confirmPassword = txtConfirmpwd.Text;

            if (balAuth.IsPasswordMatch(newPassword, confirmPassword))
            {
                return;
            }
            else
            {
                Response.Write(Literals.PasswordsMismatch);
            }

            string encryptedPassword = balAuth.EncryptPassword(newPassword);

            try
            {
                string ConnectionStr = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(ConnectionStr))
                {
                    connection.Open();
                    balAuth.UpdateInfo(username, encryptedPassword, connection);
                }
                Response.Redirect("Login.aspx");
            }
            catch (SqlException ex)
            {
                lblMessage.Text = Literals.DatabaseError + ex.Message;
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblMessage.Text = Literals.UnexpectedError + ex.Message;
                lblMessage.Visible = true;
            }
        }
    }
}


































/*using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class PasswordReset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, string resetToken)
        {
            //string resetToken = Request.QueryString["token"];
            string connectionString = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Email, ExpirationTime FROM PasswordResetTokens WHERE Token = @Token", connection);
                command.Parameters.AddWithValue("@Token", resetToken);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string email = reader["Email"].ToString();
                        DateTime expirationTime = Convert.ToDateTime(reader["ExpirationTime"]);

                        // Verify if the token is valid and has not expired
                        if (DateTime.Now <= expirationTime)
                        {
                            // Token is valid and not expired, allow the user to reset the password
                            // You may also want to validate the token against other criteria (e.g., email matching)
                            // Display the password reset form
                        }
                        else
                        {
                            // Token is invalid or expired
                            Response.Write("Password reset link is invalid or expired.");
                        }
                    }
                    else
                    {
                        // Token not found
                        Response.Write("Password reset link is invalid or expired.");
                    }
                }
            }
        }
        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string resetToken = Request.QueryString["token"];
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if(newPassword != confirmPassword)
            {
                Response.Write("Passowrds do not match !");
                return;
            }

            string connectionString = "Data Source=192.168.0.30; Initial Catalog=emp243UserDB; User ID=User5; Password=CDev005#8;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE UserInformation SET Password = @Password WHERE Email IN (SELECT Email FROM PasswordResetTokens WHERE Token = @Token)", connection);
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Token", resetToken);
                command.ExecuteNonQuery();
            }
        }
    }
}*/