using CubesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeAppTest
{
    [TestClass]
    public class CuboidTest
    {
        [TestMethod]
        public void TestCuboidConstructor_CuboidIsCorrectlyBuilt()
        {
            Cuboid cuboid = new Cuboid(1, 2, 3, 2, 3, 5);
            Assert.AreEqual(1, cuboid.xPosition);
            Assert.AreEqual(2, cuboid.yPosition);
            Assert.AreEqual(3, cuboid.zPosition);
            Assert.AreEqual(0, cuboid.X1());
            Assert.AreEqual(2, cuboid.X2());
            Assert.AreEqual(0.5, cuboid.Y1());
            Assert.AreEqual(3.5, cuboid.Y2());
            Assert.AreEqual(0.5, cuboid.Z1());
            Assert.AreEqual(5.5, cuboid.Z2());
        }

        [TestMethod]
        public void TestGetIntersectionSegment_SegmentAOverlapsSegmentB_ReturnCorrectIntersectionSegment()
        {
            double intersectionSegment = Cuboid.GetIntersectionSegment(1, 5, 2, 8);

            Assert.AreEqual(3, intersectionSegment);
        }

        [TestMethod]
        public void TestGetIntersectionSegment_SegmentAIncludesSegmentB_ReturnCorrectIntersectionSegment()
        {
            double intersectionSegment = Cuboid.GetIntersectionSegment(1, 10, 2, 8);

            Assert.AreEqual(6, intersectionSegment);
        }

        [TestMethod]
        public void TestGetIntersectionSegment_SegmentADoesNotOverlapSegmentB_ReturnCorrectIntersectionSegment()
        {
            double intersectionSegment = Cuboid.GetIntersectionSegment(1, 5, 6, 8);

            Assert.AreEqual(0, intersectionSegment);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubesAreEqual_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, 0, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(8, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnXAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(1, 0, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnXAxisNegative_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(-1, 0, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnYAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, 1, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnYAxisNegative_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, -1, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnZAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, 0, 1, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnZAxisNegative_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, 0, -1, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(4, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnXYAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(1, 1, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(2, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnXZAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(1, 0, 1, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(2, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnYZAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(0, 1, 1, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(2, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeDisplacedOnXYZAxis_CorrectIntersectionVolumeCalculated()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(1, 1, 1, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(1, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_CubeTouchingSurfaceOnly_IntersectionVolumeIsZero()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(2, 0, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(0, intersectionVolume);
        }

        [TestMethod]
        public void TestIntersectionVolumne_SeparatedCubes_IntersectionVolumeIsZero()
        {
            Cuboid cuboid1 = new Cuboid(0, 0, 0, 2, 2, 2);
            Cuboid cuboid2 = new Cuboid(20, 0, 0, 2, 2, 2);
            double intersectionVolume = cuboid1.GetIntersectionVolume(cuboid2);

            Assert.AreEqual(0, intersectionVolume);
        }
    }
}
