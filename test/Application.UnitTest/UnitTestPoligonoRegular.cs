// .\test\Application.UnitTest\UnitTestPoligonoRegular.cs
using System;
using Xunit;
using Application;
namespace Application.UnitTest;

public class UnitTestPoligonoRegular
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(30, 3, 90)]
    [InlineData(35, 7, 245)]
    [InlineData(40, 2, 80)]
    public void TestVolumen(double area, double h, double volumen)
    {
        // Arrange – Set up
      
        // Act – Perform
        double resultado = PoligonoRegular.Volumen(area, h);
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}