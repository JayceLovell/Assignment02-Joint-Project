<%@ Page Title="Admin Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Assignment02.AdminPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <h1>List of Games</h1>
                <a href="AddGame.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus" aria-hidden="true"></i> Add Game</a>

                <div>
                    <label for="PageSizeDropDownList">Games per Page:</label>
                    <asp:DropDownList ID="PageSizeDropDownList" runat="server" 
                        AutoPostBack="true" CssClass="btn btn-default btn-sm dropdown-toggle" 
                        OnSelectedIndexChanged="PageSizeDropDownList_SelectedIndexChanged">
                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                        <asp:ListItem Text="8" Value="8"></asp:ListItem>
                        <asp:ListItem Text="12" Value="12"></asp:ListItem>
                        <asp:ListItem Text="All" Value="10000"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:GridView ID="GamesGridView" runat="server" AutoGenerateColumns="false" 
                    CssClass="table table-bordered table-hover" BackColor="White" DataKeyNames="GameID" 
                    OnRowDeleting="GamesGridView_RowDeleting" AllowPaging="true" PageSize="4" 
                    OnPageIndexChanging="GamesGridView_PageIndexChanging" AllowSorting="true" 
                    OnSorting="GamesGridView_Sorting" OnRowDataBound="GamesGridView_RowDataBound" 
                    PagerStyle-CssClass="pagination-ys">
                    <Columns>
                        <asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="true" SortExpression="GameID" />
                        <asp:BoundField DataField="Team_1_Name" HeaderText="Team1 Name" Visible="true" SortExpression="Team_1_Name" />
                        <asp:BoundField DataField="Team_2_Name" HeaderText="Team2 Name" Visible="true" SortExpression="Team_2_Name" />
                        <asp:BoundField DataField="Team_1_Runs" HeaderText="Team1 Runs" Visible="true" SortExpression="Team_1_Runs"/>
                        <asp:BoundField DataField="Team_2_Runs" HeaderText="Team2 Runs" Visible="true" SortExpression="Team_2_Runs"/>
                        <asp:BoundField DataField="Team_1_Outs" HeaderText="Team1 Outs" Visible="true" SortExpression="Team_1_Outs"/>
                        <asp:BoundField DataField="Team_2_Outs" HeaderText="Team2 Outs" Visible="true" SortExpression="Team_2_Outs"/>
                        <asp:BoundField DataField="Spectators" HeaderText="Spectators" Visible="true" SortExpression="Spectators"/>
                        <asp:BoundField DataField="DateEntered" HeaderText="Date Entered" Visible="true" SortExpression="DateEntered"/>
                        <asp:HyperLinkField Headertext="Update" Text="<i class='fa fa-pencil-square-o' aria-hidden='true'></i>Update"
                             NavigateUrl="~/Admin/AddGame.aspx" ControlStyle-CssClass="btn btn-warning btn-sm"
                             runat="server" DataNavigateUrlFields="GameID"
                             DataNavigateUrlFormatString="AddGame.aspx?GameID={0}" />
                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
                <a class="btn btn-primary btn-lg" id="BackUp" onserverclick="BackUp_ServerClick" runat="server" UseSubmitBehavior="false" CausesValidation="false"><i class="fa fa-cog fa-spin fa-refresh"></i> BackUp</a>
            </div>
        </div>
    </div>
</asp:Content>
