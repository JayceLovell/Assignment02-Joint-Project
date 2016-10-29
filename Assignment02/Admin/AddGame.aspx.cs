using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements required for EF DB access
using Assignment02.Models;
using System.Web.ModelBinding;

namespace Assignment02.Admin
{
    public partial class AddGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGameData();
            }
        }

        protected void GetGameData()
        {
            // populate the form with existing data from db
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            // connect to the EF DB
            using (CricketInfo db = new CricketInfo())
            {
                // populate a student object instance with the GameID from the URL parameter
                CricketInfoMain updatedGame = (from game in db.CricketInfoMains
                                               where game.GameID == GameID
                                               select game).FirstOrDefault();
                
                //map the game properties to teh form control
                if(updatedGame != null)
                {
                    Team1Name.Text = updatedGame.Team_1_Name;
                    Team1Out.Text = updatedGame.Team_1_Outs.ToString();
                    Team1Runs.Text = updatedGame.Team_1_Runs.ToString();
                    Team2Name.Text = updatedGame.Team_2_Name;
                    Team2Out.Text = updatedGame.Team_2_Outs.ToString();
                    Team2Runs.Text = updatedGame.Team_2_Runs.ToString();
                    Spectators.Text = updatedGame.Spectators.ToString();
                    AddGameButton.Text = "Update Game";
                }              
            }
        }
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Redirect back to the GameList
            Response.Redirect("~/Admin/AdminPage");
        }

        protected void AddGameButton_Click(object sender, EventArgs e)
        {
            // connect to the EF DB
            using (CricketInfo db = new CricketInfo())
            {
                // use the cricket model to create a new student object and save a new record

                CricketInfoMain newGame = new CricketInfoMain();

                int GameID = 0;

                if (Request.QueryString.Count > 0)// our URL has a GameId in it
                {
                    //get the id from teh URL
                    GameID = Convert.ToInt32(Request.QueryString["GameID"]);

                    // get the current game from EF db
                    newGame = (from game in db.CricketInfoMains
                               where game.GameID == GameID
                               select game).FirstOrDefault();
                }

                // add form data to the new stuent record
                newGame.Team_1_Name = Team1Name.Text;
                newGame.Team_1_Outs = Convert.ToInt32(Team1Out.Text);
                newGame.Team_1_Runs = Convert.ToInt32(Team1Runs.Text);
                newGame.Team_2_Name = Team2Name.Text;
                newGame.Team_2_Outs = Convert.ToInt32(Team2Out.Text);
                newGame.Team_2_Runs = Convert.ToInt32(Team2Runs.Text);
                newGame.Spectators = Convert.ToInt32(Spectators.Text);
                newGame.DateEntered = DateTime.Now;

                // use LINQ to ADO.NET to add / insert new game into the db

                if (GameID == 0)
                {
                    db.CricketInfoMains.Add(newGame);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                //Redirect back to the GameList
                Response.Redirect("~/Admin/AdminPage");
            }
        }
    }
}