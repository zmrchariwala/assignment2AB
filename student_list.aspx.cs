using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            students_result.InnerHtml = "";

            string searchkey = "";
            string query;
            if(IsPostBack)
            {
               searchkey = student_search.Text;
            }
            if (searchkey == "" || searchkey == null)
            {
                query = "select * from STUDENTS;";
            }
            else
            {
                query = "select * from STUDENTS where STUDENTFNAME LIKE '%"+ searchkey +"%' OR STUDENTLNAME LIKE '%"+ searchkey + "%' OR STUDENTNUMBER LIKE '%"+ searchkey + "%' OR ENROLMENTDATE LIKE '%"+ searchkey + "%';";
                
            }

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                students_result.InnerHtml += "<div class=\"listitem\">";

                string studentid = row["STUDENTID"];

                string studentfirstname = row["STUDENTFNAME"];
                students_result.InnerHtml += "<div class=\"cul1\"><a href=\"ShowStudent.aspx?studentid=" + studentid + "\">" + studentfirstname + "</a></div>";

                string studentlastname = row["STUDENTLNAME"];
                students_result.InnerHtml += "<div class=\"cul2\">" + studentlastname + "</div>";

                string studentnumber = row["STUDENTNUMBER"];
                students_result.InnerHtml += "<div class=\"cul2\">" + studentnumber + "</div>";

                string enrolmentdate = row["ENROLMENTDATE"];
                students_result.InnerHtml += "<div class=\"cul2\">" + enrolmentdate + "</div>";

                students_result.InnerHtml += "</div>";
            }
        }
    }
}