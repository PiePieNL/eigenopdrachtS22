<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nieuws.aspx.cs" Inherits="eigenopdracht.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" dir="ltr">
        
         <h1>Nieuws
         </h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcenieuws3dagen" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="TITEL" HeaderText="TITEL" SortExpression="TITEL" />
                <asp:BoundField DataField="POSTDATUM" HeaderText="POSTDATUM" SortExpression="POSTDATUM" />
            </Columns>
             </asp:GridView>
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         

             <asp:SqlDataSource ID="SqlDataSourcenieuws3dagen" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT b.TITEL,b.POSTDATUM FROM BERICHT b, NIEUWS n 
WHERE b.BERICHTID = n.BERICHTID AND b.POSTDATUM &gt;(sysdate-3)"></asp:SqlDataSource>
         

    </div>
</asp:Content>
