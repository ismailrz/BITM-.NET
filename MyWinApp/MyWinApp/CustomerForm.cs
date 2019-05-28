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
    public partial class CustomerForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                string name;
                int age;

                userLabel.Text = "";
                user = userTextBox.Text;

                if (String.IsNullOrEmpty(user))
                {
                    MessageBox.Show("User field can not be empty");
                    return;               
                } 
                if (UserExists(user))
                {
                    userLabel.Text = "User: " + user + " is already exist!";
                    return;
                }

                name = nameTextBox.Text;

                if(String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Age field can not be empty");
                    return ;               //Exit from the method if error happens, next not repeat error
                }

                if (System.Text.RegularExpressions.Regex.IsMatch(ageTextBox.Text, "[^0-9]"))  // built-in method online search. 
                {
                    MessageBox.Show("Please enter only numbers.");
                    return;
                }

                age = Convert.ToInt32(ageTextBox.Text);   //if age is null or character, then program terminate
                                                          // so use try-catch .

                users.Add(user);
                names.Add(name);
                ages.Add(age);

                showRichTextBox.Text = Display();

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
        private string Display()
        {
            string message = "";
            message = "SI\tUser\tName\tAge\t\n";
            for(int index=0; index<users.Count; index++)
            {
                message += (index + 1) + "\t" + users[index] + "\t" + names[index] + "\t" + ages[index] + "\n";
            }
            return message;
        }
        private bool UserExists(string user)     //user checking method            
        {
            bool isExist = false;
            foreach(string checkUser in users)
            {
                if(checkUser==user)
                {
                    isExist = true;
                }
            }
            return isExist;
        }
    }
}
