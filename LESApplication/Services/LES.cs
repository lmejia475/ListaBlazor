using LESApplication.Models;
<<<<<<< HEAD
using System.Threading.Channels;

namespace LESApplication.Services
{
    public class LES 
    {
        public Nodo? PrimerNodo { get; set; }
        public Nodo? UltimoNodo { get; set; }
     
=======

namespace LESApplication.Services
{
    public class LES
    {
        public Nodo? PrimerNodo { get; set; }
        public Nodo? UltimoNodo { get; set; }
>>>>>>> 2056943da303ca152d1a882aa374459971def641

        public LES()
        {
            PrimerNodo = null;
            UltimoNodo = null;
<<<<<<< HEAD
 
=======
>>>>>>> 2056943da303ca152d1a882aa374459971def641
        } 

        bool EstaVacia()
        {
            return PrimerNodo == null;
        }

        public string AgregarNodoFinal(Nodo nuevoNodo)
        {
            if (EstaVacia())
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            else
            {
                UltimoNodo.Referencia = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            return "Nodo agregado al final de la lista";
        }
        public string AgregarNodoInicio(Nodo nuevoNodo)
        {
            if (EstaVacia())
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Referencia = PrimerNodo;
                PrimerNodo = nuevoNodo;
            }
            return "Nodo agregado al final de la lista";
        }
<<<<<<< HEAD
        public Nodo? BuscarNodo(string x)
        {
            Nodo? actual = PrimerNodo;

            while (actual != null)
            {
                if (actual.Informacion == x)
                {
                    return actual; 
                }
                actual = actual.Referencia;
            }

            Console.WriteLine("\nNodo no encontrado");
            return null; 
        }


        public string AgregarNodoDespuesDeX(string x, String nuevoDato)
        {
            Nodo? nodoX = BuscarNodo(x);
            if(nodoX != null)
            {
                Nodo nuevoNodo = new Nodo(nuevoDato);
                nuevoNodo.Referencia = nodoX.Referencia;
                nodoX.Referencia = nuevoNodo;
                if (nodoX == UltimoNodo)
                {
                    UltimoNodo = nuevoNodo;
                }
            }
            else
            {
                return "Nodo x es nulo";
            }
                return "Nodo agregado despues de x";
        }
        public string AgregarNodoAntesDeX(string x, String nuevoDato)
        {
            Nodo? nodoX = BuscarNodo(x);
            if (nodoX != null)
            {
                Nodo nuevoNodo = new Nodo(nuevoDato);
                if (nodoX == PrimerNodo)
                {
                    nuevoNodo.Referencia = PrimerNodo;
                    PrimerNodo = nuevoNodo;
                }
                else
                {
                    Nodo actual = PrimerNodo;
                    while(actual !=null && actual.Referencia != nodoX)
                    {
                        actual = actual.Referencia;
                    }
                    if (actual != null)
                    {
                        nuevoNodo.Referencia = nodoX;
                        actual.Referencia = nuevoNodo;
                    }
                }
                return "Nodo Agregado antes de X";

            }
            else
            {
                return "Nodo X no encontrado";
            }
            
        }


=======
>>>>>>> 2056943da303ca152d1a882aa374459971def641
    }
}
