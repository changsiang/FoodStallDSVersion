using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FoodStallDSVersion.DataSet1TableAdapters;

namespace FoodStallDSVersion
{
    public partial class RegNewUser : System.Web.UI.Page
    {
        DataSet1 ds = new DataSet1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (IsNotNull(TextBoxName.Text) == true
                && IsNotNull(TextBoxPw.Text) == true
                && IsNotNull(TextBoxName.Text) == true
                && IsNotNull(TextBoxAddress.Text) == true)
            {
                try
                {
                    CreateNewUser();
                }
                catch (Exception ex)
                {
                    if (ex is DBConcurrencyException)
                        LabelError.Text = string.Format("Username already taken.\n Please choose a different Username.");
                    else
                        LabelError.Text = string.Format("General Error!!\n {0}", ex.ToString());

                }
            }
            else
            {
                LabelError.Text = "Error! Please enter the information for all fields.";
            }

        }

        protected void CreateNewUser()
        {
            UsersTableAdapter ta = new UsersTableAdapter();
            DataSet1.UsersDataTable users = new DataSet1.UsersDataTable();
            ta.Fill(users);
            DataRow dr = users.NewRow();
            dr["userName"] = TextBoxUsername.Text;
            dr["password"] = TextBoxPw.Text;
            dr["personName"] = TextBoxName.Text;
            dr["Address"] = TextBoxAddress.Text;
            ds.Tables["Users"].Rows.Add(dr);
            ta.Update(users);
            LabelError.Text = "Account Created Successfully";
            Response.Redirect("Default.aspx");
        }

        protected bool IsNotNull(string s)
        {
            if (s != "")
                return true;
            else
                return false;
        }


    }

}