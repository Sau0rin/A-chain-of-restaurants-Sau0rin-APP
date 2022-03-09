using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace A_chain_of_restaurants_Sau0rin_APP
{
    public partial class fast_food : Form
    {
        public fast_food()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int position = tovari.SelectedIndex;
            if (position < 0)
                MessageBox.Show("Ничего не выбрано");
            else
            {
                string str = (string)tovari.Items[position];
                zakaz.Items.Add(str);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            int position = zakaz.SelectedIndex;
            if (position < 0)
                MessageBox.Show("Товар для удаления не выбран");
            else
                zakaz.Items.RemoveAt(position);
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Regex c = new Regex(@"\s*");
            int i = zakaz.Items.Count;
            int sum = 0;
            for (int m = 0; m < i; m++)
            {
                string s = (string)zakaz.Items[m];
                int r = int.Parse(Regex.Replace(s, @"[^\d]+", ""));
                sum += r;
            }
            if (sum == 0)
                MessageBox.Show("Вы не выбрали блюда");
            else
                MessageBox.Show("Сумма вашего заказа составляет " + sum.ToString() + "р.\n" + "Приятного аппетита!");
        }

        private void all_del_Click(object sender, EventArgs e)
        {
            zakaz.Items.Clear();
        }

        private void plus_tovar_Click(object sender, EventArgs e)
        {
            Regex c = new Regex(@"[\D]+[\d]+");
            if (c.IsMatch(textBox1.Text))
                tovari.Items.Add(textBox1.Text);
            else
                MessageBox.Show("Необходимо ввести название и стоимость");
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
        private void fast_food_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lp.X;
                this.Top += e.Y - lp.Y;
            }
        }

        private void fast_food_MouseDown(object sender, MouseEventArgs e)
        {
            lp = new Point(e.X, e.Y);
        }
    }
}
