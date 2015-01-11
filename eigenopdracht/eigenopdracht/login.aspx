<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="eigenopdracht.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    

    <div>
        <h1>Login</h1>
    </div>
    <div style="text-align: left">

        <table style="width: 100%;">
            <tr>
                <td class="text-left" style="width: 223px; text-align: right">Username</td>
                <td class="text-left" style="width: 434px">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="text-left" style="width: 223px; height: 27px; text-align: right">Password</td>
                <td class="text-left" style="height: 27px; width: 434px">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td style="height: 27px"></td>
            </tr>
            <tr>
                <td class="text-left" style="width: 223px; text-align: right">
                    <asp:Label ID="lbErrormes" runat="server" ForeColor="Red" style="text-align: right" Visible="False"></asp:Label>
                </td>
                <td class="text-left" style="width: 434px">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

                    <asp:HiddenField ID="HiddenFieldredirect" runat="server" />


</asp:Content>
