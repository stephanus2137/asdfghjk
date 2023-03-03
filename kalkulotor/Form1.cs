using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulotor
{
    public partial class KALKOLOTUR : Form
    {
        int x;
        int y;
        int z;
        double x2;
        double y2;
        double z2;
        char znak;
        bool prze = false;
        public KALKOLOTUR()
        {
            InitializeComponent();
        }

        private void x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (prze == false)
                {
                    x = Convert.ToInt32(wartosc1.Text);
                }
                else
                {
                    x2 = Convert.ToDouble(wartosc1.Text);
                }
            }
            catch
            {
                x = 0;
                wartosc1.Text = "";
            }
            wartosc3.Text = "";
        }

        private void wartosc2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (prze == false)
                {
                    y = Convert.ToInt32(wartosc2.Text);
                }
                else
                {
                    y2 = Convert.ToDouble(wartosc2.Text);
                }
            }
            catch
            {
                y = 0;
                wartosc2.Text = "";
            }
            wartosc3.Text = "";
        }

        private void wartosc3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mno_CheckedChanged(object sender, EventArgs e)
        {
            znak = Convert.ToChar("*");
            wartosc3.Text = "";
        }

        private void dziel_CheckedChanged(object sender, EventArgs e)
        {
            znak = Convert.ToChar("/");
            wartosc3.Text = "";
        }

        private void dod_CheckedChanged(object sender, EventArgs e)
        {
            znak = Convert.ToChar("+");
            wartosc3.Text = "";
        }

        private void min_CheckedChanged(object sender, EventArgs e)
        {
            znak = Convert.ToChar("-");
            wartosc3.Text = "";
        }

        private void EXECUTE_Click(object sender, EventArgs e)
        {
            if (prze == false)
            {
                if (znak == 42)
                {
                    z = x * y;
                    wartosc3.Text = Convert.ToString(z);
                }
                else if (znak == 47)
                {
                    if (y == 0)
                    {
                        wartosc3.Text = "Matematická chyba";
                    }
                    else
                    {
                        z = x / y;
                        wartosc3.Text = Convert.ToString(z);
                    }
                }
                else if (znak == 43)
                {
                    z = x + y;
                    wartosc3.Text = Convert.ToString(z);
                }
                else if (znak == 45)
                {
                    z = x - y;
                    wartosc3.Text = Convert.ToString(z);
                }
            }
            else
            {
                if (znak == 42)
                {
                    z2 = x2 * y2;
                    wartosc3.Text = Convert.ToString(z2);
                }
                else if (znak == 47)
                {
                    if (y2 == 0)
                    {
                        wartosc3.Text = "Matematická chyba";
                    }
                    else
                    {
                        z2 = x2 / y2;
                        wartosc3.Text = Convert.ToString(z2);
                    }
                }
                else if (znak == 43)
                {
                    z2 = x2 + y2;
                    wartosc3.Text = Convert.ToString(z2);
                }
                else if (znak == 45)
                {
                    z2 = x2 - y2;
                    wartosc3.Text = Convert.ToString(z2);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Float.Checked)
            {
                prze = true;
            }
            else
            {
                prze = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
