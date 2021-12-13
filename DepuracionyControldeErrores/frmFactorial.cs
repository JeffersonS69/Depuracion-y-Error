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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnum.Text);
            
            //usando POO
            //llamada 1
            Funciones obj1= new Funciones();
            this.txtResultado.Text = obj1.factorial(num).ToString();

            //llamada 2
            int resultado2 = (new Funciones()).factorial(6);
            MessageBox.Show("El factrial es: " + resultado2.ToString());
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnum.Text);
            try
            {
                int resultado = (new Funciones()).division_para_cero(num);
                this.txtResultado.Text = resultado.ToString();
            }catch(DivideByZeroException e1)
            {
                MessageBox.Show(e1.Message.ToString(), "Mensaje de los papus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArithmeticException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }catch(Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            finally
            {//se ejucata haya 
                this.label1.Text = "Debe corregir la función que tiene el error";
            }
            
        }

        private void btnMiPropiaException_Click(object sender, EventArgs e)
        {
            try
            {
                Funciones ob1 = new Funciones();
                int suma = ob1.divide(100, 0);
                MessageBox.Show(suma.ToString());
            }catch(Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }
            
        }
    }
}
