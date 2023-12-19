using System;
using System.Windows.Forms;

namespace duomenų_bazės_projektas
{
    public partial class Administratorius : Form
    {
        public Administratorius()
        {
            InitializeComponent();
        }

        public void uzsakymaiAdm_Click(object sender, EventArgs e)
        {
            naudotojaiAdmForm form4 = new naudotojaiAdmForm();
            form4.Show();
            this.Hide();
        }

        public void zaidimaiAdm_Click(object sender, EventArgs e)
        {
            Zaidimai form5 = new Zaidimai();
            form5.Show();
            this.Hide();
        }

        public void kurejaiAdm_Click(object sender, EventArgs e)
        {
            KurejaiAdm form5 = new KurejaiAdm();
            form5.Show();
            this.Hide();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Zinutes form = new Zinutes();
            form.Show();
            this.Hide();
        }
    }
}
