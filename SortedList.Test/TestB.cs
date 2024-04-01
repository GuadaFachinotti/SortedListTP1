using SortedListTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList.Test
{
    public class TestB
    {

        [Fact]

        public void Agregar_Mueble_Y_Verificar_Su_Existencia()
        {
            var mueble1 = new Mueble(12, "Silla");
            var mueble2 = new Mueble(15, "Mesa");

            var muebleria = new Muebleria();


            muebleria.AgregarMueble(mueble1);
            muebleria.AgregarMueble(mueble2);

           
            //Se verifica que la lista no esté vacia
            Assert.NotNull(muebleria);
            //Se verifica la existencia de un mueble a partir de su clave
            Assert.Equal(true, muebleria.ListaMuebles.ContainsKey(12));


        }
        [Fact]
        //Add, Clear y Count
        public void LimpiarLista()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(mueble1.Id,mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);


            //Se verifica que la lista no esté vacía
            Assert.NotNull(listaMuebles);

            listaMuebles.Clear();
            //Se verifica si la lista está vacía
            Assert.Empty(listaMuebles);
            //Se verifica si la lita está vacía a partir de la función Count
            Assert.Equal(0, listaMuebles.Count);


        }
        [Fact]
        //Remove y
        //ContainsKey
        //ContainsValue
        public void Eliminar_Un_Elemento_De_La_Lista()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(mueble1.Id, mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);

            //Se aplica método Remove
            listaMuebles.Remove(mueble1.Id);

            
            //Se verifica si existe la clave
            Assert.Equal(false, listaMuebles.ContainsKey(18));
            //Verifica si existe el "Valor"
            Assert.Equal(true, listaMuebles.ContainsValue(mueble1));


        }
        [Fact]
        //Metodo Count
        public void Contar_Elementos_De_La_Lista()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");
            var mueble3 = new Mueble(13, "Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(mueble1.Id, mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);
            listaMuebles.Add(mueble3.Id, mueble3);


            //Se verifica la cantidad de elementos de la lista
            Assert.Equal(3, listaMuebles.Count());

            //listaMuebles.Remove(listaMuebles[18].Id);

            //Assert.Equal(2, listaMuebles.Count());
        }

        [Fact]
        //Metodo Item,
        //IndexOfKey(TKey): Obtiene el indice base cero (posicion) del objeto con la key especificada
        //IndexOfValue(TValue): Obtiene el indice base cero (posicion) de la primera aparicion del
        //                      objeto con el valor especificado
        public void Obtener_Un_Elemento()
        {
            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble2 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(1, mueble1);
            listaMuebles.Add(2, mueble2);
            listaMuebles.Add(3, mueble2);
            
            //Item
            Assert.Equal("Mesa", listaMuebles[1].Name);
            
            //IndexOfKey(Tkey)            
            Assert.Equal(1, listaMuebles.IndexOfKey(1));

            //IndexOfValue(TValue)
            Assert.Equal(2, listaMuebles.IndexOfValue(mueble2));


            Assert.True(listaMuebles.IndexOfValue(mueble2) == 2);
            Assert.False(listaMuebles.IndexOfValue(mueble2) == 3);

            //Ejemplo con error
            //Assert.True(listaMuebles.IndexOfValue(mueble2) == 3);

        }


        [Fact]
        //Metodos
        //Values
        //Keys
        public void Obtener_Listado_De_Keys_Y_Listado_De_Values()
        {
            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble2 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(1, mueble1);
            listaMuebles.Add(2, mueble2);

            var values = listaMuebles.Values;
            var keys = listaMuebles.Keys;


            //Item
            Assert.Equal(true, keys.Contains(1));

            Assert.Equal(true, values.Contains(mueble0));



            

        }
    }

}
