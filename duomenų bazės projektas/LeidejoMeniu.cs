using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class LeidejoMeniu : Form
    {
        public LeidejoMeniu()
        {
            InitializeComponent();
        }


        public void LeidejoMeniu_Load(object sender, EventArgs e)
        {
            {
                string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
                MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                try
                {
                    mySqlConnection.Open();

                    string query = "SELECT zaidimoId, pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, ivertinimas, statusas, kurejoid FROM zaidimas";
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

        }

        public void button1_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                DataTable dataTable = (DataTable)dataGridView1.DataSource;

        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = new MySqlCommand("SELECT * FROM zaidimas", mySqlConnection);

        MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
        adapter.Update(dataTable);

                MessageBox.Show("Duomenys išsaugoti sėkmingai.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida įrašant duomenis į duomenų bazę: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataView.RowFilter = string.Format("Statusas LIKE '%{0}%'", searchValue);

                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }


        public void button2_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT zaidimoId, pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, ivertinimas, statusas, kurejoid, kaina FROM zaidimas";
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
