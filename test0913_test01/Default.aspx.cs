using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace test0913_test01 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string cnString = @"Server=.\SQLExpress;database=Northwind;uid=sa;password=P@ssw0rd";
            SqlConnection cn = new SqlConnection(cnString);
            cn.Open();
            string ComText = "select * from Products";
            SqlCommand cmd = new SqlCommand(ComText,cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                Response.Write("產品名稱: " + dr["ProductName"] + "<br/>");
                //Response.Write(dr["UnitsInStock"]);
            }
            cmd.Cancel();
            dr.Close();
            cn.Close();
        }
    }
}