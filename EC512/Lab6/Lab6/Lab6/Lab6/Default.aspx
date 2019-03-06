<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            <h1 style="text-align: center">Voting Page</h1>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Names" DataValueField="Id" Height="56px" Width="119px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">

            </asp:RadioButtonList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CandidatesConnectionString1 %>" SelectCommand="SELECT * FROM [Votes]" UpdateCommand="UPDATE [Votes] SET Votes = @newcount WHERE [Id] = @Id">
                <UpdateParameters>
                    <asp:ControlParameter ControlID="HiddenField1" Name="newcount" PropertyName="Value" />
                    <asp:ControlParameter ControlID="RadioButtonList1" Name="Id" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            
            <asp:Button ID="SUBMITBUT" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
            <br />
            <br />
            <asp:Label ID="ERRORmsg" runat="server" Text="error"></asp:Label>
            <br/>
        </div>
    </form>
</body>
</html>
