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
        //agregue un capacity 
        //public class SortedListTests
        //{
        //    [Fact]
        //    public void SortedList_Capacity_WorkCorrectly()
        //    {
        //        // Arrange
        //        var sortedList = new SortedList<int, Mueble>(capacity: 5);

        //        // Act & Assert
        //        Assert.Equal(0, sortedList.Count);
        //        Assert.Equal(5, sortedList.Capacity);
        //    }

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
           
           /* [Fact]
            public void SortedList_Comparer_Property()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>(new MuebleComparer());

                // Act & Assert
                Assert.IsType<MuebleComparer>(sortedList.Comparer);
            }*/

            [Fact]
            public void SortedList_Count_Property()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                // Act & Assert
                Assert.Equal(2, sortedList.Count);
            }

            [Fact]
            public void SortedList_Item_Property()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                var mueble = new Mueble(1, "Ropero");
                sortedList.Add(1, mueble);

                // Act
                var retrievedMueble = sortedList[1];

                // Assert
                Assert.Equal(mueble, retrievedMueble);
            }

            [Fact]
            public void SortedList_Keys_Property()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                // Act
                var keys = sortedList.Keys;

                // Assert
                Assert.Contains(1, keys);
                Assert.Contains(2, keys);
            }

            [Fact]
            public void SortedList_Values_Property()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                var mueble2 = new Mueble(2, "Escritorio");
                sortedList.Add(1, mueble1);
                sortedList.Add(2, mueble2);

                // Act
                var values = sortedList.Values;

                // Assert
                Assert.Contains(mueble1, values);
                Assert.Contains(mueble2, values);
            }
            [Fact]
            public void SortedList_Remove_Method()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                var mueble2 = new Mueble(2, "Escritorio");
                sortedList.Add(mueble1.Id, mueble1);
                sortedList.Add(mueble2.Id, mueble2);

                // Act
                sortedList.Remove(1); // Elimina el mueble con ID 1

                // Assert
                Assert.Equal(1, sortedList.Count);
                Assert.DoesNotContain(1, sortedList.Keys);
            }
            //empieza
            [Fact]
            public void SortedList_Clear_Method()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                // Act
                sortedList.Clear();

                // Assert
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
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                var mueble1 = new Mueble(1, "Ropero");
                

                // Act & Assert
                Assert.True(sortedList.ContainsValue(mueble1));
                Assert.False(sortedList.ContainsValue(new Mueble(2, "Escritorio")));
            }

            [Fact]
            public void SortedList_GetEnumerator_Method()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                // Act
                var enumerator = sortedList.GetEnumerator();

                // Assert
                Assert.NotNull(enumerator);
            }

            [Fact]
            public void SortedList_Equals_Method()
            {
                // Arrange
                var sortedList1 = new SortedList<int, Mueble>();
                sortedList1.Add(1, new Mueble(1, "Ropero"));
           
                var sortedList3 = new SortedList<int, Mueble>();
                sortedList3.Add(3, new Mueble(3, "Sofá"));

                // Act & Assert
                Assert.True(sortedList1.Equals(sortedList1));
                Assert.False(sortedList1.Equals(sortedList3));
            }


            [Fact]
            public void SortedList_TrimExcess_Method()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>(capacity: 10);
                sortedList.Add(1, new Mueble(1, "Ropero"));
                sortedList.Add(2, new Mueble(2, "Escritorio"));

                // Act
                sortedList.TrimExcess();

                // Assert
                Assert.Equal(2, sortedList.Capacity);
            }
            [Fact]
            public void Clone_ShouldReturnACloneOfSortedList()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>();
                sortedList.Add(1, new Mueble(1, "Chair"));
                sortedList.Add(2, new Mueble(2, "Table"));

                // Act
                var clone = new SortedList<int, Mueble>(sortedList);
                // Assert
                Assert.NotSame(sortedList, clone);
                Assert.Equal(sortedList, clone);
            }

        }
    }
}
 

 /* [Fact]
  public void IsFixedSize_ShouldReturnFalse()
  {
      // Arrange
      var sortedList = new SortedList<int, Mueble>();

      // Act
      var isFixedSize = sortedList.IsFixedSize;

      // Assert
      Assert.False(isFixedSize);
  }

  [Fact]
  public void IsReadOnly_ShouldReturnFalse()
  {
      // Arrange
      var sortedList = new SortedList<int, Mueble>();

      // Act
      var isReadOnly = sortedList.AsReadOnly;*/

