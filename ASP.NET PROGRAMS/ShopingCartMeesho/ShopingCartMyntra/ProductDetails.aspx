<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ShopingCartMyntra.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
   <style>
       table, th,td{
       padding:15px;
       border:1px solid lightgrey;
       border-collpase:collapse;
       }
       </style>
    <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="1" >
    <ItemTemplate>
     <Table cellpadding="2" cellspacing ="0" border="1" style="width:100%; height:400px; border:dashed 0px #04AFEF; background-color: #FFFFFF "> 
         <tr>
             <td>
                 <table width="100%">
                     <tr>
                         <td align="center">
                             <a href='<%# Eval("prodid","ProductDetails.aspx?prodid={0}") %>'>
                                 <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/images/{0}") %>' runat="server" height="250" width="200"/>

                                 </a>
                             </td>
                         </tr>
         <tr align ="center">
             <td>
                 <a style="border=1;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;"href="cart.aspx">Add TO Cart</a>

                                &nbsp;&nbsp;
    <a style="border=1;color:white;text-decoration:none;
         padding:10px;border-radius:10px;background-color:green;"href="cart.aspx">Buy Now </a>
                 </td>
             </tr>
         </table>
        </td>
        <td>
            <table width="100%">
                <tr>
                    <td>
                        <span><b><%# Eval ("prodname") %>
                        <b></span><br/>
                        <span>Rs.<%#Eval("Prodprice") %>onwards</span><br/><br/>
                        Free Delivery
                        </td>
                    </tr>
                <tr>
                    <td>
                        <b>Product Details</b>
                        Name:<%#Eval("prodname") %><br/>Description:<%# Eval("proddescription") %><br/>Size: S, L, XL, XXL<br></br>
                        Country Of Origin:India
                        
                        </td>
                    </tr>

                </table>
            </td>
        </tr>
        </table>
        </ItemTemplate>
        </asp:DataList>
    </asp:Content>  

    