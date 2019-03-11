using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        public static List<ContestCapture> entryCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if(!Page.IsPostBack)
            {
                entryCollection = new List<ContestCapture> contestCaptures();//whoops
            }
        }          

        protected void Submit_Click(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.ClearSelection();
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Terms.Checked = false;
            CheckAnswer.Text = "";
        }

        
    }
}