<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createProfile.aspx.cs" Inherits="inkMap.createProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Artist Profile</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="frmCreateProfile" runat="server">
        <div>
            <div class="row" id="loginOptions">
                <div class="col-md-2"></div>
                <div class="col-md-1" id="uploadProfile">
                    <asp:Label ID="lblProfileImgFile" runat="server" Text="Upload File:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>

                </div>
                <div class="col-md-3">
                    <asp:FileUpload ID="uploadProfileImage" runat="server" />
                    <br />
                    <br />
                    <asp:Button ID="btnUploadFile" runat="server" Text="Button" OnClick="btnUploadFile_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
