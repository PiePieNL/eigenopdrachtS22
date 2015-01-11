<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Top5.aspx.cs" Inherits="eigenopdracht.Top5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="margin-top: 15px">
        <div class="col-md-5">
            <h2>Jaar</h2>
            <asp:DropDownList ID="ddlJaar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlJaar_SelectedIndexChanged">
            </asp:DropDownList>
            <h2>Maand</h2>
            <asp:DropDownList ID="ddlmaand" runat="server" OnSelectedIndexChanged="ddlmaand_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="01">Januari</asp:ListItem>
                <asp:ListItem Value="02">Februari</asp:ListItem>
                <asp:ListItem Value="03">Maart</asp:ListItem>
                <asp:ListItem Value="04">April</asp:ListItem>
                <asp:ListItem Value="05">Mei</asp:ListItem>
                <asp:ListItem Value="06">Juni</asp:ListItem>
                <asp:ListItem Value="07">Juli</asp:ListItem>
                <asp:ListItem Value="08">Augustus</asp:ListItem>
                <asp:ListItem Value="09">September</asp:ListItem>
                <asp:ListItem Value="10">Oktober</asp:ListItem>
                <asp:ListItem Value="11">November</asp:ListItem>
                <asp:ListItem Value="12">December</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-7">
            <asp:Repeater ID="rpGames" runat="server" onitemdatabound="rpGames_ItemDataBound">
                <ItemTemplate>
                    <table>
                        <tr>
                            <th rowspan="2" style="background-color: #b20000">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Positie") %>' Font-Size="XX-Large"  ForeColor="White"></asp:Label>
                            </th>
                            <th rowspan="2" style="text-align: center"> -  </th>
                            <th rowspan="2">
                                <asp:Image ID="Image1" class="img-responsive" runat="server" ImageUrl='<%#Eval("AFBURL") %>' Height="75px" Width="48px" />
                            </th>
                            <th rowspan="2" style="text-align: center">   </th>
                            <th colspan="2">
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("Titel") %>' ForeColor="#960000"></asp:Label></th>
                            <th>
                               <asp:Label ID="Label4" runat="server" Text='<%#Eval("Platform") %>' BackColor="#b20000" ForeColor="White"></asp:Label></th>
                        </tr>
                        <tr>
                            <td colspan="2">
                               Release:  <asp:Label ID="Label3" runat="server" Text='<%#Eval("releasedatum") %>'></asp:Label></td>
                            <td></td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SeparatorTemplate>
                    <tr>
                        <td colspan="4">
                            <hr>
                        </td>
                    </tr>
                </SeparatorTemplate>
                <FooterTemplate>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmptyData"
                                Text="top 5 bestaat niet" runat="server" Visible="false" ForeColor="#B20000" Font-Size="XX-Large">
                            </asp:Label>
                        </td>
                    </tr>
                    </table>           
                </FooterTemplate>
     

            </asp:Repeater>

        </div>

    </div>
</asp:Content>
