<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .background-color {
            background-color: #00FFFF;
            border-style: solid;
            border-width: thin;
            margin: auto;
            padding: 30px;
            width: 525px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="background-color">
            <h1 style="text-align: center">Customer Comment Form</h1>
            <br />
            <asp:TextBox ID="TextBox1" rows="2" cols="20" style="height:211px;width:493px;" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" InsertCommand="INSERT INTO comment(comments) VALUES (@newdata)" SelectCommand="SELECT [Id], [comments] FROM [comment]">
                <InsertParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="newdata" PropertyName="Text" />
                </InsertParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit Comment" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="View Comments" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
