using System;
using System.Collections.Generic;

namespace Geometry;

class Circle : GeometricFigure
{
    private readonly double _r;
    public double R { get => _r; }

    public Circle(string name, double r)
    {
        Name = name;
        ValidateR(r);
        _r = r;
    }

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R;

    private void ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentException("El radio debe ser un valor positivo.");
    }
}