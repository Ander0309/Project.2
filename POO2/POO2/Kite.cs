using System;
using System.Collections.Generic;

namespace Geometry;
class Kite : Rhombus
{
    private readonly double _b;
    public double B { get => _b; }

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        ValidateB(b);
        _b = b;
    }

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (A + B);

    private void ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException("El lado B debe ser un valor positivo.");
    }
}