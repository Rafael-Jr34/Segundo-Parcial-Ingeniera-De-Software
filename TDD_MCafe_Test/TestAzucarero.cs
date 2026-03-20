namespace TDD_MCafe_Test
{
    [TestClass]
    public sealed class TestAzucarero
    {
        [TestMethod]
        public void deveriaDevolverVerdaderoSiHayAzucar()
        {
            TDD_MCafe.Azucarero Azucarero = new TDD_MCafe.Azucarero(10);
            bool result = Azucarero.hasAzucar(5);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void deveriaDevolverFalsoSiNOHayAzucar()
        {
            TDD_MCafe.Azucarero Azucarero = new TDD_MCafe.Azucarero(5);
            bool result = Azucarero.hasAzucar(6);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void deveriaRestarAzucarAlAzucarero()
        {
            TDD_MCafe.Azucarero Azucarero = new TDD_MCafe.Azucarero(5);
           Azucarero.giveAzucar(1);
            Assert.AreEqual(4, Azucarero.getCantidadDeAzucar());
        }



    }
}
