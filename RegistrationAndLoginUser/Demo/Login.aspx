<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Demo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        /* Container to group all elements */
        .container {
            max-width: 400px;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        /* Heading styles */
        h2 {
            font-size: 20px;
            margin-bottom: 20px;
            color: crimson;
            text-align: center;
        }

        /* Label styles */
        label {
            font-weight: bold;
            font-size: 12px;
        }

        /* Input styles */
        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        /* Button styles */
        #btnLogin {
            margin: 20px auto 0;
            width: 100%;
            padding: 10px 20px;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

            #btnLogin:hover {
                background-color: #45a049;
            }
        #btnRegister{
            margin: 20px auto 0;
            width: 80%;
            padding: 10px 20px;
            
            
            border: none;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        #linkForgotPassword {
            text-align: right;
            font-size:small;
            display: block;
            margin-top: 10px;
            color: #007BFF;
            text-decoration: underline;
            text-decoration-color: #007BFF; 
        }

            #linkForgotPassword:hover {
                text-decoration: none;
            }
        .error-message {
            color: red;
            font-size: 14px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to login page!</h2>
            <label for="txtUsername">Username</label>
            <asp:TextBox ID="txtUsername" runat="server" />
            <br />
            <label for="txtLoginPassword">Password</label>
            <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password" />
            <br />
            <asp:label ID="txtErrorMessage" runat="server" CssClass="error-message" Visible="false" />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:HyperLink ID="linkForgotPassword" runat="server" Text="Forgot Password?" NavigateUrl="ForgotPassword.apsx"></asp:HyperLink>
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Back to Registration" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
