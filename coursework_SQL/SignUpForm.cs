using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace coursework_SQL
{
    public partial class SignUpForm : Form
    {
        DataBase dataBase = new DataBase();

        public SignUpForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            txtBoxRegPassword.PasswordChar = '*';
            txtBoxRegPassword.MaxLength = 30;
            txtBoxRegUsername.MaxLength = 30;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            var login = txtBoxRegUsername.Text;
            var password = txtBoxRegPassword.Text;
            var number = txtBoxRegNumber.Text;

            string queryString = $"INSERT INTO Данные_клиента(id_клиента,номер_телефона, login, password) VALUES((SELECT id_клиента from Клиент where Клиент.номер_телефона='{number}'),'{number}','{login}','{password}')";

            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            
            dataBase.openConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех!");
                AuthPage loginForm = new AuthPage();
                this.Hide();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан!", "Ошибка!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var login = txtBoxRegUsername.Text;
            var password = txtBoxRegPassword.Text;
            var number = txtBoxRegNumber.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT * FROM Данные_клиента WHERE номер_телефона = '{number}' and login = '{login}' and password = '{password}'";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
