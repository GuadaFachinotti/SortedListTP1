using SortedListTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList.Test
{
    public class TestC
    {
        [Fact]
        public void TestSortedListCapacity()
        {
            // Crear una nueva SortedList con capacidad inicial de 3
            var sortedList = new SortedList<int, Mueble>(capacity: 3);

            // Agregar algunos muebles
            sortedList.Add(3, new Mueble(3, "Mesa"));
            sortedList.Add(1, new Mueble(1, "Silla"));
            sortedList.Add(2, new Mueble(2, "Armario"));

            // Comprobar la capacidad
            Assert.Equal(3, sortedList.Capacity);

            // Agregar más elementos para probar la capacidad automática
            sortedList.Add(4, new Mueble(4, "Cama"));
            sortedList.Add(5, new Mueble(5, "Escritorio"));

            // Comprobar que la capacidad se ajustó automáticamente
            Assert.Equal(6, sortedList.Capacity);
        }




    }
}
