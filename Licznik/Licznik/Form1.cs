using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licznik
{
    public partial class FormLicznik : Form
    {
        int liczba;
        bool tekst;
        bool liczby;
        int ile = 0;
        int zakres;
        public FormLicznik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(1);
                liczby = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *" && okienko.Text != "za mała" && okienko.Text != "za duża")
            {
                if (tekst == false)
                {
                    okienko.Text += Convert.ToString(0);
                    liczby = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(2);
                liczby = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(3);
                liczby = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(4);
                liczby = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(5);
                liczby = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(6);
                liczby = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(7);
                liczby = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(8);
                liczby = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *")
            {
                if (tekst == true)
                {
                    okienko.Text = " ";
                    tekst = false;
                }
                okienko.Text += Convert.ToString(9);
                liczby = true;
            }
        }

        private void buttonGwiazdka_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            liczba = x.Next(0, zakres);
            okienko.Text = "zgaduj";
            tekst = true;
        }

        private void buttonHasz_Click(object sender, EventArgs e)
        {
            if (okienko.Text != "kliknij *" && okienko.Text != "za mała" && okienko.Text != "za duża" && okienko.Text != "zgaduj" && okienko.Text != "zgadłeś")
            {
                int twoja = Convert.ToInt32(okienko.Text);
                ile++;
                if (twoja == liczba)
                {
                    okienko.Text = "zgadłeś za " + ile + " razem";
                    tekst = true;
                }
                if (twoja > liczba)
                {
                    okienko.Text = "za duża";
                    tekst = true;
                }
                if (twoja < liczba)
                {
                    okienko.Text = "za mała";
                    tekst = true;
                }
            }

        }

        private void zakresus_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(zakresus.Text, "[^0-9]"))
            {
                zakresus.Text = zakresus.Text.Remove(zakresus.Text.Length - 1);
            }
            zakres = Convert.ToInt16(zakresus.Text);
        }
    }
}
