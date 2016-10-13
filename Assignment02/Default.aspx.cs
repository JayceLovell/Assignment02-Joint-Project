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
                var team1 = (from st in db.Team1
                            where st.GameID == 1
                            select st);
                var team2= (from st in db.Team2
                            where st.GameID == 1
                            select st);

                TeamName1lbl.Text = team1.FirstOrDefault().TEAMNAME.ToString();
                TeamName2lbl.Text = team2.FirstOrDefault().TEAMNAME.ToString();
                Game1Team1Score.Text= team1.FirstOrDefault().TEAMSCORE.ToString()+" runs / ";
                Game1Team1Outs.Text = team1.FirstOrDefault().BATSMANOUT.ToString()+" outs";
                Game1Team2Score.Text= team2.FirstOrDefault().TEAMSCORE.ToString()+" runs / ";
                Game1Team2Outs.Text = team2.FirstOrDefault().BATSMANOUT.ToString()+" outs";
                Game1Spectators.Text = team2.FirstOrDefault().SPECTATORS.ToString();

                
            }
        }
    }
}