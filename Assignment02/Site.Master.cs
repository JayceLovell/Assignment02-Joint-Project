using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and Owin Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Assignment02
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // show the user logged in
                    NotLoginHolder.Visible = false;
                    if (HttpContext.Current.User.IsInRole("Admin"))
                    {
                        name.Text = "Signed in as " + HttpContext.Current.User.Identity.Name.ToString()+"(Admin)";
                        Admins.Visible = true;
                    }
                    else
                    {
                        name.Text = "Signed in as " + HttpContext.Current.User.Identity.Name.ToString();
                    }
                }
                else
                {
                    // show user not logged in
                    NotLoginHolder.Visible = true;
                    LoginHolder.Visible = false;
                }
            }
            SetActivePage();
        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    NotLoginHolder.Visible = false;
                    break;
                case "About":
                    register.Attributes.Add("class", "active");
                    break;
                case "UserAccount":
                    register.Attributes.Add("class", "active");
                    break;
                case "AdminPage":
                    register.Attributes.Add("class", "active");
                    break;
            }
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // search for and create a new user object
            var user = userManager.Find(Usernametxt.Text, Passwordtxt.Text);

            // if a match is found for the user
            if (user != null)
            {
                // authenticate and login our user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // sign in the user
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                // redirect the user to the main menu
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                LoginButton.Text = "Error";
            }
        }
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            // store session info and authenication methods in teh authenticationmanager object
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // perferorm sign out
            authenticationManager.SignOut();

            //Redirect the user to the Login Page
            Response.Redirect("~/Default.aspx");
        }
    }
}