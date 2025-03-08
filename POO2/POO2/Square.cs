using System;
using System.Collections.Generic;

namespace Geometry;

class Square : GeometricFigure
{
    private readonly double _a;
    public double A { get => _a; }

    public Square(string name, double a)
    {
        Name = name;
        ValidateA(a);
        _a = a;
    }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;

    private void ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentException("El lado debe ser un valor positivo.");
    }
}
