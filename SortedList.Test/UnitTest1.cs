using SortedListTP1;

namespace SortedList.Test
{
    public class UnitTest1
    {

        //--------------------------Capacity----------------------------------
        //--------------------------TrimExcess-------------------------------
        [Fact]
        public void Crear_SortedList_Con_Capacidad_3_Elementos()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");
            var mueble3 = new Mueble(13, "Ropero");
            var mueble4 = new Mueble(14, "Escritorio");
            var mueble5 = new Mueble(17, "Cama");

            var listaMuebles = new SortedList<int, Mueble>(capacity: 4);
            //Assert.Equal(3, listaMuebles.Count());

            listaMuebles.Add(mueble1.Id, mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);

            //Verificamos la capacidad y la cantidad de elementos
            Assert.Equal(4, listaMuebles.Capacity);
            Assert.Equal(2, listaMuebles.Count);

            //Si nos excedemos de la capacidad establecida el capacity se duplica

            listaMuebles.Add(mueble3.Id, mueble3);
            listaMuebles.Add(mueble4.Id, mueble4);
            listaMuebles.Add(mueble5.Id, mueble5);
            Assert.Equal(8, listaMuebles.Capacity);
            //Al aplicar TrimExcess la lista ajusta su capacity a la cantidad de elementos 
            listaMuebles.TrimExcess();
            Assert.Equal(5, listaMuebles.Capacity);


        }


    }
}
