using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography;

namespace coursework_SQL
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        DataGridView dataGridView = new DataGridView();
        int id = AuthPage.id;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateColumns(int selectedIndex)
        {

            switch (selectedIndex)
            {
                case 0:
                    dataGridView1.Columns.Add("Заказы.id_клиента", "Номер клиента");
                    dataGridView1.Columns.Add("Заказы.id_заказа", "Номер заказа");
                    dataGridView1.Columns.Add("Чек.сумма", "Сумма");
                    dataGridView1.Columns.Add("Чек.id_товара", "Номер товара");
                    dataGridView1.Columns.Add("Заказы.дата_время", "Дата заказа");
                    dataGridView1.Columns.Add("IsNew", String.Empty);
                    break;
                case 1:
                    dataGridView.Columns.Add("Чек.id_заказа", "Номер заказа");
                    dataGridView.Columns.Add("Чек.количество_товара", "Кол-во товара");
                    dataGridView.Columns.Add("Чек.Сумма", "Сумма");
                    dataGridView.Columns.Add("Товар.название", "Название");
                    dataGridView.Columns.Add("Товар.описание", "Описание");
                    dataGridView.Columns.Add("IsNew", String.Empty);
                    break;
            }
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord, int index)
        {
            switch (index)
            {
                case 0:
                    dataGridView.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetInt32(1), dataRecord.GetInt32(2), dataRecord.GetInt32(3),dataRecord.GetDateTime(4), RowState.ModifiedNew);
                    break;
                case 1:
                    dataGridView.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetInt32(1), dataRecord.GetInt32(2), dataRecord.GetString(3), dataRecord.GetString(4), RowState.ModifiedNew);
                    break;
            }

        }

        private void RefreshDataGrid(DataGridView dataGridView, string queryString, int index)
        {
            dataGridView.Rows.Clear();
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                ReadSingleRow(dataGridView,dataReader,index);
            }
            dataReader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string queryString = $"SELECT Заказы.id_клиента, Заказы.id_заказа, Чек.сумма, Чек.id_товара, Заказы.дата_время FROM Заказы Join Чек ON Заказы.id_заказа=Чек.id_заказа where id_клиента= {id};";
            CreateColumns(0);
            RefreshDataGrid(dataGridView1, queryString,0);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FullForm formF = new FullForm();
            DataGridView dgr = new DataGridView();
            dgr = dataGridView;
            dgr.Width = formF.Width;
            dgr.Height = formF.Height;
            formF.Show();
            int id_zak = (int)dataGridView1.CurrentRow.Cells[1].Value;
            string queryString = $"SELECT Чек.id_заказа, Чек.количество_товара, Чек.Сумма, Товары.название, Товары.описание  FROM Чек Join Товары on Чек.id_товара=Товары.id_товара where Чек.id_заказа='{id_zak}'";
            CreateColumns(1);
            RefreshDataGrid(dgr, queryString, 1);
            formF.Controls.Add(dgr);
        }
    }
}
