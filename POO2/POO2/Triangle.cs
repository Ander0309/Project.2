using System;
using System.Collections.Generic;

namespace Geometry;

class Triangle : Rectangle
{
    private readonly double _c, _h;
    public double C { get => _c; }
    public double H { get => _h; }

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        ValidateC(c);
        ValidateH(h);
        _c = c;
        _h = h;
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;

    private void ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException("El lado C debe ser un valor positivo.");
    }

    private void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("La altura debe ser un valor positivo.");
    }
}
