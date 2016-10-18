using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int rowid=1;
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
                for (int Slot = 1; Slot <= 4; Slot++)
                {
                    //run a loop to enter the data in each lable on the page
                    var Gameinfo = (from game in db.CricketInfoMains
                                    where game.GameID == rowid
                                    select game);
                    //put the information onto the main page
                    switch(Slot)
                    {
                        case 1:
                            // fill out game 1
                            Game1Team1Name.InnerText = Gameinfo.FirstOrDefault().Team_1_Name.ToString();
                            Game1Team1Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_1_Name.ToString() + ".jpg");
                            Game1Team1Outs.InnerText = Gameinfo.FirstOrDefault().Team_1_Outs.ToString();
                            Game1Team1Runs.InnerText = Gameinfo.FirstOrDefault().Team_1_Runs.ToString() + " runs/ ";
                            Game1Team2Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_2_Name.ToString() + ".jpg");
                            Game1Team2Name.InnerText = Gameinfo.FirstOrDefault().Team_2_Name.ToString();
                            Game1Team2Outs.InnerText = Gameinfo.FirstOrDefault().Team_2_Outs.ToString();
                            Game1Team2Runs.InnerText = Gameinfo.FirstOrDefault().Team_2_Runs.ToString() + " runs/ ";
                            Game1Spectators.InnerText = "Specators: "+Gameinfo.FirstOrDefault().Spectators.ToString();
                            break;
                        case 2:
                            // fill out game 2
                            Game2Team1Name.InnerText = Gameinfo.FirstOrDefault().Team_1_Name.ToString();
                            Game2Team1Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_1_Name.ToString() + ".jpg");
                            Game2Team1Outs.InnerText = Gameinfo.FirstOrDefault().Team_1_Outs.ToString();
                            Game2Team1Runs.InnerText = Gameinfo.FirstOrDefault().Team_1_Runs.ToString() + " runs/ ";
                            Game2Team2Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_2_Name.ToString() + ".jpg");
                            Game2Team2Name.InnerText = Gameinfo.FirstOrDefault().Team_2_Name.ToString();
                            Game2Team2Outs.InnerText = Gameinfo.FirstOrDefault().Team_2_Outs.ToString();
                            Game2Team2Runs.InnerText = Gameinfo.FirstOrDefault().Team_2_Runs.ToString() + " runs/ ";
                            Game2Spectators.InnerText = "Specators: " + Gameinfo.FirstOrDefault().Spectators.ToString();
                            break;
                        case 3:
                            // fill out game 3
                            Game3Team1Name.InnerText = Gameinfo.FirstOrDefault().Team_1_Name.ToString();
                            Game3Team1Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_1_Name.ToString() + ".jpg");
                            Game3Team1Outs.InnerText = Gameinfo.FirstOrDefault().Team_1_Outs.ToString();
                            Game3Team1Runs.InnerText = Gameinfo.FirstOrDefault().Team_1_Runs.ToString() + " runs/ ";
                            Game3Team2Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_2_Name.ToString() + ".jpg");
                            Game3Team2Name.InnerText = Gameinfo.FirstOrDefault().Team_2_Name.ToString();
                            Game3Team2Outs.InnerText = Gameinfo.FirstOrDefault().Team_2_Outs.ToString();
                            Game3Team2Runs.InnerText = Gameinfo.FirstOrDefault().Team_2_Runs.ToString() + " runs/ ";
                            Game3Spectators.InnerText = "Specators: " + Gameinfo.FirstOrDefault().Spectators.ToString();
                            break;
                        case 4:
                            //fil out game 4
                            Game4Team1Name.InnerText = Gameinfo.FirstOrDefault().Team_1_Name.ToString();
                            Game4Team1Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_1_Name.ToString() + ".jpg");
                            Game4Team1Outs.InnerText = Gameinfo.FirstOrDefault().Team_1_Outs.ToString();
                            Game4Team1Runs.InnerText = Gameinfo.FirstOrDefault().Team_1_Runs.ToString() + " runs/ ";
                            Game4Team2Logo.Src = ResolveUrl("Assets/Images/" + Gameinfo.FirstOrDefault().Team_2_Name.ToString() + ".jpg");
                            Game4Team2Name.InnerText = Gameinfo.FirstOrDefault().Team_2_Name.ToString();
                            Game4Team2Outs.InnerText = Gameinfo.FirstOrDefault().Team_2_Outs.ToString();
                            Game4Team2Runs.InnerText = Gameinfo.FirstOrDefault().Team_2_Runs.ToString() + " runs/ ";
                            Game4Spectators.InnerText = "Specators: " + Gameinfo.FirstOrDefault().Spectators.ToString();
                            break;
                    }
                    rowid++;
                }
                if(db.CricketInfoMains.Count()>rowid)
                {
                    NextButton.Disabled = false;
                }
                else
                {
                    NextButton.Disabled = true;
                }
                if(rowid<4)
                {
                    PreviousButton.Disabled = false;
                }
                else
                {
                    PreviousButton.Disabled = true;
                }
            }
        }

        protected void PreviousButton_ServerClick(object sender, EventArgs e)
        {
            rowid -= 4;
            GetGameData();
        }

        protected void NextButton_ServerClick(object sender, EventArgs e)
        {
            GetGameData();
        }
    }
}