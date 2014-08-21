<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Confirmation</h2>
    <p>Please confirm all entries are correct.</p>
    <table>
        <tr>
            <td>Last Name:</td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                    ErrorMessage="Last Name Required. " 
                    ControlToValidate="txtLastName" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>First Name:</td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                    ErrorMessage="First Name Required. " 
                    ControlToValidate="txtFirstName" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>Email:</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                    ErrorMessage="Email Required. " 
                    ControlToValidate="txtEmail" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                    ErrorMessage="Enter a valid email. "
                    ControlToValidate="txtEmail"
                    ValidationRequestMode="Enabled"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    CssClass="error">
                </asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <td>Street Address:</td>
            <td><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvStreet" runat="server" 
                    ErrorMessage="Street Address Required. " 
                    ControlToValidate="txtStreet" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>City:</td>
            <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                    ErrorMessage="City Required. " 
                    ControlToValidate="txtCity" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>State:</td>
            <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                    ErrorMessage="State Required. " 
                    ControlToValidate="txtState" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>Zip Code:</td>
            <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvZip" runat="server" 
                    ErrorMessage="Zip Code Required. " 
                    ControlToValidate="txtZip" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revZip" runat="server" 
                    ErrorMessage="RegularExpressionValidator"
                    ControlToValidate="txtZip"
                    ValidateRequestMode="Enabled" 
                    ValidationExpression="\d{5}(-\d{4})?"
                    CssClass="error">
                </asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <td>Phone Number:</td>
            <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                    ErrorMessage="Phone Number Required. " 
                    ControlToValidate="txtPhone" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" 
                    ErrorMessage="Enter in this format (123) 123-1234"
                    ControlToValidate="txtPhone"
                    ValidateRequestMode="Enabled" 
                    ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"
                    CssClass="error">
                </asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <td>Password:</td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                    ErrorMessage="Password Required. " 
                    ControlToValidate="txtPassword" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td>Confirm Password:</td>
            <td><asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvConfirm" runat="server" 
                    ErrorMessage="Confirm Password Required. " 
                    ControlToValidate="txtConfirm" 
                    CssClass="error">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvConfirm" runat="server" 
                    ErrorMessage="Password does not match. "
                    ControlToValidate="txtConfirm"
                    ControlToCompare="txtPassword"
                    CssClass="error">
                </asp:CompareValidator>
             </td>
         </tr>
         <tr>
            <td><asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label></td>
            <td>&nbsp;</td>
         </tr>
    </table>
</asp:Content>

