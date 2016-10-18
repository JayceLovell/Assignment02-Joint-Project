using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements that are required to connect to EF DB
using Assignment02.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace Assignment02
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time
            //populate the student grid
            if(!IsPostBack)
            {
                Session["SortColumn"] = "GameID";//default sort colmn
                Session["SortDirection"] = "ASC";

                //Get the cricket games data
                this.GetGames();
            }
        }

        /// <summary>
        /// This method gets the game data from the DB
        /// </summary>
        private void GetGames()
        {
            // connect to EF DB
            using (CricketInfo db = new CricketInfo())
            {
                string SortString = Session["SortColumn"].ToString() + " " + 
                    Session["SortDirection"].ToString();

                // query the CricketInfo Table using EF and LINQ
                var Games = (from allGames in db.CricketInfoMains
                             select allGames);

                // bind the result to the Students GridView
                GamesGridView.DataSource = Games.AsQueryable().OrderBy(SortString).ToList();
                GamesGridView.DataBind();
            }
        }

        protected void PageSizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the new Page size
            GamesGridView.PageSize = Convert.ToInt32(PageSizeDropDownList.SelectedValue);

            // refresh the GridView

            this.GetGames();
        }

        protected void GamesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the new page number
            GamesGridView.PageIndex = e.NewPageIndex;

            // refresh the Gridview
            this.GetGames();
        }

        protected void GamesGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            // get the column to sort by
            Session["SortColumn"] = e.SortExpression;

            // refresh the GridView
            this.GetGames();

            // toggle the direction
            Session["SortDirection"] = Session["SortDirection"].ToString() == "ASC" ? "DESC" : "ASC";
        }

        protected void GamesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(IsPostBack)
            {
                if(e.Row.RowType == DataControlRowType.Header) // if header row has been clicked
                {
                    LinkButton linkbutton = new LinkButton();

                    for(int index = 0; index < GamesGridView.Columns.Count - 1; index++)
                    {
                        if(GamesGridView.Columns[index].SortExpression == Session["SortColumn"].ToString())
                        {
                            if(Session["SortDirection"].ToString() == "ASC")
                            {
                                linkbutton.Text = "<i class='fa fa-caret-up fa-lg'></i>";
                            }
                            else
                            {
                                linkbutton.Text = "<i class='fa fa-caret-down fa-lg'></i>";
                            }
                            e.Row.Cells[index].Controls.Add(linkbutton);
                        }
                    }
                }
            }
        }

        protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected GameId using the Grid's DataKey COllection
            int GameID = Convert.ToInt32(GamesGridView.DataKeys[selectedRow].Values["GameID"]);

            // use EF and LINQ to find the selected game in the DB and remove it
            using (CricketInfo db = new CricketInfo())
            {
                //create object to the game class and store the query inside of it
                CricketInfoMain deletedgame = (from gameRecords in db.CricketInfoMains
                                     where gameRecords.GameID == GameID
                                     select gameRecords).FirstOrDefault();

                // remove the selected game from teh db
                db.CricketInfoMains.Remove(deletedgame);

                //save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.GetGames();
            }
        }

        protected void Refreshing_ServerClick(object sender, EventArgs e)
        {
            this.GetGames();
        }
    }
}