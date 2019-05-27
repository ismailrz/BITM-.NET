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
        const int size = 10;
        int count = 0;
        string[] name = new string[size];
        string[] contactNo = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int[] totalPrice = new int[size];
        int tempTotalPrice;


        public BookShopForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            name[count] = nameTextBox.Text;
            contactNo[count] = contactTextBox.Text;
            address[count] = addressTextBox.Text;
            order[count] = orderComboBox.Text;
            quantity[count] =Convert.ToInt32( quantityTextBox.Text);
            totalPrice[count] = tempTotalPrice;
            count++;

            string message = "";
            for(int index=0;index<count;index++)
            {
                message += "Customer No: " + (index + 1);
                message += "\nName: " + name[index];
                message += "\nContact No. : " + contactNo[index];
                message += "\nAddress: " + address[index];
                message += "\nOrder: " + order[index];
                message += "\nQuantity : " + Convert.ToString(quantity[index]);
                message += "\nTotal Price : " + Convert.ToString(totalPrice[index]);

            }
            showRichTextBox.Text = message;

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

        }
    }
}
