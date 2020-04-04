namespace CubesApp
{
    public interface ICube : IFigure3D
    {
        double X1();
        double X2();
        double Y1();
        double Y2();
        double Z1();
        double Z2();
        double GetIntersectionVolume(ICube cuboid);
    }
}
