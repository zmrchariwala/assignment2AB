using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class ShowTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tid = Request.QueryString["teacherid"];

            string query = "select * from TEACHERS where teacherid =" + tid + ";";

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                teacher_fname.InnerHtml = row["TEACHERFNAME"];
                teacher_lname.InnerHtml = row["TEACHERLNAME"];
                hire_date.InnerHtml = row["HIREDATE"];
                employee_number.InnerHtml = row["EMPLOYEENUMBER"];
                salary_amount.InnerHtml = row["SALARY"];
            }
        }
    }
}