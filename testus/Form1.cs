using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testus
{
    public partial class Form1 : Form
    {
        int ch, kodus = 1;
        string tekstus, tekstus2;
        char lit;
        bool blad = false;
        bool debil = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tekstus = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ch = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ch = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ch = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                debil = false;
            }
            else
            {
                debil = true;
            }
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            kodus = Convert.ToInt32(numericUpDown1.Value);
        }

        private void szyfruj_Click(object sender, EventArgs e)
        {
            blad = false;
            if (debil == false)
            {
                for (int i = 0; i < tekstus.Length; i++)
                {
                    lit = tekstus[i];
                    if ((ch == 0) && ((Char.IsUpper(lit)) || (Char.IsDigit(lit))))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    else if ((ch == 1) && ((Char.IsLower(lit)) || (Char.IsDigit(lit))))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    else if ((ch == 2) && (Char.IsLetter(lit)))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    lit = (Char)(Convert.ToUInt16(lit) + kodus);
                    if ((ch == 2) && (lit > 57))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) - 10);
                    }
                    else if ((ch == 2) && (lit < 48))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) + 10);
                    }
                    if ((ch == 0) && (kodus < 0))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) + 26);
                    }
                    tekstus2 = tekstus2 + lit;
                }
            }
            else if (debil == true)
            {
                for (int i = 0; i < tekstus.Length; i++)
                {
                    lit = tekstus[i];
                    if ((ch == 0) && ((Char.IsUpper(lit)) || (Char.IsDigit(lit))))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    else if ((ch == 1) && ((Char.IsLower(lit)) || (Char.IsDigit(lit))))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    else if ((ch == 2) && (Char.IsLetter(lit)))
                    {
                        MessageBox.Show("poza zakresem");
                        blad = true;
                        break;
                    }
                    lit = (Char)(Convert.ToUInt16(lit) - kodus);
                    if ((ch == 2) && (lit < 48))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) + 10);
                    }
                    else if ((ch == 2) && (lit > 57))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) - 10);
                    }
                    if ((ch == 0) && (kodus < 0))
                    {
                        lit = (Char)(Convert.ToUInt16(lit) - 26);
                    }
                    tekstus2 = tekstus2 + lit;
                }
            }
            if (blad == false)
            {
                MessageBox.Show(tekstus2);
            }
            tekstus2 = "";
        }
    }
}
