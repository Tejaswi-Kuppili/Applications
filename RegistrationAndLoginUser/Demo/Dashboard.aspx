<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Demo.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f2f2f2;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .container {
            max-width: 600px;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        h2 {
            color: #007bff;
            text-align: center;
            margin-bottom: 20px;
            border-bottom: 1px solid #ccc;
            padding-bottom: 10px;
        }

        h3 {
            color: #555;
            text-align: center;
            margin-left: 20px;
            margin-bottom: 10px;
        }

        button {
            display: block;
            margin: 0 auto 10px;
            padding: 12px 18px;
            font-size: 16px;
            font-weight: bold;
            background-color: #28a745;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            transition: background-color 0.3s ease;
            width: 80%;
        }

        button:hover {
            background-color: #dc3545;
        }

        button:focus {
            outline: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to user dashboard !</h2>
            <h3>Best References to learn ADO.NET</h3>
            <p></p>
            <asp:Button ID="btnRef1" runat="server" Text="Basics of ADO.NET - C# Corner" OnClick="btnRef_Click" CommandArgument="1" />
            <br />
            <p></p>
            <asp:Button ID="btnRef2" runat="server" Text="Learn ADO.Net Tutorial - Javatpoint" OnClick="btnRef_Click" CommandArgument="2" />
            <br />
            <p></p>
            <asp:Button ID="btnRef3" runat="server" Text="ADO.NET - Microsoft" OnClick="btnRef_Click" CommandArgument="3" />
            <br />
            <p></p>
            <asp:Button ID="btnref4" runat="server" Text="ADO.NET Tutorial For Beginners and Professionals - Dot Net Tutorials" OnClick="btnRef_Click" CommandArgument="4" />
            <br />
            <p></p>
            <asp:Button ID="btnref5" runat="server" Text="Learn Complete ADO.NET (C#) - Complete C# Tutorial" OnClick="btnRef_Click" CommandArgument="5" />
            <br />
            <p></p>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnRef_Click" CommandArgument="6" />
        </div>
    </form>
</body>
</html>
