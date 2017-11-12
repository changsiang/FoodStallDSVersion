using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using FoodStallDSVersion.DataSet1TableAdapters;

namespace FoodStallDSVersion
{
    public partial class Default : System.Web.UI.Page
    {
        DataSet1 ds = new DataSet1();
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        protected void BtnReg_Click(object sender, EventArgs e)
        {
            Server.Transfer("RegNewUser.aspx", true);
        }

        protected void ButtonSummary_Click(object sender, EventArgs e)
        {
            Server.Transfer("OrderSummary.aspx", true);
        }

        protected void Login()
        {
            UsersTableAdapter ta = new UsersTableAdapter();
            DataSet1.UsersDataTable userDataTable = new DataSet1.UsersDataTable();
            ta.Fill(userDataTable);
            string passWord = (userDataTable.AsEnumerable().Where(x => x.userName == TextBoxUser.Text).Select(x => x.password.ToString()).First());
            try
            {             
                if(TextBoxPw.Text == passWord)
                {
                    Session["UserName"] = TextBoxUser.Text;
                    Session["PersonName"] = (userDataTable.AsEnumerable().Where(x => x.userName == TextBoxUser.Text).Select(x => x.personName.ToString()).First());
                    Response.Redirect("OrderPage.aspx", true);
                }
            }
            catch (Exception ex)
            {
                LabelAlert.Text = string.Format("Invalid Login Username/Password. Please try again! \n {0}", ex.ToString());
            }
        }


    }
}