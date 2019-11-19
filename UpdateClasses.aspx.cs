﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class UpdateClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cid = Request.QueryString["classid"];

            string query = "select * from CLASSES where classid =" + cid + ";";

            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                class_code.Text = row["CLASSCODE"];
                start_date.Text = row["STARTDATE"];
                finish_date.Text = row["FINISHDATE"];
                class_name.Text = row["CLASSNAME"];
            }
        }
    }
}