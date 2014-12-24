<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NieuwsBericht.aspx.cs" Inherits="eigenopdracht.NieuwsBericht" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
 <div class="jumbotron">
<h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>

<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>

<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

 </div>
    
<div class ="col-md-7">
    <asp:ListBox ID="ListBox2" runat="server" Width="319px">
        
    </asp:ListBox>

</div>

    <div class ="col-md-6">
        <asp:TextBox ID="TextBox1" runat="server" Height="91px" Width="311px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" Width="77px" />
    </div>
    


</asp:Content>
