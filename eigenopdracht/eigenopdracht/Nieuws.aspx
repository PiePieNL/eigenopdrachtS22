<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nieuws.aspx.cs" Inherits="eigenopdracht.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" dir="ltr">
        
         <h1 " style="margin: 10px 10px 20px 10px; color: #960000;">Nieuws </h1>
         
             
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSourcenieuws3dagen" DataKeyNames="TITEL" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <AlternatingItemTemplate>
                <span style="">TITEL:
                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TITEL") %>' CommandName="Select"></asp:LinkButton>
                <br />
                POSTDATUM:
                <asp:Label ID="POSTDATUMLabel" runat="server" Text='<%# Eval("POSTDATUM") %>' />
                <br />
<br /></span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="">TITEL:
                <asp:TextBox ID="TITELTextBox" runat="server" Text='<%# Bind("TITEL") %>' />
                <br />
                POSTDATUM:
                <asp:TextBox ID="POSTDATUMTextBox" runat="server" Text='<%# Bind("POSTDATUM") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /><br /></span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">TITEL:
                <asp:TextBox ID="TITELTextBox" runat="server" Text='<%# Bind("TITEL") %>' />
                <br />POSTDATUM:
                <asp:TextBox ID="POSTDATUMTextBox" runat="server" Text='<%# Bind("POSTDATUM") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /><br /></span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="">TITEL:
                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TITEL") %>' CommandName="Select"></asp:LinkButton>
                <br />
                POSTDATUM:
                <asp:Label ID="POSTDATUMLabel" runat="server" Text='<%# Eval("POSTDATUM") %>' />
                <br />
<br /></span>
            </ItemTemplate>
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="">TITEL:
                <asp:Label ID="TITELLabel" runat="server" Text='<%# Eval("TITEL") %>' />
                <br />
                POSTDATUM:
                <asp:Label ID="POSTDATUMLabel" runat="server" Text='<%# Eval("POSTDATUM") %>' />
                <br />
<br /></span>
            </SelectedItemTemplate>
         </asp:ListView>

             <asp:SqlDataSource ID="SqlDataSourcenieuws3dagen" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT b.TITEL,b.POSTDATUM FROM BERICHT b, NIEUWS n 
WHERE b.BERICHTID = n.BERICHTID AND b.POSTDATUM &gt;(sysdate-3)"></asp:SqlDataSource>
         

    </div>
</asp:Content>
