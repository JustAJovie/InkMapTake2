<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustProfileCreation.aspx.cs" Inherits="inkMap.CustProfileCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Profile Creation</title>
       <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="forms">
             <div class="row">
        <div class="col-md-4"></div>
        <div class="col-m-4">
        <h1 class="homePageTitle">
            <asp:Label ID="ProfileTitle" runat="server" Text="Profile Confirmation"></asp:Label></h1>
    </div>
                 </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-2">
              <asp:Label ID="lblUploadProfilePic" runat="server" Text="Upload Profile Picture:"></asp:Label>
                </div>
                <div class="col-md-2">
                  <asp:FileUpload ID="uploadProfilePic" runat="server" />

                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-2">
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <br />
                   <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>

                </div>

                 <div class="col-md-3">
                    <asp:Label ID="lblPrintFname" runat="server" ></asp:Label>
                    <br />
                    <br />
                   <asp:Label ID="lblPrintLname" runat="server" ></asp:Label>

                </div>

                 <div class="col-md-2">
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                    <br />
                    <br />
                   <asp:Label ID="lblPhone" runat="server" Text="Phone:"></asp:Label>

                </div>

                    <div class="col-md-3">
                    <asp:Label ID="lblPrintEmail" runat="server" ></asp:Label>
                    <br />
                    <br />
                   <asp:Label ID="lblPrintPhone" runat="server" ></asp:Label>

                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-9"></div>
                <div class="col-md-3">
                   <asp:LinkButton ID="lbtnEnterSite" class="btn btn-lg btn-block btnredirect" runat="server" Text="Get Started" OnClick="lbtnEnterSite_Click"></asp:LinkButton>

                </div>
            </div>
            
        </div>
    </form>
     <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

</body>
</html>
