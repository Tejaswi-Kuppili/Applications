using System.Data.SqlClient;
using BusinessModels;

namespace RegistrationLoginDataLayer
{
    public class DataBaseOperations
    {

        public void AddInfoToDataBase(string username, string email, string encryptedPassword, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(Queries.InsertStatement, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@EmailID", email);
            command.Parameters.AddWithValue("@Password", encryptedPassword);
            command.ExecuteNonQuery();
        }
        public void UpdateInfoToDataBase(string username, string encryptedPassword, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(Queries.UpdateStatement, connection);
            command.Parameters.AddWithValue("@Password", encryptedPassword);
            command.Parameters.AddWithValue("@Username", username);
            command.ExecuteNonQuery();
        }
    }
}

