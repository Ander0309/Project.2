using System;
using System.Collections.Generic;

namespace Geometry;
class Parallelogram : Rectangle
{
    private double _h;
    public double H { get => _h; }

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        Name = name;
        ValidateH(h);
        _h = h;
    }

    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);

    private void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("La altura debe ser un valor positivo.");
    }
}
