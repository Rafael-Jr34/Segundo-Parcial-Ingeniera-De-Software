namespace TDD_MCafe_Test
{
    [TestClass]
    public sealed class TestCafetera
    {
        [TestMethod]
        public void deveriaDevolverVerdaderoSiExisteCafe()
        {
            TDD_MCafe.Cafetera cafetera = new TDD_MCafe.Cafetera(10);
            bool result = cafetera.hasCafe(5);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void deveriaDevolverFalsoSiNOExisteCafe()
        {
            TDD_MCafe.Cafetera cafetera = new TDD_MCafe.Cafetera(5);
            bool result = cafetera.hasCafe(6);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void deveriaRestarCafeAlaCafetera()
        {
            TDD_MCafe.Cafetera cafetera = new TDD_MCafe.Cafetera(5);
           cafetera.giveCafe(1);
            Assert.AreEqual(4, cafetera.getCantidadCafe());
        }



    }
}
