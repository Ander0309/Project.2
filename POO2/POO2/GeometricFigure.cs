using System;
using System.Collections.Generic;

namespace Geometry;

abstract class GeometricFigure
{
    public string Name { get; set; } = "Unnamed Figure";
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        string areaFormatted = GetArea() >= 1000 ? GetArea().ToString("#,0.00000") : GetArea().ToString("F5");
        string perimeterFormatted = GetPerimeter().ToString("F5");

        return string.Format("{0,-15} => Area.....: {1,12}  Perimeter: {2,12}", Name, areaFormatted, perimeterFormatted);
    }
}
