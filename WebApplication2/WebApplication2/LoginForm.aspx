<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" EnableEventValidation="false" Inherits="WebApplication2.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <!-- Custom fonts for this template-->
  <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
  <!-- Custom styles for this template-->
  <link href="css/sb-admin.css" rel="stylesheet">
</head>
<body class="bg-dark">
    <form id="form1" runat="server">
    <div>
   
  <div class="container">
    <div class="card card-login mx-auto mt-5">
      <div class="card-header">Login</div>
      <div class="card-body">
        <form>
          <div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
      <asp:TextBox ID="txtEmail" runat="server" class="form-control"  placeholder="Eamil"></asp:TextBox>
                      </div>
          <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
      <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"  placeholder="Password"></asp:TextBox>
            
          </div>
          <div class="form-group">
            <div class="form-check">
              <label class="form-check-label">
                <input class="form-check-input" type="checkbox"> Remember Password</label>
            </div>
              <div  class="form-group">
          <asp:Label ID="lblMessage" runat="server"  Class=""></asp:Label>
                  </div>
          </div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary btn-block" OnClick="OnLogin" />
         
        </form>
        <div class="text-center">
          <a class="d-block small mt-3" href="register.html">Register an Account</a>
          <a class="d-block small" href="forgot-password.html">Forgot Password?</a>
        </div>
      </div>
    </div>
  </div>
  <!-- Bootstrap core JavaScript-->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
  <!-- Core plugin JavaScript-->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    </div>
    </form>
</body>
</html>
