using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace coursework_SQL
{
    public partial class MakeOrderForm : Form
    {
        DataBase dataBase = new DataBase();
        string queryString;
        private bool isCreated = false;
        private int id_cl;
        int id_fil;
        int id_ord;
        int id_pr;
        int ammount;
        int sum = 0;
        string dateTime = "";
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgwNewOrder.Columns.Add("Заказы.id_заказа", "Номер заказа");
            dgwNewOrder.Columns.Add("Заказы.id_магазина", "Номер магазина");
            dgwNewOrder.Columns.Add("Заказы.id_клиента", "Номер клиента");
            dgwNewOrder.Columns.Add("Заказы.дата_время", "Дата заказа");
            isCreated = true;
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord)
        {
            dataGridView.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetInt32(1), dataRecord.GetInt32(2), dataRecord.GetDateTime(3));
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            id_cl = (int)idCl.Value;
            id_fil = (int)idFil.Value;
            ammount = (int)ammountPr.Value;
            id_pr = (int)idPr.Value;
            dateTime = orderDate.Text;
            
            queryString = $"select COUNT(Заказы.id_заказа) from Заказы";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            id_ord = (int)sqlCommand.ExecuteScalar()+1;

            //заказ
            queryString = $"insert into Заказы(id_заказа, id_магазина, id_клиента, дата_время) values ({id_ord},{id_fil},{id_cl},'{dateTime}');";
            sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            MessageBox.Show("Заказ под номером " + id_ord + " успешно добавлен!");
            int rowCount = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Row Count affected = " + rowCount);

            //чек
            queryString = $"select цена from Товары where id_товара = {@id_pr}";
            sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            sum = (int)sqlCommand.ExecuteScalar() * ammount;

            queryString = $"insert into Чек(id_заказа, id_товара, количество_товара, сумма) values" +
                $"({id_ord}, {id_pr}, {ammount}, {sum})";
            sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            rowCount = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Чек:\nRow Count affected = " + rowCount);
            queryString = $"select id_заказа, id_магазина, id_клиента, дата_время from Заказы where id_заказа = {id_ord}";
            if (!isCreated) CreateColumns();
            RefreshDataGrid(dgwNewOrder, queryString);
            dataBase.closeConnection();
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
