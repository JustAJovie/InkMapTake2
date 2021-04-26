<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomerSidenavMenu.ascx.cs" Inherits="inkMap.CustomerSidenavMenu" %>
   <div class="sidenav">
       <asp:Image ID="imgprofileImage" runat="server" Width="200px" Height="150px" />
                <br />
       <asp:Label ID="lblCustomerName" runat="server"></asp:Label>
       <br />
       <br />
       <asp:LinkButton ID="lbtnSearch" runat="server">Search Aritists</asp:LinkButton>
        <br />
       <asp:LinkButton ID="lbtnSave" runat="server">Saved Artists</asp:LinkButton>
       <br />
       <asp:LinkButton ID="lbtnUpcoming" runat="server">Upcoming Appointments</asp:LinkButton>

            </div>