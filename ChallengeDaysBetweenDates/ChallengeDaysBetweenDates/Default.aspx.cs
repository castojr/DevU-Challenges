using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime my1stCalendar = firstCalendar.SelectedDate;
            DateTime my2ndCalendar = secondCalendar.SelectedDate;
            TimeSpan span = new TimeSpan(my1stCalendar.Ticks - my2ndCalendar.Ticks);

            resultLabel.Text = span.Days.ToString().Replace("-", "");
        }
    }
}