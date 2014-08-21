<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Register</h1>
        <!-- Basic form here. Needs to have validation and confirm password-->
        <table>
            <tr>
                <td>Last Name:</td>
                <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>First Name:</td>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Street Address:</td>
                <td><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Apartment:</td>
                <td><asp:TextBox ID="txtApartment" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>City:</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>State:</td>
                <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Zip:</td>
                <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <!--PersonUserName is Email -->
                <td>Email:</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Confirm Password: </td>
                <td><asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                <td><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>

