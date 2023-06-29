
namespace PersonalFinanceApp
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox expenseCategoryTextBox;
        private System.Windows.Forms.TextBox expenseAmountTextBox;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.ListBox expensesListBox;
        private System.Windows.Forms.TextBox incomeCategoryTextBox;
        private System.Windows.Forms.TextBox incomeAmountTextBox;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.ListBox incomesListBox;

        private void InitializeComponent()
        {
            this.balanceLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.expenseCategoryTextBox = new System.Windows.Forms.TextBox();
            this.expenseAmountTextBox = new System.Windows.Forms.TextBox();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.expensesListBox = new System.Windows.Forms.ListBox();
            this.incomeCategoryTextBox = new System.Windows.Forms.TextBox();
            this.incomeAmountTextBox = new System.Windows.Forms.TextBox();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.incomesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(194, 21);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(77, 13);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Баланс: $0.00";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(12, 37);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(12, 63);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(91, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(109, 63);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // expenseCategoryTextBox
            // 
            this.expenseCategoryTextBox.Location = new System.Drawing.Point(11, 133);
            this.expenseCategoryTextBox.Name = "expenseCategoryTextBox";
            this.expenseCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.expenseCategoryTextBox.TabIndex = 4;
            // 
            // expenseAmountTextBox
            // 
            this.expenseAmountTextBox.Location = new System.Drawing.Point(117, 133);
            this.expenseAmountTextBox.Name = "expenseAmountTextBox";
            this.expenseAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.expenseAmountTextBox.TabIndex = 5;
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(223, 130);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.addExpenseButton.TabIndex = 6;
            this.addExpenseButton.Text = "Добавить расход";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.AddExpenseButton_Click);
            // 
            // expensesListBox
            // 
            this.expensesListBox.FormattingEnabled = true;
            this.expensesListBox.Location = new System.Drawing.Point(11, 159);
            this.expensesListBox.Name = "expensesListBox";
            this.expensesListBox.Size = new System.Drawing.Size(287, 95);
            this.expensesListBox.TabIndex = 7;
            // 
            // incomeCategoryTextBox
            // 
            this.incomeCategoryTextBox.Location = new System.Drawing.Point(12, 298);
            this.incomeCategoryTextBox.Name = "incomeCategoryTextBox";
            this.incomeCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeCategoryTextBox.TabIndex = 8;
            // 
            // incomeAmountTextBox
            // 
            this.incomeAmountTextBox.Location = new System.Drawing.Point(118, 298);
            this.incomeAmountTextBox.Name = "incomeAmountTextBox";
            this.incomeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeAmountTextBox.TabIndex = 9;
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(224, 295);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(75, 23);
            this.addIncomeButton.TabIndex = 10;
            this.addIncomeButton.Text = "Добавить доход";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.AddIncomeButton_Click);
            // 
            // incomesListBox
            // 
            this.incomesListBox.FormattingEnabled = true;
            this.incomesListBox.Location = new System.Drawing.Point(12, 324);
            this.incomesListBox.Name = "incomesListBox";
            this.incomesListBox.Size = new System.Drawing.Size(287, 95);
            this.incomesListBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тип Расхода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип Дохода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Имя пользователя";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(318, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomesListBox);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.incomeAmountTextBox);
            this.Controls.Add(this.incomeCategoryTextBox);
            this.Controls.Add(this.expensesListBox);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.expenseAmountTextBox);
            this.Controls.Add(this.expenseCategoryTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личные финансы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

