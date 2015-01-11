<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Maaktop5.aspx.cs" Inherits="eigenopdracht.Maaktop5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class=" row" style="margin-top: 15px">

        <div class="col-md-4">

            <asp:ListBox ID="Listgames" runat="server" DataSourceID="datasourchegames" DataTextField="TITEL" DataValueField="TITEL" Height="331px" Width="249px"></asp:ListBox>
            <asp:SqlDataSource ID="datasourchegames" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;TITEL&quot;, &quot;GAMEID&quot; FROM &quot;GAME&quot;"></asp:SqlDataSource>
        </div>



       
        <div class="col-md-4" style="text-align: center">
            <table>
                <tr>
                    <th>
                        <asp:Button ID="btnVoegGametoe" runat="server" OnClick="btnVoegGametoe_Click" Text="voeg game toe" />
                    </th>
                    <th>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Listgames" ErrorMessage="Selecteer een game om in de top 100 te doen" ForeColor="Red"></asp:RequiredFieldValidator>

                    </th>
                    <th>
                        <asp:Button ID="btnverwijder" runat="server" Text="verwijder uit top 5" OnClick="btnverwijder_Click" />

                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlMaand" runat="server">
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
                        </asp:DropDownList></td>
                    <td>
                        <asp:Button ID="btmaaktop5" runat="server" Text="maak top 5" OnClick="btmaaktop5_Click" /></td>
                    <td></td>
                </tr>
                <tr>
                    <th colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label> </th>
                </tr>

            </table>





        </div>

        <div class="col-md-4">
            <asp:ListBox ID="ListBox1" runat="server" Height="331px" Width="249px"></asp:ListBox>
            
        </div>
        
       


    </div>




</asp:Content>
