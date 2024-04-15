// .\test\Application.UnitTest\UnitTestHexagono.cs
using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestHexagono
    {
        [Theory]
        [InlineData(6,6, 36)]
        [InlineData(8,6, 48)]
        [InlineData(9,6, 54)]
        [InlineData(10,6, 60)]
        [InlineData(11,6, 66)]
        public void TestPerimetro(double lado,double n, double perimetro)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Hexagono.Perimetro(lado,n); 
           
            // Assert – Verify
            Assert.Equal(resultado, perimetro);
        }

        [Theory]
        [InlineData(4,6,1, 12)]
        [InlineData(5,6,2, 30)]
        [InlineData(9,6,3, 81)]
        [InlineData(10,6,4, 120)]
        [InlineData(11,6,5, 165)]
        public void TestArea(double lado,double n,double a, double area)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Hexagono.Area(lado, n, a); 
           
            // Assert – Verify
            Assert.Equal(resultado, area);
        }
    }
}