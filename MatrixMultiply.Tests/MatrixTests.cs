using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixMultiply.Tests
{
    [TestClass]
    public class MatrixTests
    {
        // ОБРАЗЕЦ с https://ru.onlinemschool.com/math/assistance/matrix/multiply/
        //  1  2  3     9  8  7     30  24  18
        //  4  5  6  *  6  5  4  =  84  69  54
        //  7  8  9     3  2  1     138 114 90
        [TestMethod]
        public void TestMultiply_3x3__1_9__to__9_1_Sequental()
        {

            var m1 = Matrix.FromArray(3, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            var m2 = Matrix.FromArray(3, 3, 9, 8, 7, 6, 5, 4, 3, 2, 1);

            var expectedM = Matrix.FromArray(3, 3, 30, 24, 18, 84, 69, 54, 138, 114, 90);

            var actualM = Matrix.MultiplySequental(m1, m2);

            Assert.IsTrue(expectedM == actualM);
        }

        [TestMethod]
        public void TestMultiply_3x3__1_9__to__9_1_Parallel()
        {
            var m1 = Matrix.FromArray(3, 3, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            var m2 = Matrix.FromArray(3, 3, 9, 8, 7, 6, 5, 4, 3, 2, 1);

            var expectedM = Matrix.FromArray(3, 3, 30, 24, 18, 84, 69, 54, 138, 114, 90);

            var actualM = Matrix.MultiplyParallel(m1, m2);

            Assert.IsTrue(expectedM == actualM);
        }



    }
}
