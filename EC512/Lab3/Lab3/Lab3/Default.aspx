<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .main {
            border-style: solid;
            border-width: thin;
            margin: auto;
            background-color: #C0C0C0;
            width: 638px;
            height: 384px;
        }
        .left {
            padding: 100px;
            float: left;
            width: 243px;
            height: 111px;
        }
        .right {
            border-width: thin;
            padding: 50px;
            float: left;
            border-left-style: solid;
            height: 217px;
            margin-top: 30px;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <div class="left">
                <p>

                    <span class="auto-style2">Input:</span>&nbsp;&nbsp;
                    <asp:TextBox ID="input" runat="server" BackColor="White" BorderStyle="Inset" Height="15px" Width="173px" Font-Italic="False" Font-Names="Arial"></asp:TextBox>
                </p>
                <p>

                    <span class="auto-style2">Result:</span>
                    <asp:TextBox ID="result" runat="server" Height="15px" ReadOnly="True" Width="173px"></asp:TextBox>
                </p>
                <p>

                    

                    <asp:Label ID="error" runat="server" BackColor="White" ForeColor="Red"></asp:Label>

                    

                </p>
            </div>
            <div class="right">

                
                <asp:Button ID="enter" runat="server" Text="Enter" onclick="Enter_Click" style="width:47px;" />
                <br />
                <br />
                <asp:Button ID="add" runat="server" Text="+" onclick="Add_Click" style="width:47px;" />
                <br />
                <br />
                <asp:Button ID="sub" runat="server" Text="-" onclick="Sub_Click" style="width:47px;" />
                <br />
                <br />
                <asp:Button ID="mul" runat="server" Text="X" onclick="Mul_Click" style="width:47px;" />
                <br />
                <br />
                <asp:Button ID="div" runat="server" Text="/" onclick="Div_Click" style="width:47px;" />
                <br />

            </div>
        </div>
    </form>
</body>
</html>
