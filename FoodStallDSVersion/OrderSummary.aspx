<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="FoodStallDSVersion.OrderSummary" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="w3-display-topmiddle">
    <div class="w3-center">
        <h1 class="w3-animate-zoom w3-text-black w3-light-grey">Summary of Order as of <asp:Label ID="LabelDate" runat="server" Text=""></asp:Label></h1>
    </div>
    <p></p>
    <form id="form1" runat="server">
    <div class="w3-responsive">
        <asp:GridView ID="GridView1" CssClass="w3-table-all w3-justify w3-centered w3-hoverable w3-light-blue w3-bordered w3-border-grey" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>