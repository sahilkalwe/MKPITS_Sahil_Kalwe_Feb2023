<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP11.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: left;
            width: 141px;
        }
        .auto-style4 {
            text-align: left;
            width: 256px;
        }
        .auto-style5 {
            margin-right: 415px;
        }
        .auto-style6 {
            text-align: left;
            width: 141px;
            height: 31px;
        }
        .auto-style7 {
            text-align: left;
            width: 256px;
            height: 31px;
        }
        .auto-style8 {
            text-align: left;
            height: 31px;
        }
        .auto-style9 {
            text-align: left;
            width: 141px;
            height: 24px;
        }
        .auto-style10 {
            text-align: left;
            width: 256px;
            height: 24px;
        }
        .auto-style11 {
            text-align: left;
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Enter Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="TextBox1"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableTheming="True" ErrorMessage="RequiredFieldValidator">Please enter username</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Enter Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Reenter Proper Password"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Renter Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">age</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" BorderStyle="None" ControlToValidate="TextBox4" ErrorMessage="age must be in range between 18-100" MaximumValue="100" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">email</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invalid email id" ValidateRequestMode="Enabled" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">dob</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Dob entered is  not correct" OnServerValidate="CustomValidator1_ServerValidate">DOB is not proper</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style5" ValidationGroup="Username Cannot be blank" />
&nbsp;&nbsp;
    </form>
</body>
</html>
