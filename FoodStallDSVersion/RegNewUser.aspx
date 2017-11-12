<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegNewUser.aspx.cs" Inherits="FoodStallDSVersion.RegNewUser" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="w3-center w3-animate-top">New Account Registration</h1>
            <table class="w3-center">
                <tr>
                    <td style="width: 50%" class="w3-right-align">Username:</td>
                    <td class="w3-left-align">
                        <asp:TextBox ID="TextBoxUsername" CssClass="w3-input w3-border" runat="server" Width="30%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 50%" class="w3-right-align">Password: </td>
                    <td class="w3-left-align">
                        <asp:TextBox ID="TextBoxPw" CssClass="w3-input w3-border" runat="server" TextMode="Password" Width="30%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 50%" class="w3-right-align">Name: </td>
                    <td class="w3-left-align">
                        <asp:TextBox ID="TextBoxName" CssClass="w3-input w3-border" runat="server" Width="30%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 50%" class="w3-right-align">Address: </td>
                    <td style="width: 80%">
                        <asp:TextBox ID="TextBoxAddress" CssClass="w3-input w3-border" runat="server" width="635px"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div class="w3-center">
            <asp:Button ID="ButtonSubmit" CssClass="w3-btn w3-ripple w3-black" runat="server" Text="Register" OnClick="ButtonSubmit_Click" /></div>
        <br />
        <div class="w3-center w3-text-red"><asp:Label ID="LabelError" runat="server" Text=""></asp:Label></div>
    </form>
</body>
</html>