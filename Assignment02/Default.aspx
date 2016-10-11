<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment02.Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h1>This Month Games</h1>
            </div>
        </div>
        <div class="row topborder leftborder rightborder">
            <div class="col-md-4">
                <h3>Game 1</h3>
                <asp:Label Text="Team:" runat="server" For="TeamName1"></asp:Label>
                    <asp:Label ID="TeamName1" runat="server"></asp:Label>
            </div>
            <div class="col-md-offset-4 col-md-4">
                <h3>Game 2</h3>
                <asp:Label Text="Team:" runat="server" For="TeamName3"></asp:Label>
                    <asp:Label ID="TeamName3" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
