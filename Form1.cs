using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Nodo Raiz = new Nodo();
        Int32 cantidad = 0;

        public Form1()
        {
            InitializeComponent();
            Raiz = null;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
            Nodo NuevoNodo = new Nodo();
            NuevoNodo.Dato = Int32.Parse(textBox1.Text);

            if (Raiz == null)
            {
                Raiz = NuevoNodo;
                cantidad++;
            }
            else
            {
                Nodo Actual = new Nodo();
                Actual = Raiz;
                bool flag = false;
                while (flag == false)
                {
                    if (NuevoNodo.Dato < Actual.Dato)
                    {
                        if (Actual.hijoIzq == null)
                        {
                            NuevoNodo.Padre = Actual;
                            Actual.hijoIzq = NuevoNodo;
                            flag = true;
                            cantidad++;


                        }
                        else
                        {
                            Actual = Actual.hijoIzq;
                        }
                    }
                    else
                    {
                        if (Actual.hijoDer == null)
                        {
                            NuevoNodo.Padre = Actual;
                            Actual.hijoDer = NuevoNodo;
                            flag = true;
                            cantidad++;
                        }
                        else
                        {
                            Actual = Actual.hijoDer;
                        }
                    }
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) && (e.KeyChar == (char)Keys.Subtract))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            
        

            

        }

        
    }
}
