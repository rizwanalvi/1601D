<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ImportDataFromExcel.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="Button1" runat="server" Text="Import" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Import To Excel" />
    </div>
    </form>
</body>
</html>
