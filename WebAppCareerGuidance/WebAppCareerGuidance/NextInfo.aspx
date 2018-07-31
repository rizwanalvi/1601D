<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NextInfo.aspx.cs" Inherits="WebAppCareerGuidance.NextInfo" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="pg3.aspx" method="post">
    <div>
        <asp:Label ID="LAB01" runat="server"></asp:Label><br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="124px">
            <asp:ListItem>BSC</asp:ListItem>
            <asp:ListItem>BBA</asp:ListItem>
            <asp:ListItem>BS</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
