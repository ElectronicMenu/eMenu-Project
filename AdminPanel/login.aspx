<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Electronic_Menu.login" %>

<!DOCTYPE html>
<html>
    <head runat="server">
     <title></title>
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
        <script>
       
        </script> 
    <link href="css/StyleSheet.css" rel="stylesheet" />
   

</head>
<body>
     <div id="header">
        <h1>Admin Panel</h1>
        <p>Please provide admin login</p>  
    </div>

    <div id="nav">

    </div>
    <form id="form1" runat="server">
    <div id="section">
   

        <table style="width: 100%;">
            <tr>
                <td>User Name</td>               
                <td>Password</td>
                <td></td>
            </tr>
            <tr>
               <td><asp:TextBox ID="txtUserName" runat="server" MaxLength="15" required="true"></asp:TextBox></td>
                <td><asp:TextBox ID="txtPassword" TextMode="Password" MaxLength="15" runat="server" required="true"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td> <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" /> </td>
                <td></td>
            </tr>
        </table>


    </div>
    </form>
    <div id="footer">
Copyright © COMP313 Team 5
</div>
</body>
</html>
