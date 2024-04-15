// .\src\Application\Hexagono.cs

using System;

namespace Application;

public class Hexagono
{        
    public static double Perimetro(double lado, double n)
    {
        return lado*n;
    }
    public static double Area(double lado,double n,double a)
    {
        return (n*a*lado)/2;
    }
}