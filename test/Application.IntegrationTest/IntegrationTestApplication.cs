using System;
using Xunit;
using Application;
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 2, 1, 6, 24)]
    [InlineData(5, 3, 2, 6, 90)]
    [InlineData(6, 4, 3, 6, 216)]
    [InlineData(7, 5, 4, 6, 420)]
    [InlineData(8, 6, 4, 6, 576)]
    public void TestVolumen(double lado, double h, double a, double n, double volumen)
    {
        // Arrange – Set up            
        double area = Hexagono.Area(lado, n, a); 
        // Act – Perform
        double resultado = PoligonoRegular.Volumen(area, h);
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}