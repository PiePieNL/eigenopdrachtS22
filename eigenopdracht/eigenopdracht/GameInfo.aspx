<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameInfo.aspx.cs" Inherits="eigenopdracht.GameInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class ="Row" style="padding-top: 20px"">
  <div class ="col-md-8">
      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

  </div>
    <div class ="col-md-4">
        <asp:Repeater ID="Repeater1" runat="server">

    <ItemTemplate>
       <table style="border: thin double #666666; background-color: #FF0000">
           <tr>
               <td>
                  Genre: <%# Eval("GENRE") %>
               </td>

           </tr>
            <tr>
               <td>
                  Platform: <%# Eval("PLATFORM") %>
               </td>

           </tr>
            <tr>
               <td>
                  Ontwikkelaar: <%# Eval("ONTWIKKELAAR") %>
               </td>

           </tr>
            <tr>
               <td>
                  Uitgever: <%# Eval("UITGEVER") %>
               </td>

           </tr>



       </table>
             
        

    </ItemTemplate>
        </asp:Repeater>
    </div>
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getGameNieuws" TypeName="eigenopdracht.DbGame">
            <SelectParameters>
                <asp:CookieParameter CookieName="gametitel" Name="gametitel" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
    </div>



    </div>
</asp:Content>
