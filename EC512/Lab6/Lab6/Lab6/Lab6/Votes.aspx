<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Votes.aspx.cs" Inherits="Votes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <style type="text/css">
        .newStyle1 {
            background-color: #C0C0C0;
            border-style: solid;
            border-width: 1px;
            margin: auto;
            width: 800px;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="newStyle1">
            <h1 style="text-align: center">Thank You for Voting!</h1>
            <br />
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CandidatesConnectionString1 %>" DeleteCommand="DELETE FROM [Votes] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Votes] ([Id], [Names], [Votes]) VALUES (@Id, @Names, @Votes)" SelectCommand="SELECT [Id], [Names], [Votes] FROM [Votes]" UpdateCommand="UPDATE [Votes] SET [Names] = @Names, [Votes] = @Votes WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                    <asp:Parameter Name="Names" Type="String" />
                    <asp:Parameter Name="Votes" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Names" Type="String" />
                    <asp:Parameter Name="Votes" Type="Int32" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
