using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListTP1
{
    //Creamos una clase ComparadorDescendente
    //que implementa IComparer<int>.
    //En el método Compare, invertimos el orden
    //de comparación para que sea descendente.
    public class ComparadorDescendente : IComparer<int>
    {
        public int Compare(int x, int y)
        { 
            return y.CompareTo(x); 
        }
    }
}
