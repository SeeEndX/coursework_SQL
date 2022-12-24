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
using System.Threading;

namespace coursework_SQL
{
    public partial class AdminForm : Form
    {
        DataBase dataBase = new DataBase();
        DataGridView dataGridView = new DataGridView();
        bool isCreated = false;
        int id_cl = 0;
        string dateTime = "";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView.Columns.Add("Заказы.id_заказа", "Номер заказа");
            dataGridView.Columns.Add("Чек.сумма", "Сумма");
            dataGridView.Columns.Add("Чек.id_товара", "Номер товара");
            dataGridView.Columns.Add("Заказы.дата_время", "Дата заказа");
            isCreated = true;
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord)
        {
            dataGridView.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetInt32(1), dataRecord.GetInt32(2), dataRecord.GetDateTime(3)); //,RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView, string queryString)
        {
            dataGridView.Rows.Clear();
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRow(dataGridView, dataReader);
            }
            dataReader.Close();
        }

        private Label createLabel(string str, int count, int X, int Y, int width, int height)
        {
            Label label = new Label();
            if (count == -1) label.Text = str;
            else label.Text = str + count;
            label.Location = new Point(X, Y);
            label.ForeColor = Color.Orange;
            label.AutoSize = false;
            label.Size = new Size(width, height);
            label.Font = new Font("Microsoft Sans Serif", 19, FontStyle.Bold);
            return label;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int count;
            id_cl = (int)numUpDownId.Value;
            dateTime = searchDate.Text;
            string queryString = "";
            //searchDate.CustomFormat = "yyyymmdd"; //20220122

            if (rbId.Checked)
            {
                queryString = $"SELECT Заказы.id_заказа, Чек.сумма, Чек.id_товара, Заказы.дата_время FROM Заказы Join Чек ON Заказы.id_заказа=Чек.id_заказа where Заказы.id_клиента= {id_cl};";
            }
            else if (rbDate.Checked)
            {
                queryString = $"SELECT Заказы.id_заказа, Чек.сумма, Чек.id_товара, Заказы.дата_время FROM Заказы Join Чек ON Заказы.id_заказа=Чек.id_заказа where cast(Заказы.дата_время as date) = '{dateTime}';";
            }
            MainForm formM = new MainForm();
            DataGridView dgr;
            dgr = dataGridView;
            dgr.BackgroundColor = Color.Black;
            dgr.Location = new Point(23, 59);
            dgr.Width = formM.Width;
            dgr.Height = formM.Height;
            if (!isCreated) CreateColumns();
            RefreshDataGrid(dgr, queryString);
            count = dgr.RowCount-1;
            formM.Controls.Add(createLabel("Всего: ",count,390, 9, 200, 50));
            formM.Controls.Add(dgr);
            this.Hide();
            formM.ShowDialog();
            this.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            ProductForm formP = new ProductForm();
            formP.Controls.Add(createLabel("Добавление товара", -1, 16, 9, 400, 50));
            this.Hide();
            formP.ShowDialog();
            this.Show();
        }
    }
}
