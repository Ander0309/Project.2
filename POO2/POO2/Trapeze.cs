using System;
using System.Collections.Generic;

namespace Geometry;

class Trapeze : Triangle
{
    private readonly double _d;
    public double D { get => _d; }

    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        ValidateD(d);
        _d = d;
    }

    public override double GetArea() => ((B + D) * H) / 2;
    public override double GetPerimeter() => A + B + C + D;

    private void ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException("El lado D debe ser un valor positivo.");
    }
}
