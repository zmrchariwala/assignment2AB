using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sid = Request.QueryString["studentid"];

            string query = "select * from STUDENTS where studentid =" + sid + ";";

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                student_fname.Text = row["STUDENTFNAME"];
                student_lname.Text = row["STUDENTLNAME"];
                student_number.Text = row["STUDENTNUMBER"];
                enrolment_date.Text = row["ENROLMENTDATE"];
            }
        }
    }
}