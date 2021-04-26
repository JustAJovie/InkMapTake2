<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewProfile.aspx.cs" Inherits="inkMap.viewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Artist Profile</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-3">
                    <asp:Image class="img-fluid rounded-circle float-left" ID="profileImage" runat="server" Width="175px" Height="250px"/>
                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
