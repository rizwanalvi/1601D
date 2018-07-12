<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGridViewEx01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  OnRowEditing="OnRowEditing" >
            <Columns>
                <asp:BoundField DataField="StdID" HeaderText="Student ID" />
                <asp:BoundField DataField="StdName" HeaderText="Student Name" />
                <asp:CheckBoxField DataField="IsAttended" HeaderText="Attendance" />
                <asp:BoundField DataField="BatchNo" HeaderText="BatchID" SortExpression="BatchNo" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="OnUpdate" >Update</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OnCancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
                
                </asp:TemplateField>
            </Columns>
                </asp:GridView>
    
        <br />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
