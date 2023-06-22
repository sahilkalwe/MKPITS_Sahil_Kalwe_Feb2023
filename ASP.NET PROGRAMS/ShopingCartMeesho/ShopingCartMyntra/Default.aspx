<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopingCartMyntra._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Meesho</h1>
         <p class="lead">Lowest Prices Best Quality Shopping</p>
            <p ></p>
        
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Free Delivery
                   
                </h2>
  <%--            <%--  <p>
                    <%--Register as a Meesho Supplier--%>
                    <br/><br/>
                   
                </p>
                <p>
                 <%-- <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>--%>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle"></h2>
                <p>
                 <%-- // Register as a Meesho Supplier--%>
                </p>
                <p>
<%--                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>--%>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle"> Cash On Delivery</h2>
                <p>
                    <img src="1.jpg" style="width:350px;height:250px;"/>
                </p>
                <p>
 <%--                   <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>--%>
               
                </p>
            </section>
        </div>
        <hr/>
        <div class="row">
            <h1 align=center>----------------Top Categories To Choose From---------------</h1> 

            </div>
        <hr/>
        <div class="row">
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="100%">
<ItemTemplate>
    <table cellpadding="2" cellspacing="0" border="1" style="width:300px; height:100px; border: solid 1px #04AFEF;background-color: #FFFFFF">
        <tr>
            <td align="Center">
                
                            <a href='<%# Eval("prodid","productdetails.aspx?prodid={0}") %>'>

                <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage","~/images/{0}")%>' runat="server" Height="100" />
                                </a>
                </td>
            </tr>
        <tr>
            <td align ="center">
                <span ><%# Eval("prodname") %></span><br/>
                <span><%#Eval ("proddescription") %></span><br/>
                <span >Rs.<%#Eval("prodprice") %>Onwards</span><br/>
                 </td>
            </tr>

      
                </td>
        </table>
    </ItemTemplate>
            </asp:DataList>
            </div>

    </main>

</asp:Content>
