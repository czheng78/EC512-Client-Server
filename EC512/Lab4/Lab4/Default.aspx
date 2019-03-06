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
            <h1 style="text-align: center">Find Anagrams</h1>
            <br />
            Enter a character string: 
            <asp:TextBox ID="inputString" runat="server" Width="147px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:CheckBox ID="dupd" runat="server" />
            <asp:Label for="dupd" runat="server">Eliminate Duplicates</asp:Label>
            <br />
            <br />
            <asp:ListBox ID="outputList" runat="server" style="height:85px;width:150px"></asp:ListBox>
            <br />

            <br />
            <asp:Button ID="find" runat="server" Text="Find Anagrams" onclick="find_ana"/>
            <br />


            <br />
            <asp:Label ID="comment" runat="server" Text=""></asp:Label>


        </div>
    </form>
</body>
</html>
