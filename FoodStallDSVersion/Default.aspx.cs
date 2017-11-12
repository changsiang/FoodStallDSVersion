using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FoodStallDSVersion
{
    public partial class Default : System.Web.UI.Page
    {
        DataSet1 ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cnS = "Server=tcp:changsiangsqlserver.database.windows.net,1433;Initial Catalog=changsiangfooddb;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cn = new SqlConnection(cnS);
            SqlCommand cm = new SqlCommand("Select * from Users", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            ds = new DataSet1();
            da.Fill(ds, "Users");
            
        }
    }
}