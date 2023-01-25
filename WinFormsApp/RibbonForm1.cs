using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    /*CONTROLLER
     *Current state (25/1):
     *
     *First batch of code, copied from Bjorn's tutorial on MVC, translated variable names as well as we can at this stage.
     */
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccessLayer _layer;
        public RibbonForm1()
        {
            _layer = new();
            InitializeComponent();
        }
        public void labelUserMessageSuccess(string labelInput)
        {
            labelUserMessage.Text = (labelInput);
            labelUserMessage.ForeColor = Color.Black;
            labelUserMessage.Visible = true;
        }

        public void labelUserMessageFailure(string labelInput)
        {
            labelUserMessage.Text = (labelInput);
            labelUserMessage.ForeColor = Color.Red;
            labelUserMessage.Visible = true;
        }

        private void buttonProductsAdd_Click(object sender, EventArgs e)
        {
            
            // Incomplete string variables, waiting for finished GUI textBox names to assign.
             
            string productId;
            string productName;
            string stockString;
            string priceString;
  
            try
            {
                int stock = Int32.Parse(stockString);
                int price = Int32.Parse(priceString);

                _layer.InsertProduct(productId, ProductName, stock, price);

                //Note: labelUserMessage is a placeholder.
                labelUserMessageSuccess("Product added");

            } catch(FormatException ex)
            {
                labelUserMessageFailure("Stock/price cannot contain letters or special characters");
            } catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    labelUserMessageFailure("A product with that ID already exists");
                }
                else
                {
                    labelUserMessageFailure("System Error. Please try again. If the error persists, please contact Spongebob");
                }
            }

        }
    }
}