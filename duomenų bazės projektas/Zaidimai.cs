using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Zaidimai : Form
    {
        public Zaidimai()
        {
            InitializeComponent();
        }

        public void Zaidimai_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string query = "SELECT zaidimoID, pavadinimas, aprasymas, platforma, `isleidimo data`, zanras, ivertinimas, statusas, kurejoid FROM zaidimas";
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
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            string searchValue = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format("pavadinimas LIKE '%{0}%' OR platforma LIKE '%{0}%' OR zanras LIKE '%{0}%'", searchValue);

                dataGridView1.DataSource = dataView;
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        
    }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                DialogResult result = MessageBox.Show("Ar tikrai norite ištrinti šią eilutę?", "Patvirtinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int zaidimoID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["zaidimoID"].Value);


                    string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
                    MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

                    try
                    {
                        mySqlConnection.Open();

                        string query = "DELETE FROM zaidimas WHERE ZaidimoID = @zaidimoID";
                        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                        cmd.Parameters.AddWithValue("@zaidimoID", zaidimoID);
                        cmd.ExecuteNonQuery();

                        dataGridView1.Rows.RemoveAt(selectedIndex);

                        MessageBox.Show("Eilutė ištrinta sėkmingai.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Klaida ištrinant eilutę iš duomenų bazės: " + ex.Message, "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite eilutę, kurią norite ištrinti.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
