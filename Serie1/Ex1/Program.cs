using System;

namespace Ex1
{
    public struct Point3D
    {
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString() => $"({X}, {Y}, {Z}) ";
    }
    class Program
    {

        static void Main(string[] args)
        {
            Point3D point3D1 = new Point3D(20,30,40);
            Point3D point3D2 = new Point3D(50, 60, 70);
            Console.WriteLine(point3D1.ToString() + "Distance : " + point3D1.DistanceToOrigin());
            Console.WriteLine(point3D2.ToString() + "Distance : " + point3D2.DistanceToOrigin());
            SwapPoints(ref point3D1, ref point3D2);
            Console.WriteLine(point3D1.ToString() + "Distance : " + point3D1.DistanceToOrigin());
            Console.WriteLine(point3D2.ToString() + "Distance : " + point3D2.DistanceToOrigin());
        }

        public static void SwapPoints(ref Point3D p1, ref Point3D p2)
        {
            double xTemp = p1.X;
            double yTemp = p1.Y;
            double zTemp = p1.Z;
            p1.X = p2.X;
            p1.Y = p2.Y;
            p1.Z = p2.Z;
            p2.X = xTemp;
            p2.Y = yTemp;
            p2.Z = zTemp;
        }
    }
}
