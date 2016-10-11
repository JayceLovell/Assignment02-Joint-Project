using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements that are required to connect to EF DB
using Assignment02.Models;
using System.Web.ModelBinding;

namespace Assignment02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for teh first time
            // populate the Game Page
            if(!IsPostBack)
            {
                //Get the Game data
                this.GetGameData();
            }
        }

        /// <summary
        /// This method gets the game data from the DB
        /// </summary
        private void GetGameData()
        {
            // connect to EF DB
            using (CricketInfo db = new CricketInfo())
            {
                // query the Team1 table using the EF and LINQ
            }
        }
    }
}