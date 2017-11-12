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

    public partial class OrderPage : System.Web.UI.Page
    {
        DataSet1 ds = new DataSet1();
        public string personName { get; set; }
        public string userName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            userName = (string)(Session["UserName"]);
            personName = (string)(Session["PersonName"]);
            if (!IsPostBack)
                CheckInvalidEntry(userName);
                
        }
        //This will check for inproper entry to the OrderPage.aspx
        //User are expected to login via Default.aspx and validate infomation on that Page
        protected void CheckInvalidEntry(string s)
        {
            if (s == null)
                Server.Transfer("Default.aspx");
            else
                TxtBoxName.Text = personName;
        }

        protected void CheckPrice()
        {
            Food_DishesTableAdapter ta = new Food_DishesTableAdapter();
            SizesTableAdapter sizeta = new SizesTableAdapter();
            DataSet1.Food_DishesDataTable foodDishes = new DataSet1.Food_DishesDataTable();
            DataSet1.SizesDataTable sizes = new DataSet1.SizesDataTable();
            ta.Fill(foodDishes);
            sizeta.Fill(sizes);
            decimal? foodPrice = foodDishes.AsEnumerable().Where(x => x.dishName == DdlFoodChoice.SelectedValue).Select(x => x.price).First();
            decimal? sizePrice = sizes.AsEnumerable().Where(x => x.sizeOption == DddlSizeOption.SelectedValue).Select(x => x.price).First();
            double price = Convert.ToDouble(foodPrice + sizePrice);
            LabelPrice.Text = string.Format("${0:.##}", price);
        }

        protected void SubmitOrder()
        {


            if (IsNotNull(txtBoxStreetName.Text) == true
                && IsNotNull(TxtBoxUnit.Text) == true
                && IsNotNull(TxtBoxPostal.Text) == true)
            {
                string spiceOption = "";
                foreach (ListItem o in CheckBoxSpice.Items)
                {

                    if (o.Selected)
                        spiceOption += " " + o.Value.ToString();
                }
                OrdersTableAdapter orderta = new OrdersTableAdapter();
                orderta.Fill(ds.Orders);
                try
                {
                    DataRow dr = ds.Orders.NewRow();
                    dr["orderUser"] = userName;
                    dr["orderDate"] = DateTime.Now;
                    dr["orderDish"] = DdlFoodChoice.SelectedItem.ToString();
                    dr["orderSize"] = DddlSizeOption.SelectedItem.ToString();
                    dr["orderSpices"] = spiceOption;
                    dr["deliveryLocation"] = txtBoxStreetName.Text + " " + TxtBoxUnit.Text + " Postal Code " + TxtBoxPostal.Text;
                    dr["orderStatus"] = "Pending";
                    ds.Tables["Orders"].Rows.Add(dr);
                    orderta.Update(ds.Orders);
                    LabelStatus.Text = "Order Submitted Successfully";
                    ClearForm();
                }
                catch (Exception ex)
                {
                    LabelStatus.Text = ex.ToString();
                }
            }
            else
                LabelStatus.Text = "Error! Please enter the information for all fields.";


        }
        protected void BtnDiscard_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }
        protected bool IsNotNull(string s)
        {
            if (s != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This is to reset all fields after an order is placed
        protected void ClearForm()
        {
            txtBoxStreetName.Text = "";
            TxtBoxUnit.Text = "";
            TxtBoxPostal.Text = "";
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            SubmitOrder();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckPrice();
        }
    }
}