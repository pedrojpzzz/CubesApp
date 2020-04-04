using System;

namespace CubesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUBES App...");

            Cube cube1 = new Cube(0, 0, 0, 3);

            Console.WriteLine("Cube 1 X1: " + cube1.X1());
            Console.WriteLine("Cube 1 X2: " + cube1.X2());
            Console.WriteLine("Cube 1 Y1: " + cube1.Y1());
            Console.WriteLine("Cube 1 Y2: " + cube1.Y2());
            Console.WriteLine("Cube 1 Z1: " + cube1.Z1());
            Console.WriteLine("Cube 1 Z2: " + cube1.Z2());
            Console.WriteLine("Cube 1 volume is: " + cube1.Volume());

            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 3, 5);

            Console.WriteLine("Cuboid 1 X1: " + cuboid1.X1());
            Console.WriteLine("Cuboid 1 X2: " + cuboid1.X2());
            Console.WriteLine("Cuboid 1 Y1: " + cuboid1.Y1());
            Console.WriteLine("Cuboid 1 Y2: " + cuboid1.Y2());
            Console.WriteLine("Cuboid 1 Z1: " + cuboid1.Z1());
            Console.WriteLine("Cuboid 1 Z2: " + cuboid1.Z2());
            Console.WriteLine("Cuboid 1 volume is: " + cuboid1.Volume());

            Console.WriteLine("Intersection Volume is: " + cuboid1.GetIntersectionVolume(cube1));

            Console.ReadKey();
        }
    }
}
