using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Sessionals.SessionalOne
{
    public class Window
    {
        Shape shape;
        public void Open() { }
        public void Close() { }
        public void Move() { }
        public void Display() { }
        public void HandleEvent() { }

    }

    public class Shape
    {
        public void Draw() { }
        public void Erase() { }
        public void Move() { }
        public void Resize() { }

    }

    public class Circle : Shape
    {
        Point _Point;
        float Radius;
        uint Center;
        public double Area(float radius)
        {
            return 0;
        }
        public void Circum() { }

        public void SetCenter() { }

        public void SetRadius() { }

    }

    public class Rectangle : Shape
    {

    }

    public class Polygon : Shape
    {

    }

    public class Point
    {

    }
}