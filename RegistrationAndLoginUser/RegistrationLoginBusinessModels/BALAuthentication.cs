using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModels;
using RegistrationLoginDataLayer;
namespace RegistrationLoginBusinessLayer
{
    public class BALAuthentication
    {
        public bool IsPasswordMatch(string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                return false;
            }
            return true;
        }
        public string EncryptPassword(string password)
        {
            int Key = 3;
            char[] charArray = password.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char originalChar = charArray[i];
                char shiftedChar = (char)(originalChar + Key);
                if (char.IsLetter(originalChar))
                {
                    char baseChar = char.IsLower(originalChar) ? 'a' : 'A';
                    shiftedChar = (char)(((shiftedChar - baseChar) % 26 + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(originalChar))
                {
                    shiftedChar = (char)(((shiftedChar - '0') % 10 + 10) % 10 + '0');
                }
                charArray[i] = shiftedChar;
            }
            return new string(charArray);
        }

        public string DecryptPassword(string encryptedPassword)
        {
            int Key = 3;
            int decryptionKey = -Key;
            char[] charArray = encryptedPassword.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char encryptedChar = charArray[i];
                char decryptedChar = (char)(encryptedChar + decryptionKey);
                if (char.IsLetter(encryptedChar))
                {
                    char baseChar = char.IsLower(encryptedChar) ? 'a' : 'A';
                    decryptedChar = (char)(((decryptedChar - baseChar) % 26 + 26) % 26 + baseChar);
                }
                else if (char.IsDigit(encryptedChar))
                {
                    decryptedChar = (char)(((decryptedChar - '0') % 10 + 10) % 10 + '0');
                }
                charArray[i] = decryptedChar;
            }
            return new string(charArray);
        }
        public void InsertUserInfo(string username, string email, string encryptedPassword, SqlConnection connection)
        {
            DataBaseOperations dataBaseOperations = new DataBaseOperations();
            dataBaseOperations.AddInfoToDataBase(username, email, encryptedPassword, connection);
        }
        public string CheckWithCredentials(string username, string password, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT Password FROM USERDETAILS WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string storedEncryptedPassword = reader["Password"].ToString();
                    string storedPassword = DecryptPassword(storedEncryptedPassword);
                    return storedPassword;
                }
                else
                {
                    return Literals.InvalidDetails;
                }
            }
        }
        public void UpdateInfo(string username, string encryptedPassword, SqlConnection connection)
        {
            DataBaseOperations dataBaseOperations = new DataBaseOperations();
            dataBaseOperations.UpdateInfoToDataBase(username, encryptedPassword, connection);
        }
    }
}
