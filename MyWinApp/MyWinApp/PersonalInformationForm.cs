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
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fatherName = fatherTextBox.Text;
            string motherName = motherTextBox.Text;
            string address = addressTextBox.Text;
            string message = "";
            message += "First Name: " + firstName + "\n";
            message += "Last Name: " + lastName + "\n";
            message += "Father's Name: " + fatherName + "\n";
            message += "Mother's Name: " + motherName + "\n";
            message += "Address: " + address + "\n";

            showRichTextBox.Text = message;

        }
    }
}
