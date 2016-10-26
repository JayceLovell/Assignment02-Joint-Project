<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment02.Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid text-center">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h1>This Month Games</h1>
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div id="Game1" class="col-md-offset-1 col-md-4">
                <img runat="server" id="Game1Team1Logo" alt="Team1 Logo" src="Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game1Team1Name" runat="server">No Info</label>
                <h3> VS </h3>
                <img runat="server" id="Game1Team2Logo" alt="Team2 Logo" src="~/Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game1Team2Name" runat="server">No Info</label>
                <h4> Statistics: </h4>
                <label class="control-label" id="Game1Team1Runs" runat="server">No Info</label>
                <label class="control-label" id="Game1Team1Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game1Team2Runs" runat="server">No Info</label>
                <label class="control-label" id="Game1Team2Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game1Spectators" runat="server"></label>
                <h4><i class="fa fa-trophy" aria-hidden="true"></i> Winner <i class="fa fa-trophy" aria-hidden="true"></i></h4>
                <label class="control-label" id="Game1Winner" runat="server"></label>
            </div>    
            <div id="Game2" class="col-md-offset-1 col-md-4">
                <img runat="server" id="Game2Team1Logo" alt="Team1 Logo" src="Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game2Team1Name" runat="server">No Info</label>
                <h3> VS </h3>
                <img runat="server" id="Game2Team2Logo" alt="Team2 Logo" src="~/Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game2Team2Name" runat="server">No Info</label>
                <h4> Statistics: </h4>
                <label class="control-label" id="Game2Team1Runs" runat="server">No Info</label>
                <label class="control-label" id="Game2Team1Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game2Team2Runs" runat="server">No Info</label>
                <label class="control-label" id="Game2Team2Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game2Spectators" runat="server"></label>
                <h4><i class="fa fa-trophy" aria-hidden="true"></i> Winner <i class="fa fa-trophy" aria-hidden="true"></i></h4>
                <label class="control-label" id="Game2Winner" runat="server"></label>
            </div>
        </div>
        <br />
        <div class="row">
            <div id="Game3" class="col-md-offset-1 col-md-4">
                <img runat="server" id="Game3Team1Logo" alt="Team1 Logo" src="Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game3Team1Name" runat="server">No Info</label>
                <h3> VS </h3>
                <img runat="server" id="Game3Team2Logo" alt="Team2 Logo" src="~/Assets/Images/No-Image.jpg" />
                <label class="control-label" id="Game3Team2Name" runat="server">No Info</label>
                <h4> Statistics: </h4>
                <label class="control-label" id="Game3Team1Runs" runat="server">No Info</label>
                <label class="control-label" id="Game3Team1Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game3Team2Runs" runat="server">No Info</label>
                <label class="control-label" id="Game3Team2Outs" runat="server">No Info</label>
                <br />
                <label class="control-label" id="Game3Spectators" runat="server"></label>
                <h4><i class="fa fa-trophy" aria-hidden="true"></i> Winner <i class="fa fa-trophy" aria-hidden="true"></i></h4>
                <label class="control-label" id="Game3Winner" runat="server"></label>
                </div>
                <div id="Game4" class="col-md-offset-1 col-md-4">
                    <img runat="server" id="Game4Team1Logo" alt="Team1 Logo" src="Assets/Images/No-Image.jpg" />
                    <label class="control-label" id="Game4Team1Name" runat="server">No Info</label>
                    <h3> VS </h3>
                    <img runat="server" id="Game4Team2Logo" alt="Team2 Logo" src="~/Assets/Images/No-Image.jpg" />
                    <label class="control-label" id="Game4Team2Name" runat="server">No Info</label>
                    <h4> Statistics: </h4>
                    <label class="control-label" id="Game4Team1Runs" runat="server">No Info</label>
                    <label class="control-label" id="Game4Team1Outs" runat="server">No Info</label>
                    <br />
                    <label class="control-label" id="Game4Team2Runs" runat="server">No Info</label>
                    <label class="control-label" id="Game4Team2Outs" runat="server">No Info</label>
                    <br />
                    <label class="control-label" id="Game4Spectators" runat="server"></label>
                    <h4><i class="fa fa-trophy" aria-hidden="true"></i> Winner <i class="fa fa-trophy" aria-hidden="true"></i></h4>
                    <label class="control-label" id="Game4Winner" runat="server"></label>
                </div>
            </div>
        <br />
        <div class="row">
            <div class="col-md-offset-1 col-md-4">
                <button class="btn btn-lg btn-block" disabled="disabled" runat="server" id="PreviousButton" onserverclick="PreviousButton_ServerClick" title="To load last month games"><i class="fa fa-backward" aria-hidden="true"></i> Previous</button>
            </div>
            <div class="col-md-offset-1 col-md-4">
                <button class="btn btn-lg btn-block" disabled="disabled" runat="server" id="NextButton" onserverclick="NextButton_ServerClick" title="To load next month games"><i class="fa fa-forward" aria-hidden="true"></i> Next</button>
                
            </div>
        </div>
    </div>
</asp:Content>