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
                var team3 = (from st in db.Team1
                             where st.GameID == 2
                             select st);
                var team4 = (from st in db.Team2
                             where st.GameID == 2
                             select st);
                var team5 = (from st in db.Team1
                             where st.GameID == 3
                             select st);
                var team6 = (from st in db.Team2
                             where st.GameID == 3
                             select st);
                var team7 = (from st in db.Team1
                             where st.GameID == 4
                             select st);
                var team8 = (from st in db.Team2
                             where st.GameID == 4
                             select st);

                // First match data
                TeamName1lbl.Text = team1.FirstOrDefault().TEAMNAME.ToString();
                TeamName2lbl.Text = team2.FirstOrDefault().TEAMNAME.ToString();
                Game1Team1Score.Text = team1.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team1Outs.Text = team1.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Team2Score.Text = team2.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team2Outs.Text = team2.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Spectators.Text = team2.FirstOrDefault().SPECTATORS.ToString();

                // Second match data 
                TeamName1lbl1.Text = team3.FirstOrDefault().TEAMNAME.ToString();
                TeamName2lbl1.Text = team4.FirstOrDefault().TEAMNAME.ToString();
                Game1Team1Score1.Text = team3.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team1Outs1.Text = team3.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Team2Score1.Text = team4.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team2Outs1.Text = team4.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Spectators1.Text = team4.FirstOrDefault().SPECTATORS.ToString();

                //Third match data

                TeamName1lbl2.Text = team5.FirstOrDefault().TEAMNAME.ToString();
                TeamName2lbl2.Text = team6.FirstOrDefault().TEAMNAME.ToString();
                Game1Team1Score2.Text = team5.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team1Outs2.Text = team5.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Team2Score2.Text = team6.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team2Outs2.Text = team6.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Spectators2.Text = team6.FirstOrDefault().SPECTATORS.ToString();

                // Fourth match data

                TeamName1lbl3.Text = team7.FirstOrDefault().TEAMNAME.ToString();
                TeamName2lbl3.Text = team8.FirstOrDefault().TEAMNAME.ToString();
                Game1Team1Score3.Text = team7.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team1Outs3.Text = team7.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Team2Score3.Text = team8.FirstOrDefault().TEAMSCORE.ToString() + " runs / ";
                Game1Team2Outs3.Text = team8.FirstOrDefault().BATSMANOUT.ToString() + " outs";
                Game1Spectators3.Text = team8.FirstOrDefault().SPECTATORS.ToString();


            }
        }
    }
}