using SortedListTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList.Test
{
    public class TestA
    {

        public class SortedListTests
        {
            [Fact]
            public void SortedList_Capacity_WorkCorrectly()
            {
                var sortedList = new SortedList<int, Mueble>(capacity: 5);

                Assert.Equal(0, sortedList.Count);
                Assert.Equal(5, sortedList.Capacity);
            }

            [Fact]
            //count values
            public void AgregarEnLista()
            {
                var lista = new SortedList<int, Mueble>();

                Mueble mueble1 = new Mueble(1, "Ropero");
                Mueble mueble2 = new Mueble(2, "Escritorio");

                lista.Add(mueble1.Id, mueble1);
                lista.Add(mueble2.Id, mueble2);

                Mueble mueble3 = new Mueble(3, "Silla");

                lista.Add(3, mueble3);

                Assert.Equal(3, lista.Count);
                Assert.Equal("Escritorio", lista[2].Name);
                Assert.Contains(mueble3, lista.Values);
            }

            [Fact]
            public void SortedList_Count_Property()
            {
           
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                Assert.Equal(2, sortedList.Count);
            }

            [Fact]
            public void SortedList_Item_Property()
            {
                var sortedList = new SortedList<int, Mueble>();
                var mueble = new Mueble(1, "Ropero");
                sortedList.Add(1, mueble);

                var retrievedMueble = sortedList[1];

                Assert.Equal(mueble, retrievedMueble);
            }

            [Fact]
            public void SortedList_Keys_Property()
            {
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                var keys = sortedList.Keys;

                Assert.Contains(1, keys);
                Assert.Contains(2, keys);
            }

            [Fact]
            public void SortedList_Values_Property()
            {
                
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                var mueble2 = new Mueble(2, "Escritorio");
                sortedList.Add(1, mueble1);
                sortedList.Add(2, mueble2);

                var values = sortedList.Values;

                Assert.Contains(mueble1, values);
                Assert.Contains(mueble2, values);
            }
            [Fact]
            public void SortedList_Remove_Method()
            {
              
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                var mueble2 = new Mueble(2, "Escritorio");
                sortedList.Add(mueble1.Id, mueble1);
                sortedList.Add(mueble2.Id, mueble2);

                sortedList.Remove(1); // Elimina el mueble con ID 1

                Assert.Equal(1, sortedList.Count);
                Assert.DoesNotContain(1, sortedList.Keys);
            }
            
            [Fact]
            public void SortedList_Clear_Method()
            {
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                sortedList.Clear();

                Assert.Empty(sortedList);
            }

            [Fact]
            public void Verificar_Si_Existe_Clave_Valor()
            {

                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                var mueble2 = new Mueble(2, "Escritorio");

                sortedList.Add(1, mueble1);

                Assert.True(sortedList.ContainsKey(1));
                Assert.True(sortedList.ContainsValue(mueble1));

                Assert.False(sortedList.ContainsKey(2));
                Assert.False(sortedList.ContainsValue(mueble2));


            }

            [Fact]
            public void SortedList_ContainsValue_Method()
            {
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");

                Assert.True(sortedList.ContainsValue(mueble1));
                Assert.False(sortedList.ContainsValue(new Mueble(2, "Escritorio")));
            }

            [Fact]
            public void SortedList_GetEnumerator_Method()
            {
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                var enumerator = sortedList.GetEnumerator();

                Assert.NotNull(enumerator);
            }

            [Fact]
            public void SortedList_Equals_Method()
            {
                var sortedList1 = new SortedList<int, Mueble>();
                sortedList1.Add(1, new Mueble(1, "Ropero"));

                var sortedList3 = new SortedList<int, Mueble>();
                sortedList3.Add(3, new Mueble(3, "Sofá"));

                Assert.True(sortedList1.Equals(sortedList1));
                Assert.False(sortedList1.Equals(sortedList3));
            }


            [Fact]
            public void SortedList_TrimExcess_Method()
            {
                var sortedList = new SortedList<int, Mueble>(capacity: 10);
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                sortedList.TrimExcess();

                Assert.Equal(2, sortedList.Capacity);
            }
            [Fact]
            public void Clone_ShouldReturnACloneOfSortedList()
            {
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Chair"));
                sortedList.Add(2, new Mueble(2, "Table"));

                var clone = new SortedList<int, Mueble>(sortedList);
               
                Assert.NotSame(sortedList, clone);
                Assert.Equal(sortedList, clone);
            }

        }
    }
}


 



