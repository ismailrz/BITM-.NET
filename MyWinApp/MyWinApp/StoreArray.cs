using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class StoreArray : Form
    {
        const int size = 10;
        int[] numbers = new int[size];
        int count = 0;

        public StoreArray()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            numbers[count] = Convert.ToInt32(numberTextBox.Text);
            count++;
            string message = "Elements in array are : ";
            for(int index=0;index<count;index++)
            {
                message += numbers[index] + " ";
            }
            showRichTextBox.Text = message;

        }
    }
}
