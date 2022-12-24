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

namespace coursework_SQL
{
    public partial class DelProdForm : Form
    {
        DataBase dataBase = new DataBase();
        public DelProdForm()
        {
            InitializeComponent();
        }


        private void delBtn_Click(object sender, EventArgs e)
        {
            int id_del = (int)numUpDownDel.Value;

            string queryString = $"DELETE Товары where Товары.id_товара={id_del}";
            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection());

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить товар под номером "+id_del+"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dataBase.openConnection();
                sqlCommand = new SqlCommand(queryString, dataBase.getConnection());
                MessageBox.Show("Товар под номером " + id_del + " успешно удален!","Успех",MessageBoxButtons.OK);
                int rowCount = sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Row Count affected = " + rowCount);
                dataBase.closeConnection();
            }
        }
    }
}
