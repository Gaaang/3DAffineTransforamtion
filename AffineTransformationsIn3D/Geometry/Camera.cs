namespace AffineTransformationsIn3D.Geometry
{
    public class Camera
    {

        //Вектор, определяющий позицию камеры
        public Vector Position { get; set; }

        //Угол наклона камеры по оси Y
        public double AngleY { get; set; }

        //Угол наклона камеры по оси X
        public double AngleX { get; set; }

        //Матрица, задющая проекцию камеры
        public Matrix Projection { get; set; }

        public Matrix ViewProjection
        {
            get
            {
                return Transformations.Translate(-Position)
                    * Transformations.RotateY(-AngleY)
                    * Transformations.RotateX(-AngleX)
                    * Projection;
            }
        }
        

        //Конструктор
        public Camera(Vector position, double angleY, double angleX, Matrix projection)
        {
            Position = position;
            AngleY = angleY;
            AngleX = angleX;
            Projection = projection;
        }
    }
}
