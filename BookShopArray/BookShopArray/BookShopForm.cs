using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopArray
{
    public partial class BookShopForm : Form
    {
        List<string> name = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<int> quantity = new List<int>();
        List<int> totalPrice = new List<int>();

        int tempTotalPrice;


        public BookShopForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            name.Add(nameTextBox.Text);
            contactNo.Add(contactTextBox.Text);
            address.Add(addressTextBox.Text);
            order.Add(orderComboBox.Text);
            quantity.Add(Convert.ToInt32(quantityTextBox.Text));
            totalPrice.Add(tempTotalPrice);
            displayTextBox.Text = "Information has been submitted";

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int price=0;
            string tempOrder = orderComboBox.Text;
            if(tempOrder.Equals("Bangla"))
            {
                price = 90;
            }
            else if (tempOrder.Equals("English"))
            {
                price = 100;
            } 
            else if (tempOrder.Equals("Math"))
            {
                price = 120;
            } 
            else if (tempOrder.Equals("Art"))
            {
                price = 80;
            }
            tempTotalPrice = price * Convert.ToInt32(quantityTextBox.Text);

            totalPriceextBox.Text = Convert.ToString(tempTotalPrice);
            displayTextBox.Text = "Total Price is Calculated";

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";
            //for (int index = 0; index < name.Count; index++)
            int index = 0;
            foreach(string each_name in name)
            {
                message += "Customer No: " + (index + 1);
                message += "\nName: " + each_name;
                message += "\nContact No. : " + contactNo[index];
                message += "\nAddress: " + address[index];
                message += "\nOrder: " + order[index];
                message += "\nQuantity : " + Convert.ToString(quantity[index]);
                message += "\nTotal Price : " + Convert.ToString(totalPrice[index]);
                index++;
            }
            showRichTextBox.Text = message;
        }
    }
}
