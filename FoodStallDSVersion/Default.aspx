<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FoodStallDSVersion.Default" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="w3-display-topmiddle">
    <div class="w3-text-red w3-justify">
    <h2 class="w3-animate-zoom">Institute of System Science</h2>
    </div>
    <h3 class="w3-center w3-animate-zoom">Food Ordering System</h3>
    <p class="w3-animate-zoom">Please <strong>login</strong> to start ordering...</p>
    <form id="form1" runat="server">
    <div>
    <p><strong>Username: </strong> 
        <asp:TextBox ID="TextBoxUser" CssClass="w3-input w3-border" runat="server" Value=""></asp:TextBox>
    </p>
    <p><strong>Password: </strong>
        <asp:TextBox ID="TextBoxPw" CssClass="w3-input w3-border" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnLogin" CssClass="w3-btn w3-ripple w3-hover-green w3-text-black" runat="server" Text="Login" OnClick="BtnLogin_Click" /> 
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder> 
        <asp:Button ID="BtnReg" CssClass="w3-btn w3-hover-red w3-text-black" runat="server" Text="New Account" OnClick="BtnReg_Click" />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder> 
        <asp:Button ID="ButtonSummary" CssClass="w3-btn w3-ripple w3-hover-purple w3-text-black" runat="server" Text="Order Summary" OnClick="ButtonSummary_Click" />
    </p>
    <p></p>
        </div>
        <div class="w3-center">
        <h5 class="w3-text-red"><asp:Label ID="LabelAlert" runat="server" Text=""></asp:Label></h5><br />
    </div>
    </form>
</body>
</html>