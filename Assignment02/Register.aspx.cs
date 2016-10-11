using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statemetns that are required to connect to EF DB
using Assignment02.Models;
using System.Web.ModelBinding;

namespace Assignment02
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            // Use EF to conect to the server
            using (CricketInfo db = new CricketInfo())
            {
                // use the Account model to create a new Account object and 
                // save a new record
                Account newAccount = new Account();

                int Id = 0;

                if (Request.QueryString.Count > 0) // our URL has a ID in it
                {
                    // get the id from the URL
                }

                // add form data to the new student record
                newAccount.UserName = UserNameTextBox.Text;
                newAccount.Password = PasswordTextBox.Text;
                newAccount.Email = EmailTextBox.Text;
                newAccount.D_O_B = Convert.ToDateTime(DOBTextBox.Text);
                newAccount.Gender = GenderRadioButtons.SelectedValue.ToString();

                // use LINQ to ADO.NEt to add/insert the account into the db

                if(Id==0)
                {
                    db.Accounts.Add(newAccount);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updates Main page
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the Main page
            Response.Redirect("~/Default.aspx");
        }
    }
}