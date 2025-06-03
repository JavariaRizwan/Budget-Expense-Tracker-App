using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form3 : Form
    {


        string connectionString = "server=localhost;user=root;password=root123;database=expense_tracker;";

        public Form3()
        {
            InitializeComponent();
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            string username = useName.Text.Trim();
            string password = passTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both Username and Password fields.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=root123;database=expense_tracker;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }
                }

                // Insert new user (corrected parameter names)
                string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password); // Remember: hash passwords in production!

                    int result = insertCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Signup successful! You can now log in.");
                        // Optionally, redirect to login form here, e.g.:
                        // this.Hide();
                        // var loginForm = new LoginForm();
                        // loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Signup failed. Try again.");
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Open Login form
            Form2 loginForm = new Form2();
            loginForm.Show();

            // Close this signup form
            this.Hide();
        }
    }
}
    

