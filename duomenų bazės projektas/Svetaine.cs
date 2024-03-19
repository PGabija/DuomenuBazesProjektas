using System;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Svetaine : Form
    {
        public Svetaine()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Leidejaisvetaine form = new Leidejaisvetaine();
            form.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Kurejaisvetaine form = new Kurejaisvetaine();
            form.Show();
            this.Hide();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Zaidimaisvetaine form = new Zaidimaisvetaine();
            form.Show();
            this.Hide();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Susisiektisvetaine form = new Susisiektisvetaine();
            form.Show();
            this.Hide();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        public void Svetaine_Load(object sender, EventArgs e)
        {

        }
    }
}
