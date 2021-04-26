<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistProfile.aspx.cs" Inherits="inkMap.ArtistProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmArtistProfile" runat="server">
        <div>
            <asp:TextBox ID="txtArt" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtCust" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtBody" runat="server"></asp:TextBox>

            <asp:Button ID="btnAddTest" runat="server" Text="Button" OnClick="btnAddTest_Click" />

            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
