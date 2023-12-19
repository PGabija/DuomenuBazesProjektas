using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Zaidimostatusas : Form
    {
        public static int kurejoId;

        public Zaidimostatusas(int kurejoId)
        {
            InitializeComponent();
            Zaidimostatusas.kurejoId = kurejoId; 
        }

        public void Zaidimostatusas_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; user=root; database=praktinis2; password=admin";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM zaidimas WHERE KurejoID = @kurejoId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kurejoId", Zaidimostatusas.kurejoId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Nėra žaidimų su šiuo kūrėjo ID.");
                        }
                    }
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            KurejasMeniu form2 = new KurejasMeniu();
            form2.Show();
            this.Hide();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
