namespace CubesApp
{
    class Cube : Cuboid, ICube
    {
        private double length { get; set; }

        public Cube(double x, double y, double z, double l) : base(x, y, z, l, l, l)
        {
        }
    }
}
