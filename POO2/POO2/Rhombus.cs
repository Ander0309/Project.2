using System;
using System.Collections.Generic;

namespace Geometry;

class Rhombus : Square
{
    private readonly double _d1, _d2;
    public double D1 { get => _d1; }
    public double D2 { get => _d2; }

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        ValidateD1(d1);
        ValidateD2(d2);
        _d1 = d1;
        _d2 = d2;
    }

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * A;

    private void ValidateD1(double d1)
    {
        if (d1 <= 0)
            throw new ArgumentException("La diagonal D1 debe ser un valor positivo.");
    }

    private void ValidateD2(double d2)
    {
        if (d2 <= 0)
            throw new ArgumentException("La diagonal D2 debe ser un valor positivo.");
    }
}
