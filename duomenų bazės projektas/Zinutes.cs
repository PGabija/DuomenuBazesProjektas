using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Zinutes : Form
    {
        public Zinutes()
        {
            InitializeComponent();
        }

        public void Zinutes_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT zinutesId, vardas, pavarde, `El. pastas`, zinute FROM zinutes";
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

        public void button1_Click(object sender, EventArgs e)
        {
            Administratorius form3 = new Administratorius();
            form3.Show();
            this.Hide();
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                string searchValue = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(searchValue))
                {
                    DataView dataView = dataTable.DefaultView;
                    dataView.RowFilter = string.Format("statusas LIKE '%{0}%'", searchValue);

                    dataGridView1.DataSource = dataView;
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT zinutesId, vardas, pavarde, `El. pastas`, zinute FROM zinutes";
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
