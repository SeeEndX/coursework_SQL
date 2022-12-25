using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace coursework_SQL
{
    public partial class SignUpForm : Form
    {
        DataBase dataBase = new DataBase();
        string queryString;

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

            string queryString2 = $"SELECT Клиент.id_клиента FROM Клиент WHERE Клиент.номер_телефона='{number}'";
            queryString = $"INSERT INTO Данные_клиента(id_клиента,номер_телефона, login, password) VALUES((SELECT id_клиента from Клиент where Клиент.номер_телефона='{number}'),'{number}','{login}','{password}')";

            SqlCommand sqlCommand1 = new SqlCommand(queryString2, dataBase.getConnection());
            dataBase.openConnection();

            if (sqlCommand1.ExecuteScalar() != null)
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

                dataBase.openConnection();

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан", "Успех!");
                    AuthPage loginForm = new AuthPage();
                    loginForm.MaximizeBox = false;
                    loginForm.MinimizeBox = false;
                    this.Hide();
                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не был создан!", "Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                dataBase.closeConnection();
            }
            else if (txtBoxRegUsername.Text == "" || txtBoxRegPassword.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните поля логина и пароля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("К сожалению, мы не можем найти указанный номер в нашей Базе Данных.\nВозможно вам нужно ввести старый номер телефона." +
                    "\nЕсли у вас нет доступа к старому номеру телефона, пожалуйста, обратитесь в техническую поддержку", "Неккорректные данные!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
