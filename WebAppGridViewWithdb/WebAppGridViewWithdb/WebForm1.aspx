<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGridViewWithdb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="False" OnRowCancelingEdit="OnCancel" OnRowEditing="OnRowEditing" OnRowUpdating="OnRowUpdating" >
            <Columns>
                <asp:BoundField DataField="STDID" HeaderText="STUDENT ID" ReadOnly="true"/>
                <asp:BoundField DataField="STDNAME" HeaderText="STUDENT NAME" />
                <asp:BoundField DataField="BATCHNO" HeaderText="BATCH ID" />
               
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Update">Update</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
               
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
