<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testRepater.aspx.cs" Inherits="WebApplication2.testRepater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <!-- Custom fonts for this template-->
  <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
  <!-- Page level plugin CSS-->
  <link href="vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">
  <!-- Custom styles for this template-->
  <link href="css/sb-admin.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                
            </HeaderTemplate>
            <ItemTemplate>
                <div>
             <asp:Label ID="Label1" runat="server" Text='<%# Eval("MNAME") %>'></asp:Label></span>
        
              </div>
            </ItemTemplate>
           <FooterTemplate>

               <div>
                       <asp:Label ID="Label2" runat="server" Text='<%# Eval(Repeater1.Items.Count.ToString()) %>' Visible="true"></asp:Label>
 
    </div>
    
           </FooterTemplate>
        </asp:Repeater>
       </div>
    </form>
</body>
</html>
