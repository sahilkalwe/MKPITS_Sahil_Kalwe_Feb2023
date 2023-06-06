<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP17.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language ="Javascript">
        function alert_meth()
        {
            alert("Client Side MessgaeBox");
        }
        function confirm_meth()
        {
            if (confirm("Do you want to continue ! 'Yes'") == true) {
                document.writeln("<br> You had click on 'Yes' button <br>");
            }
            else
            {
                document.writeln("<br>you had click on 'no' button</br>");
            }
        }
        </script>
</head >
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button OnClientClick="alert_meth()" ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <p>
            <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
