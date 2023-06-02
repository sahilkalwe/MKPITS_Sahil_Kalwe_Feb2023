<style type="text/css">
    .auto-style1 {
        text-align: left;
    }
    .auto-style2 {
        width: 100%;
        border-collapse: collapse;
        border-style: solid;
        border-width: 1px;
    }
    .auto-style3 {
        text-align: left;
        width: 152px;
    }
    .auto-style4 {
        text-align: left;
        width: 152px;
        height: 24px;
    }
    .auto-style5 {
        text-align: left;
        height: 24px;
    }
</style>
<div class="auto-style1">
    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP9.WebForm1" %>

&nbsp;
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">Customer Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Product Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Rate</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Quantity</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Total Amount</td>
            <td class="auto-style5">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>
    <div class="auto-style1">

<!DOCTYPE html>
        <script runat="server">

            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {

            }
</script>


        <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    </div>
        </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
