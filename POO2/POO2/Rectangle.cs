using System;
using System.Collections.Generic;

namespace Geometry;

class Rectangle : Square
{
    private readonly double _b;
    public double B { get => _b; }

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        ValidateB(b);
        _b = b;
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);

    private void ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("El ancho debe ser un valor positivo.");
    }
}
