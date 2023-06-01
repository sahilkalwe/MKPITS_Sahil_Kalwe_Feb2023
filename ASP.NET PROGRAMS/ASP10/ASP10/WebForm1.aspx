<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP10.WebForm1" %>

<!DOCTYPE html>

<html lang="en">  
<head>  
    <meta charset="utf-8">  
    <title>Bootstrap Part11</title>  
    <meta name="viewport" content="width=device-width,initial-scale=1">  
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">  
</head>  
<body>  
    <!--Inverted Navbar Start Here-->  
    <!--<nav> tag  start with classes .navbar and .navbar-inverse and .navbar-fixed-top" -->  
    <nav class="navbar navbar-inverse navbar-fixed-top">  
        <div class="container-fluid">  
            <!--Navbar Header Start Here-->  
            <div class="navbar-header">  
                <a class="navbar-brand" href="#">C-sharp Corner</a>  
            </div> 
            <ul class="nav navbar-nav">  
                <li class="active">Home</li>  
                <li>About Us</li>  
                <li>Technology</li>  
                <li>Contact Us</li>  
            </ul>  
            <!--Menu End Here-->  
        </div>  
    </nav>  
    <!--<nav> tag end-->  
    <!--Inverted Navbar End Here-->  
    <!--Contents Start Here-->  
    <div class="container">  
        <h3>Fixed Top Navbar</h3>  
        <div class="row">  
            <div class="col-md-6">  
          
            </div>  
        </div>  
    </div>  
    <!--Contents End Here-->  
    <script src="js/jquery-2.1.4.min.js"></script>  
    <script src="js/bootstrap.min.js"></script>  
</body>  
</html>  

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            text-align: left;
            width: 146px;
        }
        .auto-style5 {
            text-align: left;
            width: 146px;
            height: 116px;
        }
        .auto-style6 {
            text-align: left;
            height: 116px;
        }
        .auto-style7 {
            text-align: left;
            width: 146px;
            height: 82px;
        }
        .auto-style8 {
            text-align: left;
            height: 82px;
        }
        .auto-style9 {
            text-align: left;
            width: 146px;
            height: 24px;
        }
        .auto-style10 {
            text-align: left;
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>MKPIT SERVICES</strong><br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">Country </td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>Nepal</asp:ListItem>
                            <asp:ListItem>Sri Lanka</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">City</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Nagpur</asp:ListItem>
                            <asp:ListItem>Washim</asp:ListItem>
                            <asp:ListItem>Bhandara</asp:ListItem>
                            <asp:ListItem>Tumsar</asp:ListItem>
                            <asp:ListItem>Kolombo</asp:ListItem>
                            <asp:ListItem>Katmandu</asp:ListItem>
                            <asp:ListItem Value="Nostadq">Nostadq</asp:ListItem>
                            <asp:ListItem>Trivantpuram</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Course</td>
                    <td class="auto-style8">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>DotNET</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>Python</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Centers</td>
                    <td class="auto-style6">
                        <asp:ListBox ID="ListBox1" runat="server" Height="115px" Width="150px">
                            <asp:ListItem>Nagpur</asp:ListItem>
                            <asp:ListItem>Yavatmal</asp:ListItem>
                            <asp:ListItem>Wardha</asp:ListItem>
                            <asp:ListItem>Nashik</asp:ListItem>
                            <asp:ListItem>Amravati</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="MKPITS_Logo.png" OnClick="ImageButton1_Click" Width="61px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="151px" ImageUrl="MKPITS_Logo.png" Width="197px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
