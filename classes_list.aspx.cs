using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2ab
{
    public partial class classes_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            classes_result.InnerHtml = "";

            string searchkey = "";
            string query="";
            if (IsPostBack)
            {
                searchkey = classes_search.Text;
            }
            if (searchkey == "" || searchkey == null)
            {
                query = "select * from CLASSES;";
            }
            else
            {
                query="select * from CLASSES where CLASSCODE like '%"+searchkey+"%' OR STARTDATE like '%"+searchkey+"%' OR FINISHDATE = '%"+searchkey+"%' OR CLASSNAME like '%"+searchkey+"%';";
            }
            var db = new DATABASE();
            List<Dictionary<String, String>> rs = db.showdata(query);

            foreach (Dictionary<String, String> row in rs)
            {
                classes_result.InnerHtml += "<div class=\"listitem\">";

                string classid = row["CLASSID"];

                string classcode = row["CLASSCODE"];
                classes_result.InnerHtml += "<div class=\"cul1\"><a href=\"ShowClasses.aspx?classid=" + classid + "\">" + classcode + "</a></div>";

                string startdate = row["STARTDATE"];
                classes_result.InnerHtml += "<div class=\"cul2\">" + startdate + "</div>";

                string finishdate = row["FINISHDATE"];
                classes_result.InnerHtml += "<div class=\"cul2\">" + finishdate + "</div>";

                string classname = row["CLASSNAME"];
                classes_result.InnerHtml += "<div class=\"cul2\">" + classname + "</div>";
                classes_result.InnerHtml += "<div class=\"cul2\"><a href=\"UpdateClasses.aspx?classid="+ classid + "\">Update</a>/<a href=\"DeleteClasses.aspx?classid=" + classid + "\">Delete</a></div>";

                classes_result.InnerHtml += "</div>";
            }
        }
    }
}