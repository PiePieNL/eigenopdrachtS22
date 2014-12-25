<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NieuwsBericht.aspx.cs" Inherits="eigenopdracht.NieuwsBericht" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
 <div class="row">
<h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
     <div class ="col-md-8">
         <p class ="text-right"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
         
         <p class="text-left">

         <asp:Label ID="Label2"  runat="server" Text="Label" Font-Underline="False"></asp:Label>
         </p>
         <p> </p>
     </div>
     
 </div>
 <div class="row">   
<div class ="col-md-7">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" Width="310px" >
        <ItemTemplate>
            Username:
            <asp:Label ID="UsernameLabel" runat="server" Text='<%# Eval("Username") %>' />
            <br />
            BerichtID:
            <asp:Label ID="BerichtIDLabel" runat="server" Text='<%# Eval("BerichtID") %>' />
            <br />
            Reactietekst:
            <asp:Label ID="ReactietekstLabel" runat="server" Text='<%# Eval("Reactietekst") %>' />
            <br />
            Postdatum:
            <asp:Label ID="PostdatumLabel" runat="server" Text='<%# Eval("Postdatum") %>' />
            <br />
<br />
        </ItemTemplate>
    </asp:DataList>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getReactiesBericht" TypeName="eigenopdracht.DbBerichten">
        <SelectParameters>
            <asp:CookieParameter CookieName="BerichtId" DefaultValue="0" Name="berichtid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
</div>

    <div class ="col-md-6">
        <asp:TextBox ID="TextBox1" runat="server" Height="91px" Width="311px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" Width="77px" />
    </div>
     </div>

    


</asp:Content>
