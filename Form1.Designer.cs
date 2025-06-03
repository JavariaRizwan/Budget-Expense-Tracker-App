using System.Drawing;

namespace ExpenseTracker
{
    partial class ExpenseTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.income = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ExpenseList = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Expense = new System.Windows.Forms.Label();
            this.incomeBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.expenseBox = new System.Windows.Forms.TextBox();
            this.addExpense = new System.Windows.Forms.Button();
            this.expenseListView = new System.Windows.Forms.ListView();
            this.colExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.setIncome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalInc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.Location = new System.Drawing.Point(616, 330);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(119, 32);
            this.income.TabIndex = 0;
            this.income.Text = "Income : ";
            this.income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpenseList
            // 
            this.ExpenseList.AutoSize = true;
            this.ExpenseList.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseList.Location = new System.Drawing.Point(257, 617);
            this.ExpenseList.Name = "ExpenseList";
            this.ExpenseList.Size = new System.Drawing.Size(173, 32);
            this.ExpenseList.TabIndex = 1;
            this.ExpenseList.Text = "Expense List : ";
            this.ExpenseList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(616, 558);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(127, 32);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "Amount : ";
            this.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Expense
            // 
            this.Expense.AutoSize = true;
            this.Expense.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense.Location = new System.Drawing.Point(620, 487);
            this.Expense.Name = "Expense";
            this.Expense.Size = new System.Drawing.Size(128, 32);
            this.Expense.TabIndex = 3;
            this.Expense.Text = "Expense : ";
            this.Expense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeBox
            // 
            this.incomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.incomeBox.Location = new System.Drawing.Point(769, 319);
            this.incomeBox.MaximumSize = new System.Drawing.Size(200, 55);
            this.incomeBox.Multiline = true;
            this.incomeBox.Name = "incomeBox";
            this.incomeBox.Size = new System.Drawing.Size(200, 43);
            this.incomeBox.TabIndex = 4;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amountBox.Location = new System.Drawing.Point(773, 549);
            this.amountBox.MaximumSize = new System.Drawing.Size(200, 55);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(200, 43);
            this.amountBox.TabIndex = 6;
            // 
            // expenseBox
            // 
            this.expenseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.expenseBox.Location = new System.Drawing.Point(773, 475);
            this.expenseBox.MaximumSize = new System.Drawing.Size(200, 55);
            this.expenseBox.Multiline = true;
            this.expenseBox.Name = "expenseBox";
            this.expenseBox.Size = new System.Drawing.Size(200, 43);
            this.expenseBox.TabIndex = 5;
            // 
            // addExpense
            // 
            this.addExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addExpense.Location = new System.Drawing.Point(1042, 502);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(176, 61);
            this.addExpense.TabIndex = 7;
            this.addExpense.Text = "Add Expense";
            this.addExpense.UseVisualStyleBackColor = true;
            this.addExpense.Click += new System.EventHandler(this.addExpense_Click);
            // 
            // expenseListView
            // 
            this.expenseListView.BackColor = System.Drawing.Color.White;
            this.expenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExpense,
            this.colAmount,
            this.colDate});
            this.expenseListView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expenseListView.ForeColor = System.Drawing.Color.Black;
            this.expenseListView.FullRowSelect = true;
            this.expenseListView.GridLines = true;
            this.expenseListView.HideSelection = false;
            this.expenseListView.Location = new System.Drawing.Point(257, 673);
            this.expenseListView.Name = "expenseListView";
            this.expenseListView.Size = new System.Drawing.Size(632, 289);
            this.expenseListView.TabIndex = 8;
            this.expenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseListView.View = System.Windows.Forms.View.Details;
            // 
            // colExpense
            // 
            this.colExpense.Text = "Expense Name";
            this.colExpense.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 120;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1217, 818);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(203, 32);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Expenses : ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(963, 809);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(115, 32);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Balance :";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceValue.Location = new System.Drawing.Point(965, 863);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(116, 32);
            this.lblBalanceValue.TabIndex = 11;
            this.lblBalanceValue.Text = "$balance";
            this.lblBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(1223, 865);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(112, 32);
            this.lblTotalValue.TabIndex = 12;
            this.lblTotalValue.Text = "$income";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setIncome
            // 
            this.setIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.setIncome.Location = new System.Drawing.Point(1042, 315);
            this.setIncome.Name = "setIncome";
            this.setIncome.Size = new System.Drawing.Size(176, 61);
            this.setIncome.TabIndex = 13;
            this.setIncome.Text = "Set Income";
            this.setIncome.UseVisualStyleBackColor = true;
            this.setIncome.Click += new System.EventHandler(this.setIncome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set Your Income Budget";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set Your Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInc
            // 
            this.totalInc.AutoSize = true;
            this.totalInc.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInc.Location = new System.Drawing.Point(965, 747);
            this.totalInc.Name = "totalInc";
            this.totalInc.Size = new System.Drawing.Size(175, 32);
            this.totalInc.TabIndex = 17;
            this.totalInc.Text = "$budgetValue";
            this.totalInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(963, 693);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Income :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(531, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(604, 52);
            this.label3.TabIndex = 18;
            this.label3.Text = "Budget Expense Tracker App";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTextBox
            // 
            this.userTextBox.AutoSize = true;
            this.userTextBox.Enabled = false;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.userTextBox.Location = new System.Drawing.Point(620, 202);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(324, 35);
            this.userTextBox.TabIndex = 19;
            this.userTextBox.Text = "$user_logged_in_details";
            this.userTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpenseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 1100);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalInc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setIncome);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.expenseListView);
            this.Controls.Add(this.addExpense);
            this.Controls.Add(this.expenseBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.incomeBox);
            this.Controls.Add(this.Expense);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ExpenseList);
            this.Controls.Add(this.income);
            this.Name = "ExpenseTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Expense Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpenseTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label income;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ExpenseList;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Expense;
        private System.Windows.Forms.TextBox incomeBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox expenseBox;
        private System.Windows.Forms.Button addExpense;
        private System.Windows.Forms.ListView expenseListView;
        private System.Windows.Forms.ColumnHeader colExpense;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button setIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalInc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userTextBox;
    }
}
