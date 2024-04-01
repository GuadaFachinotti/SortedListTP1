using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListTP1
{
    public class Muebleria
    {
        public SortedList<int, Mueble> ListaMuebles { get; set;}

        //Constructor vacio, se inicializa la ListaMuebles
        public Muebleria() 
        {
            ListaMuebles = new SortedList<int, Mueble>();
        }

        //Metodo Agregar Mueble
        public void AgregarMueble(Mueble objeto) 
        {
            ListaMuebles.Add(objeto.Id,objeto);
        }

       
    }
}
