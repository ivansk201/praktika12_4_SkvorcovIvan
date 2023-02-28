using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika12_4
{
    class Pirojnoe
    {
        public string name="";
        public string testo="";
        public string crem="";
        public double ves;
        public double koloriynost;
        public double chena;
       
        

        public string vivod()
        {
            string pirog=("Название пироженого - " + name + "\nТесто пироженого - " + testo + "\nКрем пироженого -  " + crem + "\nВес пироженого - " + ves + "\nКолорийность пироженого - " + koloriynost + "\nЦена пироженого - " + chena+"р.");
            return pirog;
        }

        public bool Scan(string name1, string testo1, string crem1,  double ves1, double kolor1, double chena1)
        {      
            bool scan = true;
            char[] scanname = name1.ToCharArray();
            char[] scantesto= testo1.ToCharArray();
            char[] scancrem = crem1.ToCharArray();
            if (name1.Replace(" ", "") != "" && testo1.Replace(" ", "") != "" && crem1.Replace(" ", "") != "")
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
                for (int i = 0; i < scantesto.Length; i++)
                {
                    if (!Char.IsLetter(scantesto[i]))
                    {
                        MessageBox.Show("Некорректный ввод теста", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;

                    }
                }
                for (int i = 0; i < scancrem.Length; i++)
                {
                    if (!Char.IsLetter(scancrem[i]))
                    {
                        MessageBox.Show("Некорректный ввод крема", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }                             
                if (ves1 > 0 && ves1 < double.PositiveInfinity)
                {
                    ves = ves1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (kolor1 > 0 && kolor1 < double.PositiveInfinity)
                {
                    koloriynost = kolor1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
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
                
                if (scan)
                {
                    name = name1;
                    testo = testo1;
                    crem = crem1;
                    ves = ves1;
                    koloriynost = kolor1;
                    chena = chena1;
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

