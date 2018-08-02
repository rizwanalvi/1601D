<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" DeleteCommand="DELETE FROM [StudnInfo] WHERE [STDID] = @original_STDID AND [STDNAME] = @original_STDNAME AND (([STDFNAME] = @original_STDFNAME) OR ([STDFNAME] IS NULL AND @original_STDFNAME IS NULL)) AND (([BATCHNO] = @original_BATCHNO) OR ([BATCHNO] IS NULL AND @original_BATCHNO IS NULL)) AND (([SEMID] = @original_SEMID) OR ([SEMID] IS NULL AND @original_SEMID IS NULL)) AND (([SESS_ID] = @original_SESS_ID) OR ([SESS_ID] IS NULL AND @original_SESS_ID IS NULL)) AND (([SKILL] = @original_SKILL) OR ([SKILL] IS NULL AND @original_SKILL IS NULL)) AND (([IMG] = @original_IMG) OR ([IMG] IS NULL AND @original_IMG IS NULL))" InsertCommand="INSERT INTO [StudnInfo] ([STDNAME], [STDFNAME], [BATCHNO], [SEMID], [SESS_ID], [SKILL], [IMG]) VALUES (@STDNAME, @STDFNAME, @BATCHNO, @SEMID, @SESS_ID, @SKILL, @IMG)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [StudnInfo]" UpdateCommand="UPDATE [StudnInfo] SET [STDNAME] = @STDNAME, [STDFNAME] = @STDFNAME, [BATCHNO] = @BATCHNO, [SEMID] = @SEMID, [SESS_ID] = @SESS_ID, [SKILL] = @SKILL, [IMG] = @IMG WHERE [STDID] = @original_STDID AND [STDNAME] = @original_STDNAME AND (([STDFNAME] = @original_STDFNAME) OR ([STDFNAME] IS NULL AND @original_STDFNAME IS NULL)) AND (([BATCHNO] = @original_BATCHNO) OR ([BATCHNO] IS NULL AND @original_BATCHNO IS NULL)) AND (([SEMID] = @original_SEMID) OR ([SEMID] IS NULL AND @original_SEMID IS NULL)) AND (([SESS_ID] = @original_SESS_ID) OR ([SESS_ID] IS NULL AND @original_SESS_ID IS NULL)) AND (([SKILL] = @original_SKILL) OR ([SKILL] IS NULL AND @original_SKILL IS NULL)) AND (([IMG] = @original_IMG) OR ([IMG] IS NULL AND @original_IMG IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_STDID" Type="Int32" />
            <asp:Parameter Name="original_STDNAME" Type="String" />
            <asp:Parameter Name="original_STDFNAME" Type="String" />
            <asp:Parameter Name="original_BATCHNO" Type="String" />
            <asp:Parameter Name="original_SEMID" Type="String" />
            <asp:Parameter Name="original_SESS_ID" Type="Int32" />
            <asp:Parameter Name="original_SKILL" Type="String" />
            <asp:Parameter Name="original_IMG" Type="Object" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="STDNAME" Type="String" />
            <asp:Parameter Name="STDFNAME" Type="String" />
            <asp:Parameter Name="BATCHNO" Type="String" />
            <asp:Parameter Name="SEMID" Type="String" />
            <asp:Parameter Name="SESS_ID" Type="Int32" />
            <asp:Parameter Name="SKILL" Type="String" />
            <asp:Parameter Name="IMG" Type="Object" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="STDNAME" Type="String" />
            <asp:Parameter Name="STDFNAME" Type="String" />
            <asp:Parameter Name="BATCHNO" Type="String" />
            <asp:Parameter Name="SEMID" Type="String" />
            <asp:Parameter Name="SESS_ID" Type="Int32" />
            <asp:Parameter Name="SKILL" Type="String" />
            <asp:Parameter Name="IMG" Type="Object" />
            <asp:Parameter Name="original_STDID" Type="Int32" />
            <asp:Parameter Name="original_STDNAME" Type="String" />
            <asp:Parameter Name="original_STDFNAME" Type="String" />
            <asp:Parameter Name="original_BATCHNO" Type="String" />
            <asp:Parameter Name="original_SEMID" Type="String" />
            <asp:Parameter Name="original_SESS_ID" Type="Int32" />
            <asp:Parameter Name="original_SKILL" Type="String" />
            <asp:Parameter Name="original_IMG" Type="Object" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" Width="100%" AllowPaging="True" AllowSorting="True" PageSize="1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

</asp:Content>
