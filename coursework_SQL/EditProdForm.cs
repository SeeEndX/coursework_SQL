using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace coursework_SQL
{
    public partial class EditProdForm : Form
    {
        DataBase dataBase = new DataBase();
        bool isLoaded = false;
        int loadedID = 0;
        int loadedCAT = 0;
        string queryString;
        public EditProdForm()
        {
            InitializeComponent();
        }

        private string chooseCategoryFromId(int id_cat)
        {
            string category="";
            switch (id_cat)
            {
                case 1:
                    category = "Бытовая техника";
                    break;
                case 2:
                    category = "Смартфоны";
                    break;
                case 3:
                    category = "Мультимедиа";
                    break;
                case 4:
                    category = "ПК";
                    break;
                case 5:
                    category = "Ноутбуки";
                    break;
                case 6:
                    category = "Периферия";
                    break;
            }
            return category;
        }

        private int chooseCategoryFromName(string category)
        {
            int id_cat = 1;
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

        private void loadBtn_Click(object sender, EventArgs e)
        {
            int id_cat=1;
            int id_pr = (int)numUpDownEdit.Value;
            string name="";
            string description="";
            int price=99;
            queryString = $"SELECT id_категории, название, описание, цена FROM Товары WHERE Товары.id_товара = {id_pr}";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                id_cat = Convert.ToInt32(dataReader.GetValue(0));
                name = dataReader.GetString(1);
                description = dataReader.GetString(2);
                price = Convert.ToInt32(dataReader.GetValue(3));
            }

            loadedID = id_pr;
            loadedCAT = id_cat;
            this.cbId_cat.Text = chooseCategoryFromId(id_cat);
            this.txtBoxName.Text = name;
            this.txtBoxDescr.Text = description;
            this.numUpDownPrice.Value = price;

            Console.WriteLine(loadedID + " " + id_cat + " " + name + " " + description + " " + price);
            dataReader.Close();
            dataBase.closeConnection();
            isLoaded= true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id_cat = chooseCategoryFromName(cbId_cat.Text);
            queryString = $"UPDATE Товары SET id_категории = {id_cat}, название = '{txtBoxName.Text}', описание = '{txtBoxDescr.Text}', цена = {(int)numUpDownPrice.Value} WHERE id_товара = {loadedID}";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
            if (txtBoxName.Text != "" && txtBoxDescr.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите изменить товар под номером " + loadedID + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes && isLoaded)
                {
                    dataBase.openConnection();
                    int rowCount = sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("Row Count affected = " + rowCount);
                    dataBase.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
