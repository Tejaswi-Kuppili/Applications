<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Demo.ForgotPassword" %>


s<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 20px;
            background-color: #f9f9f9;
        }

        form {
            max-width: 400px;
            margin: 0 auto;
            padding: 20px;
            background-color: #ffffff;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        input[type="password"] {
            letter-spacing: 1px;
        }

        input[type="text"]:focus,
        input[type="password"]:focus {
            border-color: #007bff;
            outline: none;
        }

        #btnResetPassword {
            padding: 10px 15px;
            background-color: #007bff;
            color: #ffffff;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

        #btnResetPassword:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRedirectToPasswordReset" runat="server" Text="Redirect to Reset Page" OnClick="btnRedirectToPasswordReset_Click" />
            <%--<label for="txtEmailID">Enter Outlook Mail</label>
            <asp:TextBox ID="txtEmailID" runat="server"  />
            <br />
            <label for="txtEmailPassword">Enter Password</label>
            <asp:TextBox ID="txtEmailPassword" runat="server" TextMode ="Password" />
            <br />
            <asp:Button ID="btnResetPassword" runat="server" Text="Reset Password" OnClick="btnResetPassword_Click" />--%>
        </div>
    </form>
</body>
</html>
