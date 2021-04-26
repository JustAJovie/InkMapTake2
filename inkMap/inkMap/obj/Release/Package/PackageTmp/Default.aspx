<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="inkMap.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>InkMap</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />

    <link href="assets/css/global.css" rel="stylesheet" />
</head>
<body>
    <form id="frmHomepage" runat="server">
        <div class="container-fluid">
            <div>
                <nav class="navbar navbar-expand-lg">
                    <a class="navbar-brand" href="#">InkMap</a>
                    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                        <div class="navbar-nav">
                            <a class="nav-item nav-link" href="#">About</a>
                            <a class="nav-item nav-link" href="#">Contact</a>
                            <a class="nav-item nav-link" href="#">Sign in</a>
                        </div>
                    </div>
                </nav>
            </div>


            <div class="row" id="loginOptions">

                <div class="col-md-5" id="LandingMenu">
                    <h1 class="homePageTitle">Getting Ink Just Got Easier</h1>
                    <br />
                    <a class="btn btn-lg btn-block" id="signIn" onclick="showSignInContent()">Sign In</a>
                    <a class="btn btn-lg btn-block" id="createAccount" onclick="showCustomerAccountModule()">Create Account</a>
                    <a class="btn btn-lg btn-block" id="registerArtist" onclick="showArtistAccountModule()">Register As an Artist</a>
                    <asp:Label ID="lblStoreName" runat="server" Text=""></asp:Label>

                </div>

                <div class="col-md-6" id="signInModule">
                    <div id="signInContent">
                        <h1 class="homePageTitle">Sign In</h1>
                        <br />
                        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtEmail" runat="server" Width="386px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtPass" runat="server" Width="387px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:LinkButton ID="lnkbtnforgotpass" runat="server">Forgot Password</asp:LinkButton>
                        <br />
                        <asp:LinkButton id="saveLogIn" runat="server" onclick="saveLogIn_Click">Save Log In</asp:LinkButton>
                        <br />
                        <asp:LinkButton id="deleteLogIn" runat="server" onclick="deleteLogIn_Click">Delete Log In</asp:LinkButton>

                        <br />
                        <br />
                        <asp:LinkButton ID="lbtnSignIn" class="btn btn-lg  btn-secondary" runat="server">Sign In</asp:LinkButton>
                         &nbsp;&nbsp;
                         <a class="btn btn-lg btn-light" onclick="showLandingMenu()">&nbsp;Cancel</a>
                    </div>
                </div>

            </div>

            <div class="row" id="createAccountTitle">
                <div class="col-md-2"></div>
                <h1 class="homePageTitle" >Create Account</h1>
            </div>
            <div class="row" id="createAccountModule">

                <div class="col-md-2"></div>
                <div class="col-md-1">
                    <br />
                    <asp:Label ID="lblCutomerFName" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblCustomerEmail" runat="server" Text="Email: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblCustomerPassword" runat="server" Text="Password: "></asp:Label>

                </div>
                <div class="col-md-3">
                    <br />
                    <asp:TextBox ID="txtCustomerFName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtCustomerPassword" runat="server"></asp:TextBox>


                </div>

                <div class="col-md-1">
                    <br />
                    <asp:Label ID="lblCustomerLName" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblCustomerPhone" runat="server" Text="Phone: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblConfirmPass" runat="server" Text="Confirm Password: "></asp:Label>

                </div>
                <div class="col-md-3">
                    <br />
                    <asp:TextBox ID="txtCustomerLName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtCustomerPhone" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtConfirmPass" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:LinkButton ID="lbtnCreateAccountCustomer" class="btn btn-lg btn-block btn-secondary" runat="server" OnClick="lbtnCreateAccountCustomer_Click">Create Account</asp:LinkButton>

                    <a class="btn btn-lg btn-block btn-light" onclick="showLandingMenu()">Cancel</a>

                </div>
            </div>

            <div class="row" id="createArtistTitle">
                <div class="col-md-2"></div>
                <h1 class="homePageTitle" >Artist Registration</h1>
            </div>
            <div class="row" id="createArtistModule">

                <div class="col-md-2"></div>
                <div class="col-md-1">
                    <br />
                    <asp:Label ID="lblArtistFName" runat="server" Text="First Name:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblArtistEmail" runat="server" Text="Email: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblArtistPass" runat="server" Text="Password: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblArtistCert" runat="server" Text="Certification: "></asp:Label>

                </div>
                <div class="col-md-3">
                    <br />
                    <asp:TextBox ID="txtArtistFName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistEmail" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistPass" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistCert" runat="server"></asp:TextBox>

                </div>

                <div class="col-md-1">
                    <br />
                    <asp:Label ID="lblArtistLName" runat="server" Text="Last Name:"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblArtistPhone" runat="server" Text="Phone: "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblArtistConfirm" runat="server" Text="Confirm Password: "></asp:Label>
                     <br />
                    <br />
                    <asp:Label ID="lblArtistCompany" runat="server" Text="Company: "></asp:Label>

                </div>
                <div class="col-md-3">
                    <br />
                    <asp:TextBox ID="txtArtistLName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistPhone" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistConfirm" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="txtArtistCompany" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:LinkButton ID="lbtnCreateAccountArtist" class="btn btn-lg btn-block btn-secondary" runat="server">Create Account</asp:LinkButton>

                    <a class="btn btn-lg btn-block btn-light" onclick="showLandingMenu()">Cancel</a>

                </div>
            </div>
        </div>
        
    </form>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="assets/js/homePage.js"></script>
</body>
</html>
