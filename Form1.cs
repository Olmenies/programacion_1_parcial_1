using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacion_1_parcial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        Cola miCola = new Cola(); //Instanciación de una cola
        const int CANTIDAD_COLUMNAS = 2; //Cantidad columnas de la dataGridView
        string[] headersArray = new string[CANTIDAD_COLUMNAS] { "Impresora", "Cantidad de copias" }; //Headers de la dataGridView

        //evento buttonHPOne_Click para agregar una impresora al final de la cola
        private void buttonHPOne_Click(object sender, EventArgs e)
        {
            if (!EsTextBoxValido())
            {
                uint cantidadImpreiones = Convert.ToUInt32(textBoxCantidadImpresiones.Text);
                string impresora = "HP One";

                miCola.Enqueue(impresora, cantidadImpreiones);
                miCola.ImprimirDataGridView(dataGridView1);
            }//fin del if
        }//fin del evento buttonHPOne_Click()

        //evento buttonIBMFullColor_Click para agregar una impresora al final de la cola
        private void buttonIBMFullColor_Click(object sender, EventArgs e)
        {
            if (!EsTextBoxValido())
            {
                uint cantidadImpreiones = Convert.ToUInt32(textBoxCantidadImpresiones.Text);

                miCola.Enqueue("IBM Full Color", cantidadImpreiones);
                miCola.ImprimirDataGridView(dataGridView1);
            }//fin del if
        }//fin del evento buttonIBMFullColor_Click()

        //evento buttonXEROXPrint_Click para agregar una impresora al final de la cola
        private void buttonXEROXPrint_Click(object sender, EventArgs e)
        {
            if (!EsTextBoxValido())
            {
                uint cantidadImpreiones = Convert.ToUInt32(textBoxCantidadImpresiones.Text);
                string impresora = "XEROX Print";

                miCola.Enqueue(impresora, cantidadImpreiones);
                miCola.ImprimirDataGridView(dataGridView1);
            }//fin del if
        }//fin del evento buttonXEROXPrint_Click()

        //evento buttonHPTL1_Click para agregar una impresora al final de la cola
        private void buttonHPTL1_Click(object sender, EventArgs e)
        {
            if (!EsTextBoxValido())
            {
                uint cantidadImpreiones = Convert.ToUInt32(textBoxCantidadImpresiones.Text);
                string impresora = "HP - TL1";

                miCola.Enqueue(impresora, cantidadImpreiones);
                miCola.ImprimirDataGridView(dataGridView1);
            }//fin del if
        }//fin del evento buttonHPTL1_Click()

        //evento buttonSalir_Click para salir del programa
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fin del evento buttonSalir_Click()

        //evento buttonImprimirDataGridView_Clic para eliminar el primer elemento de la cola
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            Nodo nodo = miCola.Peek();

            miCola.Dequeue();
            miCola.ImprimirDataGridView(dataGridView1);

            if(nodo != null)
                MessageBox.Show("Se está imprimiendo en " + nodo.Impresora + nodo.CantidadCopias + " copia(s).", "Programación 1 - Parcial 1");
            else
                MessageBox.Show("No hay elementos para imprimir en la cola", "Programación 1 - Parcial 1");

        }//fin del evento buttonImprimirDataGridView_Click()

        //método InicializarDataGridView para llenar la dataGridView con las columnas definidas
        private void InicializarDataGridView()
        {
            for (int i = 0; i < CANTIDAD_COLUMNAS; i++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = headersArray[i];
                dataGridView1.Columns.Add(columna);
                columna.Width = 172;
            }//fin del for

            dataGridView1.ReadOnly = true;

        }//fin del método InicializarDataGridView()

        //método esTextBoxValido que devuelve true si textBoxCantidadImpresiones tiene información válida o false si no
        private bool EsTextBoxValido()
        {
            if(!(uint.TryParse(textBoxCantidadImpresiones.Text, out uint result)) || (textBoxCantidadImpresiones.Text == "0"))
            {
                MessageBox.Show("Por favor, ingresar un valor válido.", "Programación 1 - Parcial 1");
                return true;
            }//fin del if
            else
            {
                return false;
            }//fin del else
        }//fin del método EsTextBoxValido()
    }
}
