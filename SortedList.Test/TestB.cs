﻿using SortedListTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList.Test
{
    public class TestB
    {
        //Metodos
        //---------------------------Add-------------------------------
        //---------------------------Clear-----------------------------
        //---------------------------Count-----------------------------
        [Fact]
      
        public void LimpiarLista()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(mueble1.Id, mueble1);
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
        //-----------------------Remove y RemoveAt---------------------
        //-----------------------ContainsKey---------------------------
        //-----------------------ContainsValue-------------------------
        public void Eliminar_Un_Elemento_De_La_Lista()
        {
            var mueble0 = new Mueble(0, "Silla");
            var mueble1 = new Mueble(1, "Mesa");
            var mueble2 = new Mueble(2, "Ropero");
            var mueble3 = new Mueble(3, "Cama");
            var mueble4 = new Mueble(4, "Escritorio");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(mueble0.Id, mueble0);
            listaMuebles.Add(mueble1.Id, mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);
            listaMuebles.Add(mueble3.Id, mueble3);
            listaMuebles.Add(mueble4.Id, mueble4);


            //Se aplica método Remove 
            listaMuebles.Remove(mueble1.Id);


            //Se verifica si existe la clave
            Assert.Equal(false, listaMuebles.ContainsKey(1));

            //Verifica si existe el "Valor"
            Assert.Equal(true, listaMuebles.ContainsValue(mueble2));


            //Se aplica RemoveAt, eliminando por posicion (indice)
            listaMuebles.RemoveAt(3);

            //Se verifica si se eliminó la posicion 3, es decir se elimina Escritorio y 
            //Se busca por la key
            Assert.Equal(false, listaMuebles.ContainsKey(4));

            


        }

        //-------------------------------GetEnumerator-----------------------
        [Fact]

        public void Recorrer_Enumerador()
        {
            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble2 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(10, mueble1);
            listaMuebles.Add(20, mueble2);

            
            var enumerador = listaMuebles.GetEnumerator();
            

            while(enumerador.MoveNext()) 

            {   //verificamos la existencia del contenido actual del enumerador en la SortedList "listaMuebles"
                Assert.True(listaMuebles.ContainsKey(enumerador.Current.Key));
                //enumerador.Current Devuelve el par Clave valor de la posicion actual del enumerador
                Assert.True(listaMuebles.ContainsValue(enumerador.Current.Value));



            }


        }




        //------------------------------GetKeyAtIndex--------------------------
        //------------------------------GetValueAtIndex------------------------
        [Fact]
        public void Obtiene_La_Key_Y_Value_De_Un_Elemento_Por_Indice()
        {
            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble18 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(1, mueble1);
            listaMuebles.Add(18, mueble18);




            //GetKeyAtIndex(Int32), Obtiene la Key de acuerdo al indice especificado            
            Assert.Equal(18, listaMuebles.GetKeyAtIndex(2));

            //GetValueAtIndex(Int32) Obtiene el Value(el objeto mueble) de acuerdo al indice especificado
            Assert.Equal(mueble18, listaMuebles.GetValueAtIndex(2));



        }

        //---------------------------------IndexOfKey----------------------------------
        //---------------------------------IndexOfValue--------------------------------
        [Fact]
        //Item,
        //IndexOfKey(TKey): Obtiene el indice base cero (posicion) del objeto con la key especificada
        //IndexOfValue(TValue): Obtiene el indice base cero (posicion) de la primera aparicion del
        //                      objeto con el valor especificado
        public void Obtener_Indice_De_Un_Elemento_Por_Key_Value()
        {
            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble2 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(1, mueble1);
            listaMuebles.Add(2, mueble2);
            listaMuebles.Add(3, mueble2);
            

            //Se utiliza Item, verificamos que Existe el Value.name de la la Key especificada
            Assert.Equal("Mesa", listaMuebles[1].Name);

            //IndexOfKey(Tkey), obtiene el indice de acuerdo a la key            
            Assert.Equal(1, listaMuebles.IndexOfKey(1));

            //IndexOfValue(TValue)
            Assert.Equal(2, listaMuebles.IndexOfValue(mueble2));


            Assert.True(listaMuebles.IndexOfValue(mueble2) == 2);
            Assert.False(listaMuebles.IndexOfValue(mueble2) == 3);

            //Ejemplo con error
            //Assert.True(listaMuebles.IndexOfValue(mueble2) == 3);

        }





        //---------------------------SetValueAtIndex----------------------------

        [Fact]
        public void Actualizar_El_Valor_Segun_Indice()
        {

            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble18 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(10, mueble1);
            //obtengo el value del indice 1
            Assert.Equal(mueble1, listaMuebles.GetValueAtIndex(1));

            //actualizamos el value del indice 1

            listaMuebles.SetValueAtIndex(1, mueble18);

            Assert.Equal(mueble18, listaMuebles.GetValueAtIndex(1));


        }


        //----------------------------TryGetValue--------------------------------
        [Fact]
        public void Obtiene_El_Value_De_Un_Elemento_Por_Key_Si_Existe()
        {

            var mueble0 = new Mueble("Silla");
            var mueble1 = new Mueble("Mesa");
            var mueble18 = new Mueble("Ropero");

            var listaMuebles = new SortedList<int, Mueble>();


            listaMuebles.Add(0, mueble0);
            listaMuebles.Add(1, mueble1);
            listaMuebles.Add(18, mueble18);

            Mueble valorEncontrado;
            //Busca un value asociado a una Key y si lo encuentra lo asigna a la variable especificada
            //Y devuelve True
            if (listaMuebles.TryGetValue(1, out valorEncontrado))
            {
                Assert.Equal(mueble1, valorEncontrado);
            }

            //Si no lo encuentra devuelve False y no asigna ningun value
            Mueble valorNoEncontrado;
            listaMuebles.TryGetValue(16, out valorNoEncontrado);
            
                Assert.Null(valorNoEncontrado);
            




            //GetKeyAtIndex(Int32), Obtiene la Key de acuerdo al indice especificado            
            Assert.Equal(18, listaMuebles.GetKeyAtIndex(2));

            //GetValueAtIndex(Int32) Obtiene el Value(el objeto mueble) de acuerdo al indice especificado
            Assert.Equal(mueble18, listaMuebles.GetValueAtIndex(2));



        }

        //--------------------------------------------------------------------
        //Propiedades

        //--------------------------Capacity----------------------------------
        //--------------------------TryGetValue-------------------------------
        [Fact]
        public void Crear_SortedList_Con_Capacidad_3_Elementos()
        {
            var mueble1 = new Mueble(18, "Silla");
            var mueble2 = new Mueble(15, "Mesa");
            var mueble3 = new Mueble(13, "Ropero");
            var mueble4 = new Mueble(14, "Escritorio");
            var mueble5 = new Mueble(17, "Cama");

            var listaMuebles = new SortedList<int, Mueble>(capacity:4);
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

        //Comparer
        [Fact]
        public void Ordenar_Lista_Por_Key_Descendente()
        {
            var mueble1 = new Mueble(1, "Silla");
            var mueble2 = new Mueble(2, "Mesa");
            var mueble3 = new Mueble(3, "Ropero");
            //Se crea la SortedList pasando una instancia de Comparador Descendente
            //al constructor
            var listaMuebles = new SortedList<int, Mueble>(new ComparadorDescendente());


            listaMuebles.Add(mueble1.Id, mueble1);
            listaMuebles.Add(mueble2.Id, mueble2);
            listaMuebles.Add(mueble3.Id, mueble3);


            
            Assert.Equal(3, listaMuebles.GetKeyAtIndex(0));

            
        }


        //--------------------Count-----------------------
        [Fact]
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
        //item

        //--------------------------Keys----------------------
        //--------------------------Values--------------------
        [Fact]
        
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


            
            Assert.Equal(true, keys.Contains(0));
            Assert.Equal(true, keys.Contains(1));
            Assert.Equal(true, keys.Contains(2));

            Assert.Equal(true, values.Contains(mueble0));
            Assert.Equal(true, values.Contains(mueble1));
            Assert.Equal(true, values.Contains(mueble2));


        }

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
       
        
      

        

      
    }

}
