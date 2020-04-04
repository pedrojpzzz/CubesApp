using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
