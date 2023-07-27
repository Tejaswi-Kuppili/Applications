using System.Configuration;
using System.Data.SqlClient;
using BusinessModels;

namespace RegistrationLoginDataLayer
{
    public class UserDataAccess
    {
        public string GetPasswordByUsername(string username)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Queries.SelectStatement, connection);
                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Password"].ToString();
                    }
                }
            }
            return null;
        } 
    }
}
