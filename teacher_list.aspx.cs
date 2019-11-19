using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class teacher_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            teacher_result.InnerHtml = "";

            string searchkey = "";
            string query = "";
            if (IsPostBack)
            {
                searchkey = teacher_search.Text;
            }
            if (searchkey == "" || searchkey == null)
            {
                query = "select * from TEACHERS;";
            }
            else
            {
                query = "select * from TEACHERS where TEACHERFNAME LIKE '%"+ searchkey +"%' OR TEACHERLNAME LIKE '%"+ searchkey +"%' OR EMPLOYEENUMBER LIKE '%"+ searchkey +"%' OR HIREDATE LIKE '%"+ searchkey +"%' OR SALARY LIKE '%"+ searchkey +"%';";
            }

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                teacher_result.InnerHtml += "<div class=\"listitem\">";

                string teacherid = row["TEACHERID"];

                string teacherfirstname = row["TEACHERFNAME"];
                teacher_result.InnerHtml += "<div class=\"cul1\"><a href=\"Showteachers.aspx?teacherid=" + teacherid + "\">" + teacherfirstname + "</a></div>";

                string teacherlastname = row["TEACHERLNAME"];
                teacher_result.InnerHtml += "<div class=\"cul2\">" + teacherlastname + "</div>";

                string teacheremployeenumber = row["EMPLOYEENUMBER"];
                teacher_result.InnerHtml += "<div class=\"cul2\">" + teacheremployeenumber + "</div>";

                string hiredate = row["HIREDATE"];
                teacher_result.InnerHtml += "<div class=\"cul2\">" + hiredate + "</div>";

                string salary = row["SALARY"];
                teacher_result.InnerHtml += "<div class=\"cul2\">" + salary + "</div>";

                teacher_result.InnerHtml += "<div class=\"cul2\"><a href=\"UpdateTeacher.aspx?teacherid=" + teacherid + "\">Update</a>/<a href=\"DeleteTeacher.aspx?teacherid=" + teacherid + "\">Delete</a></div>";
                teacher_result.InnerHtml += "</div>";
            }
        }
    }
}