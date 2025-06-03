using ExpenseTracker;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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



namespace ExpenseTracker
{

    public partial class Form2 : Form
    {

        //connection logic


        string connectionString = "server=localhost;user=root;password=root123;database=expense_tracker;";

        public Form2()
        {
            InitializeComponent();
        }



        /// <summary>
        ///  connection logic ends
        /// </summary>
       

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


       
        private void logBtn_Click_1(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);  // Note: For real apps, hash passwords!

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    object result = cmd.ExecuteScalar();


                    if (count > 0)
                    {
                        int userId = Convert.ToInt32(result); // ✅ userId is now defined
                        MessageBox.Show("Login successful!");
                        // Proceed to next form

                        // Create and show Form1
                        ExpenseTracker mainForm = new ExpenseTracker(userId, username);

                        mainForm.Show();

                        // Hide or close the login form
                        this.Hide();
                        // Or: this.Close(); (but be careful if it's the main app form)

                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials.");
                    }
                }
            }
            }   

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Open the Signup form
            Form3 signupForm = new Form3();
            signupForm.ShowDialog();  // Show as modal dialog so user can complete signup before returning
            this.Hide();

        }
    }
}
