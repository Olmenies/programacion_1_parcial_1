using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programacion_1_parcial_1
{
    class Cola
    {
        /***atributos***/
        Nodo primerNodo; //variable de instancia para almacenar el primer nodo de la queue
        Nodo ultimoNodo; //variable de instancia para almacenar el último nodo de la queue

        /***constructores***/
        public Cola() { }//public cola

        /***métodos***/
        /// <summary>
        /// Método para encolar (agregar un elemento al final de la cola)
        /// </summary>
        /// <param name="_nombre"></param>
        /// <param name="_cantidadCopias"></param>
        public void Enqueue(string _nombre, uint _cantidadCopias)
        {
            if (EstaVacia())
                primerNodo = ultimoNodo = new Nodo(_nombre, _cantidadCopias);
            else
            {
                ultimoNodo.Siguiente = new Nodo(_nombre, _cantidadCopias, ultimoNodo, null);
                ultimoNodo = ultimoNodo.Siguiente;
            }//fin del else
        }//fin del método Enqueue()

        /// <summary>
        /// Método Dequeue para desencolar (eliminar un elemento del principio de la cola)
        /// </summary>
        public void Dequeue()
        {
            if (EstaVacia())
                return;
            else if (primerNodo == ultimoNodo)
                primerNodo = ultimoNodo = null;
            else
            {
                primerNodo = primerNodo.Siguiente;
                primerNodo.Anterior = null;
            }//fin del else
        }//fin del método Dequeue()

        /// <summary>
        /// Método Peek para ver el primer elemento de una cola
        /// </summary>
        /// <returns>null si la queue está vacía o el Nodo primer nodo de la queue si no lo está</returns>
        public Nodo Peek()
        {
            if (EstaVacia())
                return null;
            else
                return primerNodo;
        }//fin del método Peek()

        /// <summary>
        /// Método Imprimir para imprimir la cola en una dataGridView
        /// </summary>
        /// <param name="dataGridView"></param>
        public void ImprimirDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            if (EstaVacia())
                return;
            else
            {
                Nodo nodoAuxiliar = primerNodo;
                while(nodoAuxiliar != null)
                {
                    dataGridView.Rows.Add(nodoAuxiliar.Impresora, nodoAuxiliar.CantidadCopias);
                    nodoAuxiliar = nodoAuxiliar.Siguiente;
                }//fin del while
            }//fin del else
        }//fin del método Imprimir()

        /// <summary>
        /// Método EstaVacia para evaluar si la cola está vacía o no
        /// </summary>
        /// <returns>true si está vacía, false si no lo está</returns>
        private bool EstaVacia()
        {
            if ((primerNodo == ultimoNodo) && (ultimoNodo == null))
                return true;
            else
                return false;
        }//fin del método EstaVacia()
    }
}
