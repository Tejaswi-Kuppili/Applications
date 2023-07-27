namespace BusinessModels
{
    /// <summary>
    /// All Queries stored in a class to avoid complexity in the code
    /// </summary>
    public static class Queries
    {
        public static string SelectStatement = "SELECT Password FROM UserInformation WHERE Username = @Username OR EmailID = @EmailID";
        public static string InsertStatement = "INSERT INTO PasswordResetTokens (Email, Token, ExpirationTime) VALUES (@Email, @Token, @ExpirationTime)";
        public static string UpdateStatement = "UPDATE USERDETAILS SET Password = @Password WHERE Username = @Username";
    }
}
