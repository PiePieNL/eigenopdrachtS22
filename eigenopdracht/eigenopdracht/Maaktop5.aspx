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
                    <td></td>
                    <td>
                        <asp:Button ID="btmaaktop5" runat="server" Text="maak top 5" OnClick="btmaaktop5_Click" /></td>
                    <td></td>
                </tr>
            </table>





        </div>

        <div class="col-md-4">
            <asp:ListBox ID="ListBox1" runat="server" Height="331px" Width="249px"></asp:ListBox>
            
        </div>
        
       


    </div>




</asp:Content>
