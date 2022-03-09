using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_chain_of_restaurants_Sau0rin_APP
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jap_kit_Click(object sender, EventArgs e)
        {
            this.Hide();
            japan japan = new japan();
            japan.Show();
        }

        private void italy_kit_Click(object sender, EventArgs e)
        {
            this.Hide();
            italy italy = new italy();
            italy.Show();
        }

        private void fast_kit_Click(object sender, EventArgs e)
        {
            this.Hide();
            fast_food fast_Food = new fast_food();
            fast_Food.Show();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Transparent;
        }

        Point lp;
        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lp.X;
                this.Top += e.Y - lp.Y;
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            lp = new Point(e.X, e.Y);
        }
    }
}
