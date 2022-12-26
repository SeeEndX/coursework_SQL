using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace coursework_SQL
{
    public partial class AllProductsForm : Form
    {
        DataBase dataBase = new DataBase();
        string queryString;
        private DataGridView dgw = new DataGridView();
        public AllProductsForm()
        {
            InitializeComponent();
        }

        public void setDataGridView(DataGridView dataGridView)
        {
            this.dgw = dataGridView;
        }

        public DataGridView getDataGridView()
        {
            return this.dgw;
        }

        private void CreateColumns()
        {
            dataGridViewProd.Columns.Add("Товары.id_товара", "Номер товара");
            dataGridViewProd.Columns.Add("Товары.id_категории", "Номер категории");
            dataGridViewProd.Columns.Add("Товары.название", "Название");
            dataGridViewProd.Columns.Add("Товары.описание", "Описание");
            dataGridViewProd.Columns.Add("Товары.цена", "Цена");
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord)
        {
            dataGridView.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetInt32(1), dataRecord.GetString(2), dataRecord.GetString(3), dataRecord.GetInt32(4));
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

        private void AllProductsForm_Load(object sender, EventArgs e)
        {
            queryString = $"SELECT Товары.id_товара, Товары.id_категории, Товары.название, Товары.описание, Товары.цена FROM Товары;";
            CreateColumns();
            RefreshDataGrid(dataGridViewProd, queryString);
        }
    }
}
