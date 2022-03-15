using PascalsTriangle.App;
using System;
using Xunit;

namespace PascalsTriangle.Test
{
    public class DisplayPascalsTriangleTest
    {
        [Fact]
        public void PascalTest1()
        {
            //Arrange
            IDisplayPascalsTriangle pascalTriangle = new DisplayPascalsTriangle();
            var expected = new long[][] { new long[] { 1 } };

            //Act
            var actual = pascalTriangle.Pascal(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PascalTest2()
        {
            //Arrange
            IDisplayPascalsTriangle pascalTriangle = new DisplayPascalsTriangle();
            var expected = new long[][]{ new long[] {1}, 
                new long[] {1,1}, 
                new long[] {1,2,1}, 
                new long[] {1,3,3,1}, 
                new long[] {1,4,6,4,1} };

            //Act
            var actual = pascalTriangle.Pascal(5);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
