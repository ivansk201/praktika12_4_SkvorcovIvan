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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool sc; string info;
                Pokupnesk VAR1 = new Pokupnesk();

                sc = VAR1.Scan(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)); 
                info = VAR1.vivod();
                MessageBox.Show(info, "Сообщение", MessageBoxButtons.OK);

            }
            catch
            { MessageBox.Show("Ошибка"); }
        }
       
        

    }
}
