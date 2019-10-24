using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace AffineTransformationsIn3D.Geometry
{
    public class Mesh : IDrawable
    {
        public Vector[] Coordinates { get; set; }
		public int[][] Indices { get; set; }
        public virtual Vector Center
        {
            get
            {
                Vector center = new Vector();
                foreach (var v in Coordinates)
                {
                    center.X += v.X;
                    center.Y += v.Y;
                    center.Z += v.Z;
                }
                center.X /= Coordinates.Length;
                center.Y /= Coordinates.Length;
                center.Z /= Coordinates.Length;
                return center;
            }
        }

        public Mesh(Vector[] vertices, int[][] indices)
        {
            Coordinates = vertices;
            Indices = indices;
        }

        

        public virtual void Apply(Matrix transformation)
        {
            for (int i = 0; i < Coordinates.Length; ++i)
                Coordinates[i] *= transformation;
        }



        public virtual void Draw(Graphics3D graphics)
        {
                foreach (var facet in Indices)
                    for (int i = 0; i < facet.Length; ++i)
                    {
                        var a = new Vertex(Coordinates[facet[i]]);
                        var b = new Vertex(Coordinates[facet[(i + 1) % facet.Length]]);
                        graphics.DrawLine(a, b);
                    }
        }

    }
}
