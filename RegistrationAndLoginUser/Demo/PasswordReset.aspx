<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Application.ForgotPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
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

        .container {
            max-width: 400px;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        p {
            font-size: 24px;
            font-weight: bold;
            color: crimson;
            text-align: center;
        }

        label {
            font-weight: bold;
            font-size: 12px;
        }

        .text-input,
        .password-input {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        input[type="submit"] {
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

            input[type="submit"]:hover {
                background-color: #45a049;
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
        <div class="container">
            <p>Reset Password</p>
            <label for="txtUsername">UserName</label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="text-input" />
            <br />

            <label for="txtPwd">Create a new Password</label>
            <asp:TextBox ID="txtPwd" runat="server" CssClass="password-input" TextMode="Password" />
            <br />

            <label for="txtConfirmpwd">Confirm Password</label>
            <asp:TextBox ID="txtConfirmpwd" runat="server" CssClass="password-input" TextMode="Password" />
            <br />
            
            <asp:Label ID="lblMessage" runat="server" CssClass="error-message" Visible="false" />
            <br />

            <asp:Button ID="btnlogin" runat="server" Text="Update Password" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
