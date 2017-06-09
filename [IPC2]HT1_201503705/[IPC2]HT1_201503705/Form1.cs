using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IPC2_HT1_201503705
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int z;
        string n1;
        string n2;
        string n3;
        string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHipotenusa_Click(object sender, EventArgs e)
        {
            x = int.Parse(Txt1.Text);
            y = int.Parse(Txt2.Text);

            double resultado;

            resultado = System.Math.Sqrt((x * x) + (y * y));

            LblResultado.Text = Convert.ToString(resultado);
        }
    }
}
