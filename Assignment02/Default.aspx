<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment02.Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h1>This Month Games</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h2>Game 1</h2>
                    <asp:Label ID="TeamName1lbl" runat="server"></asp:Label>
                <h3>VS</h3>
                    <asp:Label ID="TeamName2lbl" runat="server"></asp:Label>
                <h3>Score</h3>
                    <asp:Label ID="Game1Team1Score" runat="server"></asp:Label>
                    <asp:Label ID="Game1Team1Outs" runat="server"></asp:Label>
                <br />
                    <asp:Label ID="Game1Team2Score" runat="server"></asp:Label>
                    <asp:Label ID="Game1Team2Outs" runat="server"></asp:Label>
                <h3>Spectators</h3>
                    <asp:Label ID="Game1Spectators" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
