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
        public void ComprobarCapacidad()
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

        [Fact]
        public void AgregarEnLista()
        {
            var lista = new SortedList<int, Mueble>();

            Mueble mueble1 = new Mueble(1,"silla");
            Mueble mueble2 = new Mueble(6, "mesa");
            Mueble mueble3 = new Mueble(3, "placar");

            lista.Add(mueble1.Id, mueble1);
            lista.Add(mueble2.Id, mueble2);
            lista.Add(mueble3.Id, mueble3);

            Assert.Equal(3, lista.Count);
            Assert.Equal("mesa", lista[6].Name);
            Assert.Contains(mueble3, lista.Values);




         
        }
        //****************************************

        [Fact]
        public void Count_ShouldReturnNumberOfItems()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();

            // Act
            sortedList.Add(1, new Mueble(1, "Chair"));
            sortedList.Add(2, new Mueble(2, "Table"));

            // Assert
            Assert.Equal(2, sortedList.Count);
        }


        [Fact]
        public void SortedList_Capacity_WorkCorrectly()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>(capacity: 5);

            // Act & Assert
            Assert.Equal(0, sortedList.Count);
            Assert.Equal(5, sortedList.Capacity);
        }

        [Fact]
        public void Comparer_ShouldReturnDefaultComparer()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();

            // Act
            var comparer = sortedList.Comparer;

            // Assert
            Assert.Equal(Comparer<int>.Default, comparer);
        }
        
        [Fact]
        public void Count()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));

            // Act
            var count = sortedList.Count;

            // Assert
            Assert.Equal(1, count);
        }

        [Fact]
        public void Item_ShouldReturnItemByKey()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            var mueble = new Mueble(1, "Chair");
            sortedList.Add(1, mueble);

            // Act
            var retrievedMueble = sortedList[1];

            // Assert
            Assert.Equal("Chair", retrievedMueble.Name);
        }

        [Fact]
        public void Keys_ShouldReturnKeysInSortedList()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));
            sortedList.Add(2, new Mueble(2, "Table"));

            // Act
            var keys = sortedList.Keys;

            // Assert
            Assert.Equal(new List<int> { 1, 2 }, keys);
        }

        [Fact]
        public void Values_ShouldReturnValuesInSortedList()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            var chair = new Mueble(1, "Chair");
            var table = new Mueble(2, "Table");
            sortedList.Add(1, chair);
            sortedList.Add(2, table);

            // Act
            var values = sortedList.Values;

            // Assert
            Assert.Equal(new List<Mueble> { chair, table }, values);
        }
       

        [Fact]
        public void Eliminar()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            var chair = new Mueble(1, "Chair");
            sortedList.Add(1, chair);

            // Act
            sortedList.Remove(1);

            // Assert
            Assert.Equal(0, sortedList.Count);
        }

        [Fact]
        public void Clear_ShouldRemoveAllItems()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));
            sortedList.Add(2, new Mueble(2, "Table"));

            // Act
            sortedList.Clear();

            // Assert
            Assert.Empty(sortedList);
        }

        //[Fact]
        //public void ContainsKey_ShouldReturnTrueIfKeyExists()
        //{
        //    // Arrange
        //    var sortedList = new SortedList<int, Mueble>();
        //    sortedList.Add(1, new Mueble(1, "Chair"));

        //    // Act
        //    var containsKey = sortedList.ContainsKey(1);

        //    // Assert
        //    Assert.True(containsKey);
        //}

        //[Fact]
        //public void ContainsKey_ShouldReturnFalseIfKeyDoesNotExist()
        //{
        //    // Arrange
        //    var sortedList = new SortedList<int, Mueble>();
        //    sortedList.Add(1, new Mueble(1, "Chair"));

        //    // Act
        //    var containsKey = sortedList.ContainsKey(2);

        //    // Assert
        //    Assert.False(containsKey);
        //}

        //[Fact]
        //public void ContainsValue_ShouldReturnTrueIfValueExists()
        //{
        //    // Arrange
        //    var sortedList = new SortedList<int, Mueble>();
        //    var chair = new Mueble(1, "Chair");
        //    sortedList.Add(1, chair);

        //    // Act
        //    var containsValue = sortedList.ContainsValue(chair);

        //    // Assert
        //    Assert.True(containsValue);
        //}

        //[Fact]
        //public void ContainsValue_ShouldReturnFalseIfValueDoesNotExist()
        //{
        //    // Arrange
        //    var sortedList = new SortedList<int, Mueble>();
        //    var chair = new Mueble(1, "Chair");
        //    sortedList.Add(1, chair);

        //    // Act
        //    var containsValue = sortedList.ContainsValue(new Mueble(2, "Table"));

        //    // Assert
        //    Assert.False(containsValue);
        //}

        [Fact]
        public void GetEnumerator_ShouldReturnEnumerator()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));
            sortedList.Add(2, new Mueble(2, "Table"));

            // Act
            var enumerator = sortedList.GetEnumerator();

            // Assert
            Assert.NotNull(enumerator);
        }
     
   

        [Fact]
        public void Contains_ShouldReturnTrueIfKeyValuePairExists()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));

            // Act
            var contains = sortedList.ContainsKey(1);

            // Assert
            Assert.True(contains);

        }


        [Fact]
        public void Contains_ShouldReturnFalseIfKeyValuePairDoesNotExist()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>();
            sortedList.Add(1, new Mueble(1, "Chair"));

            // Act
            var contains = sortedList.Contains(new KeyValuePair<int, Mueble>(2, new Mueble(2, "Table")));

            // Assert
            Assert.False(contains);
        }

        [Fact]
        public void TrimExcess_ShouldAdjustTheCapacity()
        {
            // Arrange
            var sortedList = new SortedList<int, Mueble>(capacity: 5); 
            sortedList.Add(1, new Mueble(1, "Chair"));
            sortedList.Add(2, new Mueble(2, "Table"));

            // Act
            sortedList.TrimExcess();

            // Assert
            Assert.Equal(2, sortedList.Capacity);
        }


    }
}





