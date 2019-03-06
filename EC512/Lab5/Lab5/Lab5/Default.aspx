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
            <h1 style="text-align: center">Currency Conversions</h1>
            <br />
            Input Value: 
            <asp:TextBox ID="inputString" runat="server" Width="121px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clear Input" />
            <br />
            <br />
            Select Desired Currency:<br />
            <asp:ListBox ID="currencyList" runat="server" Height="99px" Width="190px" DataSourceID="SqlDataSource1" DataTextField="Currency" DataValueField="Exchange"></asp:ListBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Rates]"></asp:SqlDataSource>
            <br />

            <br />
            <asp:Button ID="tousd" runat="server" Text="TO USD" Width="80px" OnClick="tousd_Click" />
            &nbsp;<asp:Button ID="fromusd" runat="server" Text="FROM USD" Width="85px" OnClick="fromusd_Click"/>
&nbsp;&nbsp;<br />
            <br />
            Output Value:&nbsp;
            <asp:Label ID="output" runat="server" Text=""></asp:Label>
            <br />


            <br />
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
