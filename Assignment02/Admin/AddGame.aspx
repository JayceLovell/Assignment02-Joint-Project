<%@ Page Title="Admin Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddGame.aspx.cs" Inherits="Assignment02.Admin.AddGame" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-4 text-center">
                <h1>Add more Games</h1>
                <h5>Make sure you fill all fields Admin.</h5>
                <br />

                <div class="form-group">
                    <label class="control-label" for="Team1Name">Team1 Name:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team1Name"
                        required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Team2Name">Team2 Name:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team2Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Team1Runs">Team1 Runs:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team1Runs" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Team2Runs">Team2 Runs:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team2Runs" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Team1Out">Team1 Out:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team1Out" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Team2Out">Team2 Out:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team2Out" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Spectators">Spectators: </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Spectators" required="true"></asp:TextBox>
                </div>
                <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                <asp:Button Text="Add Game" ID="AddGameButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="AddGameButton_Click" />
            </div>
        </div>
    </div>
</asp:Content>
