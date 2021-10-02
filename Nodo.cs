using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_parcial_1
{
    class Nodo
    {
        /***atributos***/
        private string impresora; //variable de instancia para almacenar el nombre de la impresora
        private uint cantidadCopias; //variable de instancia para almacenar la cantidad de copias
        private Nodo anterior; //variable de instancia para almacenar una referencia al nodo anterior
        private Nodo siguente; //variable de instancia para almacenar una referencia al nodo siguiente


        /***constructores***/
        public Nodo(string _impresora, uint _cantidadCopias, Nodo _anterior, Nodo _siguiente)
        {
            Impresora = _impresora;
            CantidadCopias = _cantidadCopias;
            Anterior = _anterior;
            Siguiente = _siguiente;
        }//fin del constructor

        public Nodo(string _impresora, uint _cantidadCopias)
            :this(_impresora, _cantidadCopias, null, null) { }//fin del constructor

        /***propiedades***/
        public string Impresora
        {
            get
            {
                return impresora;
            }//fin del get
            set
            {
                impresora = value;
            }//fin del set
        }//fin de la propiedad Impresora
        public uint CantidadCopias
        {
            get
            {
                return cantidadCopias;
            }//fin del get
            set
            {
                cantidadCopias = value;
            }//fin del set
        }//fin de la propiedad CantidadCopias
        public Nodo Anterior
        {
            get
            {
                return anterior;
            }//fin del get
            set
            {
                anterior = value;
            }//fin del set
        }//fin de la propiedad Anterior
        public Nodo Siguiente
        {
            get
            {
                return siguente;
            }//fin del get
            set
            {
                siguente = value;
            }//fin del set
        }//fin de la propiedad  Siguiente

    }//fin dela clase Nodo
}
