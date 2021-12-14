using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepuracionyControldeErrores
{
    public partial class frmDepuracion : Form
    {
        public frmDepuracion()
        {
            InitializeComponent();
        }

        private void frmDepuracion_Load(object sender, EventArgs e)
        {

        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando depuración");

            //Sumatoria de los números comprendidos en un rango dado
            int num1= int.Parse(this.txtnum1.Text);
            int num2 = int.Parse(this.txtnum2.Text);

            int suma = 0;
            for(int i=num1; i<=num2; i++)
            {
                suma += i;
            }
            this.txtResultado.Text = suma.ToString();
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            int num = 55;
            while(num>0)
            {
                num /= 2;
                if (num % 2 == 0)
                {
                    Console.WriteLine("El resto es cero");
                }
                else
                {
                    Console.WriteLine("El resto es uno");
                }
            }
        }
    }
}
