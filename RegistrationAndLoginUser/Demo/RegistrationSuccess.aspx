<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationSuccess.aspx.cs" Inherits="Demo.RegistrationSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Successful</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f1f1f1;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        #container {
            text-align: center;
            padding: 40px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: #ffffff;
        }

        h3 {
            text-align:center;
            color: #00b894;
        }
        p{
            text-align:center;
        }

        #successIcon {
            font-size: 60px;
            color: #00b894;
            margin-bottom: 20px;
        }

        #btnNavLogin {
            padding: 12px 30px;
            align-content:center;
            font-size: 16px;
            background-color: #00b894;
            color: #ffffff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
            margin-left: 145px;
        }

        #btnNavLogin:hover {
            background-color: #00a383;
        }
        #container {
            text-align: center;
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Registered with your account !!!</h3>
            <p>Congratulations, you have successfully registered an account.</p>
            <p>You can now login to your account using the credentials you provided.</p>
            <asp:Button ID="btnNavLogin" runat="server" Text="Go to Login Page" OnClick="btnNavLogin_Click" />
        </div>
    </form>
</body>
</html>
