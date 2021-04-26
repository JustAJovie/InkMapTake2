<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistSearch.aspx.cs" Inherits="inkMap.ArtistSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ArtistSearch</title>
</head>
<body>
    <form id="ArtistSearch" runat="server">
        <div>
            <asp:TextBox ID="txtLocationArtist" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLocationSearch" runat="server" Text="Button" OnClick="btnLocationSearch_Click" />
            <br />
            <asp:Label ID="lblArtistFName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblArtistLName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblCompany" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblCity" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
