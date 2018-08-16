<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppRep.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataTextField ="UN_NAME"></asp:DropDownList>

        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <div><h1> NAME OF UNIVERSITY</h1></div>
            </HeaderTemplate>
            <ItemTemplate>
                <div>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("UN_NAME") %>'></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("UN_NAME") %>'></asp:TextBox>
                       <asp:DropDownList ID="DropDownList2" runat="server"  DataSource ='<%#  GetDataTable() %>'  DataTextField= "UN_NAME"></asp:DropDownList>
                </div>
            </ItemTemplate>
            
        </asp:Repeater>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" EnableViewState ="true">
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                          <asp:DropDownList ID="DropDownList3" runat="server" DataSource ='<%#  GetDataTable() %>'  DataTextField= "UN_NAME" >
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                       <asp:Label ID="Label1" runat="server" Text='<%# Eval("UN_NAME") %>'></asp:Label> 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update">Update</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
                    </asp:GridView>
    </div>
    </form>
</body>
</html>
