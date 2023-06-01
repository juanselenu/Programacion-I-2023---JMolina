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

namespace super_1_6
{
    public partial class Form1 : Form

    {
        List<Producto> carrito = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto miProd = new Producto();   

            miProd.marca = txtMarca.Text;
            miProd.precio = double.Parse(txtPrecio.Text); 

            carrito.Add(miProd);

            double costoApagar = 0;






            /*
            
        }*/


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
