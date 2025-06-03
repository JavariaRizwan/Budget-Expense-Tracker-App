using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExpenseTracker
{
    public partial class ExpenseTracker : Form
    {
        string connectionString = "server=localhost;user=root;password=root123;database=expense_tracker;";

        decimal totalexpenses = 0;
        decimal balance = 0;
        decimal inc = 0;

        private string loggedInUser;
        private int userId;

        public ExpenseTracker(int userId, string username)
        {
            InitializeComponent();

            this.userId = userId;
            this.loggedInUser = username;

            userTextBox.Text = $"Logged in as: {username}";
            userTextBox.Enabled = false;

            this.addExpense.Paint += new PaintEventHandler(this.addExpense_Paint);
            this.Load += new EventHandler(this.ExpenseTracker_Load);
        }

        private void ExpenseTracker_Load(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Get total income
                var incomeCmd = new MySqlCommand("SELECT income FROM users WHERE id = @userId", conn);
                incomeCmd.Parameters.AddWithValue("@userId", userId);
                var incomeValue = incomeCmd.ExecuteScalar();

                inc = (incomeValue != null && incomeValue != DBNull.Value) ? Convert.ToDecimal(incomeValue) : 0;

                // Step 2: Get total expenses
                var expenseCmd = new MySqlCommand("SELECT SUM(amount) FROM expenses WHERE user_id = @userId", conn);
                expenseCmd.Parameters.AddWithValue("@userId", userId);
                var expenseValue = expenseCmd.ExecuteScalar();

                totalexpenses = (expenseValue != null && expenseValue != DBNull.Value) ? Convert.ToDecimal(expenseValue) : 0;

                // Step 3: Calculate balance
                balance = inc - totalexpenses;

                // Step 4: Update UI
                lblBalanceValue.Text = "Rs. " + balance.ToString("N2");
                totalInc.Text = "Rs. " + inc.ToString("N2");
                lblTotalValue.Text = "Rs. " + totalexpenses.ToString("N2");
            }

            // Set up ListView
            expenseListView.Clear();
            expenseListView.View = View.Details;
            expenseListView.Columns.Clear();
            expenseListView.Columns.Add("Expense", 150);
            expenseListView.Columns.Add("Amount", 100);
            expenseListView.Columns.Add("Date", 120);
            expenseListView.FullRowSelect = true;
            expenseListView.GridLines = true;
        }

        private void addExpense_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = btn.ClientRectangle;
            int radius = 20;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }

        private void addExpense_Click(object sender, EventArgs e)
        {
            string category = expenseBox.Text;
            string amountText = amountBox.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (balance - amount < 0)
            {
                MessageBox.Show("Balance cannot be negative. Expense not added.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO expenses (user_id, category, amount, expense_date) VALUES (@user_id, @category, @amount, @date)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update UI
            ListViewItem item = new ListViewItem(category);
            item.SubItems.Add(amount.ToString("N2"));
            item.SubItems.Add(date);
            expenseListView.Items.Add(item);

            totalexpenses += amount;
            balance -= amount;

            lblTotalValue.Text = "Total Expenses: Rs." + totalexpenses.ToString("N2");
            lblBalanceValue.Text = "Balance: Rs." + balance.ToString("N2");

            expenseBox.Clear();
            amountBox.Clear();
        }

        private void setIncome_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(incomeBox.Text, out decimal newIncome))
            {
                balance += newIncome;
                inc += newIncome;

                lblBalanceValue.Text = "Rs. " + balance.ToString("N2");
                totalInc.Text = "Rs. " + inc.ToString("N2");

                incomeBox.Clear();
                addExpense.Enabled = true;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE users SET income = @income WHERE id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@income", inc); // Save total income
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid income.");
            }
        }
    }
}
