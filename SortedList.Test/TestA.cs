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
        public class SortedListTests
        {
            [Fact]
            public void SortedList_Capacity_WorkCorrectly()
            {
                // Arrange
                var sortedList = new SortedList<int, Mueble>(capacity: 5);

                // Act & Assert
                Assert.Equal(0, sortedList.Count);
                Assert.Equal(5, sortedList.Capacity);
            }
        }
    }
}

