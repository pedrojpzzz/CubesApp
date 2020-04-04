using System;

namespace CubesApp
{
    class Cuboid : ICube
    {
        public double xPosition { get; set; }
        public double yPosition { get; set; }
        public double zPosition { get; set; }
        public double lengthX { get; set; }
        public double lengthY { get; set; }
        public double lengthZ { get; set; }

        public Cuboid(double x, double y, double z, double lenX, double lenY, double lenZ)
        {
            xPosition = x;
            yPosition = y;
            zPosition = z;
            lengthX = lenX;
            lengthY = lenY;
            lengthZ = lenZ;
        }

        public virtual double X1()
        {
            return xPosition - lengthX / 2;
        }

        public virtual double X2()
        {
            return xPosition + lengthX / 2;
        }

        public virtual double Y1()
        {
            return yPosition - lengthY / 2;
        }

        public virtual double Y2()
        {
            return yPosition + lengthY / 2;
        }

        public virtual double Z1()
        {
            return zPosition - lengthZ / 2;
        }

        public virtual double Z2()
        {
            return zPosition + lengthZ / 2;
        }

        public virtual double Volume()
        {
            return lengthX * lengthY * lengthZ;
        }

        public double GetIntersectionVolume(ICube cuboid)
        {
            double xSegment = GetIntersectionSegment(X1(), X2(), cuboid.X1(), cuboid.X2());
            double ySegment = GetIntersectionSegment(Y1(), Y2(), cuboid.Y1(), cuboid.Y2());
            double zSegment = GetIntersectionSegment(Z1(), Z2(), cuboid.Z1(), cuboid.Z2());

            return new Cuboid(0, 0, 0, xSegment, ySegment, zSegment).Volume();
        }

        private double GetIntersectionSegment(double a1, double a2, double b1, double b2)
        {
            double intersectionSegment;
            double maxBound;

            if(a1 <= b1)
            {
                maxBound = Math.Min(a2, b2);
                intersectionSegment = Math.Max(maxBound - b1, 0);
            }
            else
            {
                intersectionSegment = GetIntersectionSegment(b1, b2, a1, a2);
            }

            return intersectionSegment;
        }
    }
}
