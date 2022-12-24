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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace coursework_SQL
{
    public partial class AuthPage : Form
    {

        DataBase dataBase = new DataBase();
        public static int id;

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
            string queryString;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            bool admin = false;

            string queryString1 = $"SELECT id_клиента FROM Данные_клиента WHERE login = '{loginUser}' and password = '{loginPassword}'";

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
                    SqlCommand sqlCommand1 = new SqlCommand(queryString1, dataBase.getConnection());
                    dataBase.openConnection();
                    adapter.SelectCommand = sqlCommand1;
                    id = (int)sqlCommand1.ExecuteScalar(); //вывод полученного в запросе значения
                    dataBase.closeConnection();
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
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MainForm formMain = new MainForm();
                    this.Hide();
                    formMain.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Вход не был выполнен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelNoAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}

