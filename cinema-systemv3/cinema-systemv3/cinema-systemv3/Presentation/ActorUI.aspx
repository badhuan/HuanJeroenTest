<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActorUI.aspx.cs" Inherits="cinema_systemv3.Presentation.ActorUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ActorID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ActorID" HeaderText="ActorID" InsertVisible="False" ReadOnly="True" SortExpression="ActorID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Vul naam in"></asp:Label>
        <asp:TextBox ID="TextBoxActor" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Cinema_DataConnectionString %>" DeleteCommand="DELETE FROM [Actor] WHERE [ActorID] = @ActorID" InsertCommand="INSERT INTO [Actor] ([Name]) VALUES (@Name)" ProviderName="<%$ ConnectionStrings:Cinema_DataConnectionString.ProviderName %>" SelectCommand="SELECT [ActorID], [Name] FROM [Actor]" UpdateCommand="UPDATE [Actor] SET [Name] = @Name WHERE [ActorID] = @ActorID">
            <DeleteParameters>
                <asp:Parameter Name="ActorID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="ActorID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Vul ID in"></asp:Label>
        <asp:TextBox ID="TextBoxActorID" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ActorID" DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="ActorID" HeaderText="ActorID" ReadOnly="True" SortExpression="ActorID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Cinema_DataConnectionString %>" DeleteCommand="DELETE FROM [Actor] WHERE [ActorID] = @ActorID" InsertCommand="INSERT INTO [Actor] ([Name]) VALUES (@Name)" SelectCommand="SELECT [ActorID], [Name] FROM [Actor] WHERE ([ActorID] = @ActorID)" UpdateCommand="UPDATE [Actor] SET [Name] = @Name WHERE [ActorID] = @ActorID">
            <DeleteParameters>
                <asp:Parameter Name="ActorID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBoxActorID" Name="ActorID" PropertyName="Text" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="ActorID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
