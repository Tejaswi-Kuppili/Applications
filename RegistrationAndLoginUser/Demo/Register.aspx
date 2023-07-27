<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Demo.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register or Sign in</title>
    <style>
        body {
            font-family: 'Times New Roman', Times, serif, sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f2f2f2;
        }

        .container {
            max-width: 400px;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h2 {
            color: #dc3545;
            text-align:center;
            margin-bottom: 20px;
            border-bottom: 1px solid #ccc;
            padding-bottom: 10px;
        }

        label {
            font-weight: bold;
        }

        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        #btnRegister {
            display: block;
            width: 100%;
            padding: 12px 18px;
            font-size: 16px;
            font-weight: bold;
            background-color: #28a745;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin-top: 10px;
            transition: background-color 0.3s ease;
        }

        #btnAlreadyExistingUser {
            display: block;
            width: 100%;
            padding: 12px 18px;
            font-size: 16px;
            font-weight: bold;
            background-color: #007BFF;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin-top: 10px;
            transition: background-color 0.3s ease;
        }

        button:hover {
            background-color: #0056b3;
        }

        button:focus {
            outline: none;
        }

        p {
            text-align: center;
            margin: 10px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration</h2>
            <label for="txtUsername">Username </label>
            <asp:TextBox ID="txtUsername" runat="server" />
            <br />
            <br />
            <label for="txtEmail">Email ID </label>
            <asp:TextBox ID="txtEmail" runat="server" />
            <br />
            <br />
            <label for="txtPassword">Password </label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <br />
            <br />
            <label for="txtConfirmPassword">Confirm Password </label>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <br />
            <br />
            <asp:label ID="txtErrorMessage" runat="server" CssClass="error-message" Visible="false" />
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Create a new account" OnClick="btnRegister_Click" />
            <p>--------- OR ----------</p>
            <asp:Button ID="btnAlreadyExistingUser" runat="server" Text="Have an account ? Login" OnClick="btnAlreadyExist_Click" />
        </div>
    </form>
</body>
</html>
