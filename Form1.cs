using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> accounts;
        private string currentAccount;
        private List<Expense> expenses;
        private List<Income> incomes;

        public Form1()
        {
            InitializeComponent();

            accounts = new Dictionary<string, decimal>();
            expenses = new List<Expense>();
            incomes = new List<Income>();

            // Добавляем обработчик события FormClosing
            FormClosing += Form1_FormClosing;

            LoadAccountsData();
            LoadUserData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем данные перед закрытием формы
            SaveAccountsData();
            SaveUserData();
        }

        private void UpdateBalanceLabel()
        {
            if (accounts.ContainsKey(currentAccount))
            {
                balanceLabel.Text = $"Баланс: {accounts[currentAccount].ToString("C")}";
            }
            else
            {
                balanceLabel.Text = "Баланс: N/A";
            }
        }

        private void UpdateExpensesListBox()
        {
            expensesListBox.Items.Clear();
            List<Expense> accountExpenses = GetExpensesForCurrentAccount();

            foreach (Expense expense in accountExpenses)
            {
                expensesListBox.Items.Add(expense);
            }
        }

        private void UpdateIncomesListBox()
        {
            incomesListBox.Items.Clear();
            List<Income> accountIncomes = GetIncomesForCurrentAccount();

            foreach (Income income in accountIncomes)
            {
                incomesListBox.Items.Add(income);
            }
        }

        private List<Expense> GetExpensesForCurrentAccount()
        {
            return expenses.Where(expense => expense.Account == currentAccount).ToList();
        }

        private List<Income> GetIncomesForCurrentAccount()
        {
            return incomes.Where(income => income.Account == currentAccount).ToList();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Введите имя пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accounts.ContainsKey(username))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accounts.Add(username, 0);
            currentAccount = username;
            UpdateBalanceLabel();
            ClearUserData();

            SaveAccountsData();
            SaveUserData();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Введите имя пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!accounts.ContainsKey(username))
            {
                MessageBox.Show("Пользователь с таким именем не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentAccount = username;
            UpdateBalanceLabel();
            ClearUserData();
            ClearExpenseData();
            ClearIncomeData();
            LoadUserData();
        }


        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            string category = expenseCategoryTextBox.Text;
            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Введите категорию расхода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(expenseAmountTextBox.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную сумму расхода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Expense expense = new Expense(category, amount, currentAccount);
            expenses.Add(expense);
            accounts[currentAccount] -= amount;

            UpdateBalanceLabel();
            UpdateExpensesListBox();
            ClearExpenseData();

            SaveUserData();
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            string category = incomeCategoryTextBox.Text;
            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Введите категорию дохода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(incomeAmountTextBox.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную сумму дохода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Income income = new Income(category, amount, currentAccount);
            incomes.Add(income);
            accounts[currentAccount] += amount;

            UpdateBalanceLabel();
            UpdateIncomesListBox();
            ClearIncomeData();

            SaveUserData();
            SaveAccountsData();
        }

        private void LoadAccountsData()
        {
            if (File.Exists("accounts.txt"))
            {
                using (StreamReader reader = new StreamReader("accounts.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] accountData = reader.ReadLine().Split(';');
                        string username = accountData[0];
                        decimal balance = decimal.Parse(accountData[1]);
                        accounts.Add(username, balance);
                    }
                }
            }
        }

        private void SaveAccountsData()
        {
            using (StreamWriter writer = new StreamWriter("accounts.txt"))
            {
                foreach (var account in accounts)
                {
                    writer.WriteLine($"{account.Key};{account.Value}");
                }
            }
        }

        private void LoadUserData()
        {
            if (File.Exists($"{currentAccount}.txt"))
            {
                using (StreamReader reader = new StreamReader($"{currentAccount}.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] expenseData = reader.ReadLine().Split(';');
                        string category = expenseData[0];
                        decimal amount = decimal.Parse(expenseData[1]);
                        string type = expenseData[2];

                        if (type == "Expense")
                        {
                            Expense expense = new Expense(category, amount, currentAccount);
                            expenses.Add(expense);
                        }
                        else if (type == "Income")
                        {
                            Income income = new Income(category, amount, currentAccount);
                            incomes.Add(income);
                        }
                    }
                }
            }

            UpdateExpensesListBox();
            UpdateIncomesListBox();
        }


        private void SaveUserData()
        {
            using (StreamWriter writer = new StreamWriter($"{currentAccount}.txt"))
            {
                List<Expense> userExpenses = GetExpensesForCurrentAccount();
                List<Income> userIncomes = GetIncomesForCurrentAccount();

                foreach (Expense expense in userExpenses)
                {
                    writer.WriteLine($"{expense.Category};{expense.Amount};Expense");
                }

                foreach (Income income in userIncomes)
                {
                    writer.WriteLine($"{income.Category};{income.Amount};Income");
                }
            }
        }

        private void ClearUserData()
        {
            expenses.RemoveAll(expense => expense.Account == currentAccount);
            incomes.RemoveAll(income => income.Account == currentAccount);
            expensesListBox.Items.Clear();
            incomesListBox.Items.Clear();
        }

        private void ClearExpenseData()
        {
            expenseCategoryTextBox.Text = "";
            expenseAmountTextBox.Text = "";
        }

        private void ClearIncomeData()
        {
            incomeCategoryTextBox.Text = "";
            incomeAmountTextBox.Text = "";
        }
    }

    public class Expense
    {
        public string Category { get; }
        public decimal Amount { get; }
        public string Account { get; }

        public Expense(string category, decimal amount, string account)
        {
            Category = category;
            Amount = amount;
            Account = account;
        }

        public override string ToString()
        {
            return $"[{Account}] Расход: {Category} - {Amount.ToString("C")}";
        }
    }

    public class Income
    {
        public string Category { get; }
        public decimal Amount { get; }
        public string Account { get; }

        public Income(string category, decimal amount, string account)
        {
            Category = category;
            Amount = amount;
            Account = account;
        }

        public override string ToString()
        {
            return $"[{Account}] Доход: {Category} + {Amount.ToString("C")}";
        }

      
    }
}
