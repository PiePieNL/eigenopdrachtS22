<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="eigenopdracht.Content.Game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4"> 
        <input id="Text1" type="text" />
        <input id="Button1" type="button" value="button" />
    </div>
    <div class="col-md-4">
       <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>
    <div class="col-md-4">
       <asp:Button ID="Button3" runat="server" Text="Button" />
    </div>
    <div class="col-md-4">
       <asp:Button ID="Button4" runat="server" Text="Button" />
        <asp:ListBox ID="ListBox1" runat="server" Height="401px" Width="691px"></asp:ListBox>
    </div>
</asp:Content>

