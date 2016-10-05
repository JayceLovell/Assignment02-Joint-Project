using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment02
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
                    /*case "Products":
                        products.Attributes.Add("class", "active");
                        break;
                    case "Services":
                        services.Attributes.Add("class", "active");
                        break;
                    case "About":
                        about.Attributes.Add("class", "active");
                        break;
                    case "Contact":
                        contact.Attributes.Add("class", "active");
                        break;*/
            }
        }
    }
}