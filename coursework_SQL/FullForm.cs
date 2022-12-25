using System.Windows.Forms;

namespace coursework_SQL
{
    public partial class FullForm : Form
    {
        public FullForm()
        {
            InitializeComponent();
        }

        private void FullForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
