using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int bil_ganjil = Convert.ToInt32(textBox1.Text);
            List<int> list = new List<int>();
            for (int i = 0; i < bil_ganjil; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            for (int ii = 0; ii < list.Count; ii++)
            {
                if(ii == list.Count - 1)
                {
                    label1.Text += list[ii];
                }
                else
                {
                    label1.Text += list[ii] + " ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int bil_prima = Convert.ToInt32(textBox1.Text);
            bool prima = true;
            if(bil_prima >= 2)
            {
                for (int i = 2; i <= bil_prima; i++)
                {
                    for (int ii = 2; ii < i; ii++)
                    {
                        if((i % ii) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }
                    if(prima == true)
                    {
                        label1.Text += i.ToString() + " ";
                    }
                    prima = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int bilangan = Convert.ToInt32(textBox1.Text);
            int ff = textBox1.Text.Length;

            for (int i = 0; i < ff; i++)
            {
                string angka = textBox1.Text.Substring(i,1);
                
                for (int ii = 0; ii <= i; ii++)
                {
                    if (ii == 0)
                    {
                        label1.Text += angka;
                        label1.Text += "0";
                    }
                    else
                    {
                        label1.Text += "0";
                    }
                }
                label1.Text += "\n";
            }
            
        }
    }
}
