using System.Drawing;

namespace AffineTransformationsIn3D.Geometry
{
    //Класс представления вершин
    public class Vertex
    {
        public Vector Coordinate { get; set; }
        public Color Color { get; set; }
        public Vector Normal { get; set; }
        public Vector UVCoordinate { get; set; }

        //конструкторы на все случаи жизни
        public Vertex(Vector coordinate, Color color, Vector normal, Vector colorVector)
        {
            Coordinate = coordinate;
            Color = color;
            Normal = normal;
            UVCoordinate = colorVector;
        }

        public Vertex(Vector coordinate, Color color, Vector normal) : this(coordinate, color, normal, new Vector(0, 0, 0)) { }

        public Vertex(Vector coordinate) : this(coordinate, Color.White) { }//задаем цвет наших вершин

        public Vertex(Vector coordinate, Color color) : this(coordinate, color, new Vector(0, 0, 0)) { }
    }
}
