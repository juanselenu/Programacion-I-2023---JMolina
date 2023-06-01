using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circulo micirculo = new circulo();

            micirculo.Radio = 5;
            micirculo.Nombre = "circulito";
            MessageBox.Show(micirculo.DecimeQuiensos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            circulo micirculo = new circulo();
            micirculo.Radio = double.Parse (textBox2.Text);
            micirculo.Nombre = textBox1.Text;

            //print por un popap
            MessageBox.Show(micirculo.DecimeQuiensos());
            /* print por un label
             lablel3.text = micirculo.DecimeQuiensos();
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
