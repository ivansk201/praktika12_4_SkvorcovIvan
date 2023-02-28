using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika12_4
{
    class Pokupnesk
    {
        public string name = "";
        public double chena;
        public double shtuk;
        public double vsego;
        


        public string vivod()
        {
            string pirog = ("Название пироженого - " + name + "\nЦена пироженого - " + chena+ "р."+"\nШтук пироженого - " + shtuk+"\nПокуптка будет стоить - "+vsego+"р.");
            return pirog;
        }

        public bool Scan(string name1, double chena1, double shtuk1)
        {
            bool scan = true;
            char[] scanname = name1.ToCharArray();
           
            if (name1.Replace(" ", "") != "")
            {
                for (int i = 0; i < scanname.Length; i++)
                {
                    if (!Char.IsLetter(scanname[i]))
                    {
                        MessageBox.Show("Некорректный ввод названия", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }               
                if (chena1 > 0 && chena1 < double.PositiveInfinity)
                {
                    chena = chena1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (shtuk1 > 0 && shtuk1 < double.PositiveInfinity)
                {
                    shtuk = shtuk1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }                
                if (scan)
                {
                    name = name1;
                    shtuk = shtuk1;
                    chena = chena1;
                    
                    vsego = chena1 * shtuk1;
                }
                return scan;
                
            }
            else
            {
                MessageBox.Show("Найдены пустая строка(и)", "Сообщение", MessageBoxButtons.OK);
                scan = false;
                return scan;
            }

        }
    }
}
