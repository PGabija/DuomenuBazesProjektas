using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Zaidimaisvetaine : Form
    {
        public Zaidimaisvetaine()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Svetaine form2 = new Svetaine();
            form2.Show();
            this.Hide();
        }

        public void Zaidimaisvetaine_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, ivertinimas FROM zaidimas WHERE statusas = 'Patvirtinta'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įkeliant duomenis iš duomenų bazės: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            string searchValue = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("pavadinimas LIKE '%{0}%' OR zanras LIKE '%{0}%' OR ivertinimas LIKE '%{0}%' OR platforma LIKE '%{0}%'", searchValue);

                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, ivertinimas, kaina FROM zaidimas WHERE statusas = 'Patvirtinta'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įkeliant duomenis iš duomenų bazės: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
            textBox1.Text = "";
        }
    }
}
