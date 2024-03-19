using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Susisiektisvetaine : Form
    {
        string mysqlCon = "server=127.0.0.1; user=root; database=praktinis2; password=admin";
        public Susisiektisvetaine()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Svetaine form2 = new Svetaine();
            form2.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string vardas = textBox1.Text;
            string pavarde = textBox2.Text;
            string elPastas = textBox3.Text;
            string zinute = richTextBox1.Text;

            using (MySqlConnection connection = new MySqlConnection(mysqlCon))
            {
                connection.Open();

                string query = "INSERT INTO zinutes (Vardas, Pavarde,  `El. pastas`, Zinute) VALUES (@vardas, @pavarde, @el_pastas, @zinute)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vardas", vardas);
                    command.Parameters.AddWithValue("@pavarde", pavarde);
                    command.Parameters.AddWithValue("@el_pastas", elPastas);
                    command.Parameters.AddWithValue("@zinute", zinute);

                    command.ExecuteNonQuery();
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();

            MessageBox.Show("Žinutė sėkmingai išsiųsta!");
        }
    }
}