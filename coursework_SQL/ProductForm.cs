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
using System.Text.RegularExpressions;

namespace coursework_SQL
{
    public partial class ProductForm : Form
    {
        DataBase dataBase = new DataBase();
        DataGridView dataGridView = new DataGridView();
        int id_pr;
        public ProductForm()
        {
            InitializeComponent();
        }

        private int chooseCategory(string category)
        {
            int id_cat=1;
            switch (category)
            {
                case "Бытовая техника":
                    id_cat = 1;
                    break;
                case "Смартфоны":
                    id_cat = 2;
                    break;
                case "Мультимедиа":
                    id_cat = 3;
                    break;
                case "ПК":
                    id_cat = 4;
                    break;
                case "Ноутбуки":
                    id_cat = 5;
                    break;
                case "Периферия":
                    id_cat = 6;
                    break;
            }
            return id_cat;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string name = txtBoxName.Text;
            string descr = txtBoxDescr.Text;
            int id_cat = chooseCategory(cbId_cat.Text);
            int price = (int)numUpDownPrice.Value;

            string queryString1 = $"select COUNT(Товары.id_товара) from Товары";
            SqlCommand sqlCommand = new SqlCommand(queryString1, dataBase.getConnection());
            dataBase.openConnection();
            id_pr = (int)sqlCommand.ExecuteScalar()+1;

            string queryString = $"insert into Товары(id_товара, id_категории, название, описание, цена) values ({id_pr},{id_cat},'{name}','{descr}',{price});";

            sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            Console.WriteLine(id_pr+" "+id_cat + " " + name + " " + descr + " " + price);
            MessageBox.Show("Товар "+name+" успешно добавлен!");
            int rowCount = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Row Count affected = " + rowCount);
            dataBase.closeConnection();
            

        }
    }
}
