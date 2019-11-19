using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class UpdateTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tid = Request.QueryString["teacherid"];

            string query = "select * from TEACHERS where teacherid =" + tid + ";";

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                teacher_fname.Text = row["TEACHERFNAME"];
                teacher_lname.Text = row["TEACHERLNAME"];
                hire_date.Text = row["HIREDATE"];
                employee_number.Text = row["EMPLOYEENUMBER"];
                salary_amount.Text = row["SALARY"];
            }
        }
    }
}