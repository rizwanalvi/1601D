<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGrid.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" dd>
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="OnUpdate">Update</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OnCancel">Cancel</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="StdID" HeaderText="Student ID" ReadOnly="true" />
                <asp:BoundField DataField="StdName" HeaderText="Name" />
                <asp:BoundField DataField="BatchNo" HeaderText="Batch No" />
                <asp:CheckBoxField DataField="IsAttended" HeaderText="Attendance" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
