<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppDesiner.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.2/css/bootstrap.min.css" integrity="sha384-Smlep5jCw/wG7hdkwQ/Z5nLIefveQRIY9nfy6xoR1uRYBtpZgI6339F5dgvm/e9B" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>

  <div class="form-group">
    <label for="exampleInputEmail1">STUDENT ID</label>
      <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" class="form-control"></asp:TextBox>
   
  </div>
        <div class="form-group">
    <label for="exampleInputEmail1">STUDENT NAME</label>
      <asp:TextBox ID="TextBox2" runat="server"  class="form-control"></asp:TextBox>
   
  </div>
           <div class="form-group">
    <label for="exampleInputEmail1">STUDENT NAME</label>
               <asp:DropDownList ID="DropDownList2" runat="server" class="form-control">
                   <asp:ListItem>CPISM</asp:ListItem>
                   <asp:ListItem>DISM</asp:ListItem>
                   <asp:ListItem>HDSE-I</asp:ListItem>
                   <asp:ListItem>HDSE-II</asp:ListItem>
               </asp:DropDownList>
   
  </div>
        <asp:Button ID="Button1" runat="server" Text="Add Data"  class="btn btn-primary" OnClick="Button1_Click"/>
 

        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" DeleteCommand="DELETE FROM [StudnInfo] WHERE [STDID] = @STDID" InsertCommand="INSERT INTO [StudnInfo] ([STDID], [STDNAME], [STDFNAME], [BATCHNO], [SEMID], [SESS_ID], [SKILL]) VALUES (@STDID, @STDNAME, @STDFNAME, @BATCHNO, @SEMID, @SESS_ID, @SKILL)" SelectCommand="SELECT * FROM [StudnInfo] WHERE ([STDID] = @STDID)" UpdateCommand="UPDATE [StudnInfo] SET [STDNAME] = @STDNAME, [STDFNAME] = @STDFNAME, [BATCHNO] = @BATCHNO, [SEMID] = @SEMID, [SESS_ID] = @SESS_ID, [SKILL] = @SKILL WHERE [STDID] = @STDID">
            <DeleteParameters>
                <asp:Parameter Name="STDID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="STDID" Type="Int32" />
                <asp:Parameter Name="STDNAME" Type="String" />
                <asp:Parameter Name="STDFNAME" Type="String" />
                <asp:Parameter Name="BATCHNO" Type="String" />
                <asp:Parameter Name="SEMID" Type="String" />
                <asp:Parameter Name="SESS_ID" Type="Int32" />
                <asp:Parameter Name="SKILL" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="9999999" Name="STDID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="STDNAME" Type="String" />
                <asp:Parameter Name="STDFNAME" Type="String" />
                <asp:Parameter Name="BATCHNO" Type="String" />
                <asp:Parameter Name="SEMID" Type="String" />
                <asp:Parameter Name="SESS_ID" Type="Int32" />
                <asp:Parameter Name="SKILL" Type="String" />
                <asp:Parameter Name="STDID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" DeleteCommand="DELETE FROM [StudnInfo] WHERE [STDID] = @STDID" InsertCommand="INSERT INTO [StudnInfo] ([STDID], [STDNAME], [STDFNAME], [BATCHNO], [SEMID], [SESS_ID], [SKILL]) VALUES (@STDID, @STDNAME, @STDFNAME, @BATCHNO, @SEMID, @SESS_ID, @SKILL)" SelectCommand="SELECT * FROM [StudnInfo]" UpdateCommand="UPDATE [StudnInfo] SET [STDNAME] = @STDNAME, [STDFNAME] = @STDFNAME, [BATCHNO] = @BATCHNO, [SEMID] = @SEMID, [SESS_ID] = @SESS_ID, [SKILL] = @SKILL WHERE [STDID] = @STDID">
            <DeleteParameters>
                <asp:Parameter Name="STDID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="STDID" Type="Int32" />
                <asp:Parameter Name="STDNAME" Type="String" />
                <asp:Parameter Name="STDFNAME" Type="String" />
                <asp:Parameter Name="BATCHNO" Type="String" />
                <asp:Parameter Name="SEMID" Type="String" />
                <asp:Parameter Name="SESS_ID" Type="Int32" />
                <asp:Parameter Name="SKILL" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="STDNAME" Type="String" />
                <asp:Parameter Name="STDFNAME" Type="String" />
                <asp:Parameter Name="BATCHNO" Type="String" />
                <asp:Parameter Name="SEMID" Type="String" />
                <asp:Parameter Name="SESS_ID" Type="Int32" />
                <asp:Parameter Name="SKILL" Type="String" />
                <asp:Parameter Name="STDID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="STDID" DataValueField="STDID" Height="18px" Width="111px">
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="STDID" DataSourceID="SqlDataSource1" PageSize="5">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="STDID" HeaderText="STDID" ReadOnly="True" SortExpression="STDID" />
                <asp:BoundField DataField="STDNAME" HeaderText="STDNAME" SortExpression="STDNAME" />
                <asp:BoundField DataField="STDFNAME" HeaderText="STDFNAME" SortExpression="STDFNAME" />
                <asp:BoundField DataField="BATCHNO" HeaderText="BATCHNO" SortExpression="BATCHNO" />
                <asp:BoundField DataField="SEMID" HeaderText="SEMID" SortExpression="SEMID" />
                <asp:BoundField DataField="SESS_ID" HeaderText="SESS_ID" SortExpression="SESS_ID" />
                <asp:BoundField DataField="SKILL" HeaderText="SKILL" SortExpression="SKILL" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
