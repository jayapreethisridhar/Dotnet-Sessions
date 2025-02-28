using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncApp.Services;

namespace WinFormsAsyncApp
{
    public partial class WelcomeForm : Form
    {
        private PrintService _printservice;
        public WelcomeForm()
        {
            _printservice = new PrintService();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UserName");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get input values from text boxes
            string username = textBox1.Text;
            Console.WriteLine(username);
            string password = textBox2.Text;
            Console.WriteLine(password);

            // Simple authentication logic (replace with actual authentication mechanism)
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide this form and show another form or perform some action
                this.Hide();
                new WelcomeForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace this with your actual authentication logic
            // For example:
            return username == "Preethi" && password == "password";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
