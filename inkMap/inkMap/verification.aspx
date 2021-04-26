<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verification.aspx.cs" Inherits="inkMap.verification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Verification</title>
     <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      
<div class="container-fluid" >
    <div id="verificationNote">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-m-4">
        <h1 class="homePageTitle">
            <asp:Label ID="lblVerificationTitle" runat="server" ></asp:Label></h1>
    </div>
        </div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
        <p><asp:Label ID="lblVerificationInfo" runat="server"></asp:Label></p>
    </div>
        </div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <asp:LinkButton ID="lbtnBeginSetUp" class="btn btn-lg btn-block btnredirect" runat="server" OnClick="lbtnBeginSetUp_Click" Text="Get Started"></asp:LinkButton>
            <asp:LinkButton ID="lbtnBackHome" class="btn btn-lg btn-block btnredirect" runat="server" OnClick="lbtnBackHome_Click" Text="Log In"></asp:LinkButton>
            </div>

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
