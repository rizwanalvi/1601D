<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridViewImage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="STDNAME"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server">
        </asp:TextBox> <br />
         <asp:Label ID="Label2" runat="server" Text="STDFNAME"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"> 

                      </asp:TextBox> <br />
         <asp:Label ID="Label3" runat="server" Text="BATCHNO"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label4" runat="server" Text="SEMID"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add Data" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show" Width="66px" />
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
         <br />
        <asp:GridView ID="GridView1" runat="server" Width="100%"  AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="STDID" HeaderText="STUDENT ID" />
                <asp:BoundField DataField="STDNAME" HeaderText="STUDENT NAME" />
                <asp:TemplateField HeaderText="PICTURE">
                    <ItemTemplate>
                        <img alt="" src='<%# GetImage(Eval("IMG")) %>' height="75" width="50" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>

    </div>
      
    </form>
</body>
</html>
