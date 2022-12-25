using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace coursework_SQL
{
    public partial class AuthPage : Form
    {
        public static bool admin = false;

        DataBase dataBase = new DataBase();
        public static int id;
        string queryString;

        public AuthPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void AuthPage_Load(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.MaxLength = 30;
            txtBoxUsername.MaxLength = 30;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string loginUser = txtBoxUsername.Text;
            string loginPassword = txtBoxPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString1 = $"SELECT id_клиента FROM Данные_клиента WHERE login = '{loginUser}' and password = '{loginPassword}'";
            SqlCommand sqlCommand1 = new SqlCommand(queryString1, dataBase.getConnection());

            dataBase.openConnection();

            String pattern = @"admin(\w*)";

            if (adminCheck.Checked)
            {
                queryString = $"Select * FROM admin WHERE login = '{loginUser}' and password = '{loginPassword}'";
                admin = true;
            }
            else
            {
                queryString = $"SELECT * FROM Данные_клиента WHERE login = '{loginUser}' and password = '{loginPassword}'";
                if(!Regex.IsMatch(loginUser, pattern, RegexOptions.IgnoreCase))
                {
                    if (txtBoxPassword.Text != "" && txtBoxUsername.Text != "" && sqlCommand1.ExecuteScalar() != null)
                    {
                        adapter.SelectCommand = sqlCommand1;
                        id = (int)sqlCommand1.ExecuteScalar(); //вывод полученного в запросе значения
                        dataBase.closeConnection();
                    }
                }
            }

            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (admin)
                {
                    AdminForm formAdmin = new AdminForm();
                    formAdmin.MaximizeBox = false;
                    formAdmin.MinimizeBox = false;
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MainForm formMain = new MainForm();
                    formMain.MaximizeBox = false;
                    formMain.MinimizeBox = false;
                    this.Hide();
                    formMain.ShowDialog();
                    this.Show();
                }
            }
            else if (admin)
            {
                MessageBox.Show("Вход не был выполнен!\nДанные администратора неверны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Вход не был выполнен!\nВозможно, вы не заполнили поля или не зарегистрировались", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelNoAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }
    }
}

