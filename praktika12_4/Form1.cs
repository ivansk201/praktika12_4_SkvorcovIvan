using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika12_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool sc; string info;
                Pirojnoe VAR1 = new Pirojnoe();

                sc = VAR1.Scan(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
              info =  VAR1.vivod();
                MessageBox.Show(info, "Сообщение", MessageBoxButtons.OK);

            }
            catch
            { MessageBox.Show("Ошибка"); }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }
    }
}
