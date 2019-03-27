using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        OperacionRestas ingresoresta;
        OperacionMulti ingresomulti;
        OperacionDiv ingresodiv;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(textBox1.Text);
            ingreso.V2 = double.Parse(textBox2.Text);

            label3.Text=ingreso.calcular().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

           ingresoresta = new OperacionRestas();
           ingresoresta.R1 = double.Parse(textBox1.Text);
           ingresoresta.R2 = double.Parse(textBox2.Text);

           label3.Text=ingresoresta.CalcularResta().ToString();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresomulti = new OperacionMulti();
            ingresomulti.M1 = double.Parse(textBox1.Text);
            ingresomulti.M2 = double.Parse(textBox2.Text);

            label3.Text = ingresomulti.calcularmulti().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingresodiv = new OperacionDiv();
            ingresodiv.D1 = double.Parse(textBox1.Text);
            ingresodiv.D2 = double.Parse(textBox2.Text);

            label3.Text = ingresodiv.calculardiv().ToString();
        }
    }
}
