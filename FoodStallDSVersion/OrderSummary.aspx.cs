using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodStallDSVersion
{
    public partial class OrderSummary : System.Web.UI.Page
    {
        DataSet1 ds = new DataSet1();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.OrdersTableAdapter ta = new DataSet1TableAdapters.OrdersTableAdapter();
            ta.Fill(ds.Orders);

            GridView1.DataSource = ds.Orders;
            GridView1.DataBind();

        }
    }
}