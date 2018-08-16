<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppRepater.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <div class="bg-dark">
                    <h1>                    <asp:Label ID="Label1" runat="server" Text="LIST OF UNI"></asp:Label>
                    </h1>

                </div>
                </HeaderTemplate>
            <ItemTemplate>
                <div style="font-size:large;color:brown">
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("UN_NAME") %>'></asp:Label> </div>
            </ItemTemplate>
            <FooterTemplate>
                
            </FooterTemplate>
        </asp:Repeater>
       
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" OnSelectedIndexChanged="OnSelected">
            <Columns>
                <asp:BoundField DataField="UN_NAME" HeaderText="UNIVERSITY" />
            </Columns>
        </asp:GridView>
         <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:GridView ID="GridView2" runat="server" ></asp:GridView>
        <asp:DetailsView ID="DetailsView1" runat="server" width="100%"></asp:DetailsView>
    </div>
    </form>
</body>

</html>
