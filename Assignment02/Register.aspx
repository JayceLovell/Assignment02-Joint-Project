<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment02.Register" UnobtrusiveValidationMode="None" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h1>Registering</h1>
                <br />
                <div class="alert alert-danger" id="AlertFlash" runat="server" visible="false">
                    <asp:Label runat="server" ID="StatusLabel"></asp:Label>
                </div>
                <div class="form-group">
                    <label class="control-label" for="UsernameTextBox">User:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" placeholder="User name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                            <label class="control-label" for="PasswordTextBox">Password:</label>
                            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true" TabIndex="0"></asp:TextBox>
                </div>

                <div class="form-group">
                            <label class="control-label" for="ConfirmPasswordTextBox">Confirm:</label>
                            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="ConfirmPasswordTextBox" placeholder="Confirm Password" required="true" TabIndex="0"></asp:TextBox>
                            <asp:CompareValidator ErrorMessage="Your Passwords Must Match" Type="String" Operator="Equal"  ControlToValidate="ConfirmPasswordTextBox" runat="server"
                                ControlToCompare="PasswordTextBox" CssClass="label label-danger" />
                </div>
                <div class="form-group">
                    <label class="control-label" for="EmailTextBox">Email Address:</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="EmailTextBox"
                        placeholder="example@example.com" TextMode="Email" required="true"></asp:TextBox>
                </div>
                <div class="form-group text-center">
                    <asp:Button Text="Register" ID="RegisterButton" CssClass="btn btn-success btn-lg" runat="server" OnClick="RegisterButton_Click" />
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-danger btn-lg" runat="server" OnClick="CancelButton_Click" />
                </div>
            </div>
        </div>
     </div>
</asp:Content>