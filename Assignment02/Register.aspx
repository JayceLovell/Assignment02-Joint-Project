<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment02.Register" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4">
                <h1>Registering</h1>
                <br />
                <div class="form-group">
                    <label class="control-label" for="UsernameTextBox">User</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" 
                        placeholder="User name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="PasswordTextBox">Password</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="PasswordTextBox" 
                        TextMode="Password" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="ConfirmPasswordTextBox">Confirm Password</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="ConfirmPasswordTextBox"
                        TextMode="Password" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GenderRadioButtons">Gender</label>
                       <asp:RadioButtonList ID="GenderRadioButtons" runat="server">
                           <asp:ListItem Text="Male" Value="M"></asp:ListItem>
                           <asp:ListItem Text="Female" Value="F"></asp:ListItem>
                       </asp:RadioButtonList>
                </div>
                <div class="form-group">
                    <label class="control-label" for="EmailTextBox">Email Address</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="EmailTextBox"
                        placeholder="example@example.com" TextMode="Email" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="DOBTextBox">Date Of Birth</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DOBTextBox"
                        placeholder="1999/01/01" TextMode="Date" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button Text="Register" ID="RegisterButton" CssClass="btn btn-success btn-lg" runat="server" OnClick="RegisterButton_Click" />
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-danger btn-lg" runat="server" OnClick="CancelButton_Click" />
                </div>
            </div>
        </div>
     </div>
</asp:Content>
