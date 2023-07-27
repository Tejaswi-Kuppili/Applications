using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using BusinessModels;

namespace Demo
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        /// <summary>
        /// Method to redirect from forgot password hyperlink to reset password page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnRedirectToPasswordReset_Click(object  sender, EventArgs e)
        {
            Response.Redirect("PasswordReset.aspx");
        }
        ////Use-case: Method for sending reset link to email
        //protected void btnResetPassword_Click(object sender, EventArgs e)
        //{

        //    string email = txtEmailID.Text.Trim();
        //    string resetToken = GenerateResetToken();

        //    string connectionString = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(Queries.InsertStatement, connection);
        //        command.Parameters.AddWithValue("@Email", email);
        //        command.Parameters.AddWithValue("@Token", resetToken);
        //        command.Parameters.AddWithValue("@ExpirationTime", DateTime.Now.AddHours(1));
        //        command.ExecuteNonQuery();
        //    }
        //    string resetPageUrl = GetResetPageUrl(resetToken);
        //    SendResetEmail(email, resetToken, resetPageUrl);
        //    Response.Redirect("PasswordReset.aspx");
        //}
        //private string GenerateResetToken()
        //{
        //    return Guid.NewGuid().ToString();
        //}

        //private string GetResetPageUrl(string resetToken)
        //{
        //    Uri currentUrl = Request.Url;
        //    string baseUrl = currentUrl.GetLeftPart(UriPartial.Path);
        //    string resetPageUrl = baseUrl + "?token=" + resetToken;
        //    return resetPageUrl;
        //}

        //private void SendResetEmail(string userEmail, string resetToken, string resetPageUrl)
        //{
        //    string smtpUsername = "spam.143zzz@outlook.com";
        //    string smtpPassword = "SPAMtemp@420";
        //    string fromEmail = "spam.143zzz@outlook.com";
        //    string host = "smtp.office365.com";
        //    int port = 587;
        //    bool enableSsl = true;
        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress(fromEmail);
        //    mail.To.Add(userEmail);
        //    mail.Subject = Literals.MailSubject;
        //    mail.Body = Literals.MailBody;
        //    mail.Body += resetPageUrl + "?token=" + resetToken;
        //    SmtpClient smtpClient = new SmtpClient(host, port);   
        //    smtpClient.UseDefaultCredentials = false;
        //    smtpClient.EnableSsl = enableSsl;
        //    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
        //    smtpClient.EnableSsl = true;

        //    try
        //    {
        //        smtpClient.Send(mail);
        //        Response.Write(Literals.ResetLinkSent);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Response.Write(Literals.SendingResetEmailError);
        //    }
        //}
    }
}