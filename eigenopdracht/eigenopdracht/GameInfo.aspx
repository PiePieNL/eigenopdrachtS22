<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameInfo.aspx.cs" Inherits="eigenopdracht.GameInfo" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <link rel="stylesheet" type="text/css" href="Content/elastislide.css" />
    
   <script type="text/javascript" src="/Scripts/modernizr.custom.17475.js"></script>
    
     
    <asp:Repeater ID="Repeater1" runat="server">

        <ItemTemplate>
            <div class ="Row" style="padding-top: 20px; height: 400px;">
            <div class="col-md-4">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("AFBURL") %>' Height="300px" Width="300px"/>
            </div>
            <div class="col-md-4">
                <h2 style="color: #960000">
                    <asp:Label ID="Label1" runat="server" Text=<%# Eval("Titel") %>></asp:Label></h2>
                <p>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("SAMENVATTING") %>'></asp:Label></p>
            </div>
            <div class="col-md-4">
                <table style="border: thin double #666666; background-color: #960000; color: #FFFFFF;">
                    <tr>
                        <td>Genre: <%# Eval("GENRE") %>
                        </td>

                    </tr>
                    <tr>
                        <td>Platform: <%# Eval("PLATFORM") %>
                        </td>

                    </tr>
                    <tr>
                        <td>Ontwikkelaar: <%# Eval("ONTWIKKELAAR") %>
                        </td>

                    </tr>
                    <tr>
                        <td>Uitgever: <%# Eval("UITGEVER") %>
                        </td>

                    </tr>



                </table>
            </div>
            </div>



        </ItemTemplate>
    </asp:Repeater>
     
   
    <div class ="Row" height: 300px>
<div class="col-md-6" >
    <asp:Repeater ID="Repeater2" runat="server">
        <HeaderTemplate>
           <h2 style="color: #FFFFFF; background-color: #960000;"> Nieuws over game</h2>
        </HeaderTemplate>
        <ItemTemplate>

            <table>
                <tr>
                    <th>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text =<%# Eval("Titel") %>> </asp:LinkButton></th>
                </tr>
            </table>
        </ItemTemplate>

    </asp:Repeater>
    </div>
        <div class="col-md-6">
            <ul id="carousel" class="elastislide-list">
                <asp:Repeater ID="mylist" runat="server">
                    <ItemTemplate>
                        <li><a href=" ">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#  Eval("Afbeeldingurl")%>' />
                        </a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>

        </div>
            </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getGameNieuws" TypeName="eigenopdracht.DbGame">
            <SelectParameters>
                <asp:CookieParameter CookieName="gametitel" Name="gametitel" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
    
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script type="text/javascript" src="/Scripts/jquerypp.custom.js"></script>
    <script type="text/javascript" src="/Scripts/jquery.elastislide.js"></script>
    <script type="text/javascript">
        $('#carousel').elastislide();
    </script>

    
</asp:Content>
