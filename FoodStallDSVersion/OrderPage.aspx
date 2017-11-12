<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="FoodStallDSVersion.OrderPage" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style6 {
            width: 463px;
        }
    </style>
</head>
<body class="w3-display-topmiddle">
    <form id="form1" runat="server">
        <div class="w3-center">
            <h1 class="w3-animate-zoom"><strong>Order Page</strong></h1>
            <h4 class="w3-animate-zoom">Make your choice...</h4>
        </div>
        <div class="w3-container">
            <table class="w3-container">
                <tr>
                    <th class="w3-cell-top">Food Choice:
        <asp:DropDownList ID="DdlFoodChoice" runat="server" DataTextField="dishName" DataValueField="dishName" DataSourceID="SqlDataSource1"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:changsiangfooddbConnectionString %>" SelectCommand="SELECT [dishName] FROM [Food Dishes]"></asp:SqlDataSource>
                        Size Option:
            <asp:DropDownList ID="DddlSizeOption" runat="server" DataTextField="sizeOption" DataValueField="sizeOption" DataSourceID="SqlDataSource2"></asp:DropDownList>                    
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:changsiangfooddbConnectionString %>" SelectCommand="SELECT [sizeOption] FROM [Sizes]"></asp:SqlDataSource>
                    </th>
                    <th class="w3-left-align">Spice Option:
                        <asp:CheckBoxList ID="CheckBoxSpice" runat="server">
                            <asp:ListItem>Chilli</asp:ListItem>
                            <asp:ListItem>Pepper</asp:ListItem>
                            <asp:ListItem>More Salt</asp:ListItem>
                            <asp:ListItem>Less Salt</asp:ListItem>
                        </asp:CheckBoxList>
                    </th>
                    <tr>
                        <td colspan="2" class="w3-center">
                            <asp:Button ID="Button1" CssClass="w3-btn w3-ripple w3-text-black w3-hover-blue w3-container w3-border" runat="server" Text="Calculate Price" OnClick="Button1_Click" />
                            Price: 
                    <asp:Label ID="LabelPrice" Style="font-weight: bold" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
            </table>
            <table>
                <tr>
                    <th class="auto-style6">Customer and Delivery Information</th>
            </table>
        </div>
        <div>
            <asp:TextBox ID="TxtBoxName" CssClass="w3-input w3-border" runat="server" Enabled="False" Width="100%"></asp:TextBox>
            <br />

            <asp:TextBox ID="txtBoxStreetName" CssClass="w3-input w3-border" runat="server" Width="100%" placeholder="Address 1"></asp:TextBox>
            <br />

            <asp:TextBox ID="TxtBoxUnit" CssClass="w3-input w3-border" runat="server" Width="100%" Placeholder="Address 2"></asp:TextBox>
            <br />

            <asp:TextBox ID="TxtBoxPostal" CssClass="w3-input w3-border" runat="server" Width="50%" Placeholder="Postal Code"></asp:TextBox>
            <div class="w3-center">
                <asp:Button ID="BtnSubmit" CssClass="w3-btn w3-ripple w3-text-black w3-hover-green w3-container w3-border" Font-Bold="true" runat="server" Text="Submit Order" OnClick="BtnSubmit_Click" />
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <asp:Button ID="BtnDiscard" CssClass="w3-btn w3-ripple w3-text-black w3-hover-red w3-container w3-border" Font-Bold="true" runat="server" Text="Discard Order" OnClick="BtnDiscard_Click" />
                <br />
                <asp:Label ID="LabelStatus" CssClass="w3-text-red" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>