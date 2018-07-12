<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppEx01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" width="100%" >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="StdName" HeaderText="StdName" SortExpression="StdName" />
                <asp:BoundField DataField="TimeSlot" HeaderText="TimeSlot" SortExpression="TimeSlot" />
                <asp:BoundField DataField="BatchID" HeaderText="BatchID" SortExpression="BatchID" />
                <asp:CheckBoxField DataField="Attended" HeaderText="Attended" SortExpression="Attended" />
                 <asp:TemplateField>
        <ItemTemplate>
            <asp:LinkButton Text="Edit" runat="server" CommandName="Edit" />
        </ItemTemplate>
        <EditItemTemplate>
            <asp:LinkButton Text="Update" runat="server" OnClick="OnUpdate" />
            <asp:LinkButton Text="Cancel" runat="server" OnClick="OnCancel" />
        </EditItemTemplate>
    </asp:TemplateField>
               
            </Columns>
        </asp:GridView>
    
    
    </div>
    </form>
</body>
</html>
