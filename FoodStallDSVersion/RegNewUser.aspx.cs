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
                    if (ex is ArgumentException)
                        LabelError.Text = string.Format("Username already taken.\n Please choose a different Username. {0}", ex.ToString());
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
            ta.Fill(ds.Users);
            DataRow dr = ds.Users.NewRow();
            dr["userName"] = TextBoxUsername.Text;
            dr["password"] = TextBoxPw.Text;
            dr["personName"] = TextBoxName.Text;
            dr["personAddress"] = TextBoxAddress.Text;
            ds.Tables["Users"].Rows.Add(dr);
            ta.Update(ds.Users);
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