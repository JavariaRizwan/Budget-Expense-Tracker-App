namespace ExpenseTracker
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignForm = new System.Windows.Forms.Label();
            this.usern = new System.Windows.Forms.Label();
            this.useName = new System.Windows.Forms.TextBox();
            this.SignBtn = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passTextBox);
            this.panel1.Controls.Add(this.passW);
            this.panel1.Controls.Add(this.SignBtn);
            this.panel1.Controls.Add(this.useName);
            this.panel1.Controls.Add(this.usern);
            this.panel1.Controls.Add(this.SignForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignForm
            // 
            this.SignForm.AutoSize = true;
            this.SignForm.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignForm.Location = new System.Drawing.Point(310, 106);
            this.SignForm.Name = "SignForm";
            this.SignForm.Size = new System.Drawing.Size(195, 35);
            this.SignForm.TabIndex = 0;
            this.SignForm.Text = "Sign Up Form";
            // 
            // usern
            // 
            this.usern.AutoSize = true;
            this.usern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usern.Location = new System.Drawing.Point(243, 175);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(124, 29);
            this.usern.TabIndex = 1;
            this.usern.Text = "Username";
            // 
            // useName
            // 
            this.useName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.useName.Location = new System.Drawing.Point(382, 175);
            this.useName.Name = "useName";
            this.useName.Size = new System.Drawing.Size(150, 30);
            this.useName.TabIndex = 0;
            // 
            // SignBtn
            // 
            this.SignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SignBtn.Location = new System.Drawing.Point(382, 294);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(118, 40);
            this.SignBtn.TabIndex = 2;
            this.SignBtn.Text = "Sign Up";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passTextBox.Location = new System.Drawing.Point(382, 235);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(150, 30);
            this.passTextBox.TabIndex = 1;
            // 
            // passW
            // 
            this.passW.AutoSize = true;
            this.passW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passW.Location = new System.Drawing.Point(243, 235);
            this.passW.Name = "passW";
            this.passW.Size = new System.Drawing.Size(120, 29);
            this.passW.TabIndex = 4;
            this.passW.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to our Budget Expense Tracker App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(243, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created Account?";
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loginBtn.Location = new System.Drawing.Point(462, 371);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(118, 40);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SignForm;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passW;
        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.TextBox useName;
        private System.Windows.Forms.Label usern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
    }
}