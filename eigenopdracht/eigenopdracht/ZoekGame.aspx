<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ZoekGame.aspx.cs" Inherits="eigenopdracht.ZoekGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class ="row" style="padding-top: 20px">
    <div class = "col-md-3">
        <asp:TextBox ID="txtZoekGame" runat="server"></asp:TextBox>
        <asp:Button ID="btnZoekGame" runat="server" Text="Button" OnClick="btnZoekGame_Click" />
        
    </div>
    <div class = "col-md-9">
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT &quot;TITEL&quot;, &quot;GENRE&quot;, &quot;PLATFORM&quot;, &quot;RELEASEDATUM&quot; FROM &quot;GAME&quot;"></asp:SqlDataSource>

        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged1" DataKeyNames ="TITEL" >
            
            <AlternatingItemTemplate>
                
                <span style="background-color: #FFF8DC;">TITEL:
                <asp:LinkButton ID="linktitel" runat="server"  Text= '<%# Eval("TITEL") %>' CommandName="Select"></asp:LinkButton>
                <br />
                GENRE:
                <asp:Label ID="GENRELabel" runat="server" Text='<%# Eval("GENRE") %>' />
                <br />
                PLATFORM:
                <asp:Label ID="PLATFORMLabel" runat="server" Text='<%# Eval("PLATFORM") %>' />
                <br />
                RELEASEDATUM:
                <asp:Label ID="RELEASEDATUMLabel" runat="server" Text='<%# Eval("RELEASEDATUM") %>' />
                <br />
                <br />
                </span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="background-color: #008A8C;color: #FFFFFF;">TITEL:
                <asp:TextBox ID="TITELTextBox" runat="server" Text='<%# Bind("TITEL") %>' />
                <br />
                GENRE:
                <asp:TextBox ID="GENRETextBox" runat="server" Text='<%# Bind("GENRE") %>' />
                <br />
                PLATFORM:
                <asp:TextBox ID="PLATFORMTextBox" runat="server" Text='<%# Bind("PLATFORM") %>' />
                <br />
                RELEASEDATUM:
                <asp:TextBox ID="RELEASEDATUMTextBox" runat="server" Text='<%# Bind("RELEASEDATUM") %>' />
                <br />
                <asp:Button ID="Button2" runat="server" Text='<%# Eval("TITEL") %>' />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <br />
                <br />
                </span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">TITEL:
                <asp:TextBox ID="TITELTextBox" runat="server" Text='<%# Bind("TITEL") %>' />
                <br />
                GENRE:
                <asp:TextBox ID="GENRETextBox" runat="server" Text='<%# Bind("GENRE") %>' />
                <br />
                PLATFORM:
                <asp:TextBox ID="PLATFORMTextBox" runat="server" Text='<%# Bind("PLATFORM") %>' />
                <br />
                RELEASEDATUM:
                <asp:TextBox ID="RELEASEDATUMTextBox" runat="server" Text='<%# Bind("RELEASEDATUM") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br />
                <br />
                </span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="background-color: #DCDCDC;color: #000000;">
                    
                
                TITEL:
                <asp:LinkButton ID="linktitel1" runat="server"  Text= '<%# Eval("TITEL") %>' CommandName="Select"></asp:LinkButton>
                <br />
                GENRE:
                <asp:Label ID="GENRELabel" runat="server" Text='<%# Eval("GENRE") %>' />
                <br />
                PLATFORM:
                <asp:Label ID="PLATFORMLabel" runat="server" Text='<%# Eval("PLATFORM") %>' />
                <br />
                RELEASEDATUM:
                <asp:Label ID="RELEASEDATUMLabel" runat="server" Text='<%# Eval("RELEASEDATUM") %>' />
                <br />
                <br />
                </span>
            </ItemTemplate>
            <LayoutTemplate>
                 <div><asp:LinkButton ID=sortabc runat="server" CommandName="SORT" CommandArgument="TITEL">Sort abc</asp:LinkButton> <asp:LinkButton ID="sortdate" runat="server" CommandName="SORT" CommandArgument="RELEASEDATUM">Sort datum</asp:LinkButton></div>
                <div><span runat="server" id="itemPlaceholder" /></div>
               
                <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                    
                    <asp:DataPager ID="DataPager1" runat="server">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">TITEL:
                <asp:Label ID="TITELLabel" runat="server" Text='<%# Eval("TITEL") %>' />
                <br />
                GENRE:
                <asp:Label ID="GENRELabel" runat="server" Text='<%# Eval("GENRE") %>' />
                <br />
                PLATFORM:
                <asp:Label ID="PLATFORMLabel" runat="server" Text='<%# Eval("PLATFORM") %>' />
                <br />
                RELEASEDATUM:
                <asp:Label ID="RELEASEDATUMLabel" runat="server" Text='<%# Eval("RELEASEDATUM") %>' />
                <br />
                <br />
                </span>
            </SelectedItemTemplate>
        </asp:ListView>

    </div>


</div>










</asp:Content>
