<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NieuwsBericht.aspx.cs" Inherits="eigenopdracht.NieuwsBericht" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
 <div class="row">
<h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
     <div class ="col-md-8">
         <p class ="text-right"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
         
         <p class="text-left">

         <asp:Label ID="Label2"  runat="server" Text="Label" Font-Underline="False"></asp:Label>
         </p>
         <p>
         <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label> </p>
     </div>
     
 </div>
   <h2>Comments</h2>
 <div class="row">   
<div class ="col-md-7">
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
             <div class="form-group" style ="background-color:#D8D8D8 ">
                 <div style="text-align: right;">
        <asp:Label runat="server"   Text=<%#Eval("username") %>></asp:Label>
                     <br></br>
                     </div>
        <asp:Label runat="server" Text=<%#Eval("Tekst") %>></asp:Label>
                 <br></br>
        <p>geplaatst op:<asp:Label runat="server" Text=<%#Eval("Geplaatstop") %>></asp:Label>
            <br></br></p>
                 </div>

    </ItemTemplate>
    </asp:Repeater>
    
</div>
    <div class ="col-md-6">
        <asp:TextBox ID="txtComment" runat="server" Height="91px" Width="311px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="btnAddComment" runat="server" Text="Plaats reactie" Width="97px" OnClick="btnAddComment_Click" />
        <asp:RequiredFieldValidator ID="VDmessage" runat="server" ControlToValidate="TBComment" ErrorMessage="a message is needed"></asp:RequiredFieldValidator>
    </div>
     </div>

    


</asp:Content>
