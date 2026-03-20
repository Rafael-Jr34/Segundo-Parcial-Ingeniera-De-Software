using TDD_MCafe;

namespace TDD_MCafe_Test
{
    [TestClass]
    public sealed class TestMaquinaDeCAfe
    {
    
        TDD_MCafe.Cafetera cafetera = new TDD_MCafe.Cafetera(50);
        TDD_MCafe.Vaso vasoPequeno = new TDD_MCafe.Vaso(5, 10);
        TDD_MCafe.Vaso vasoMediano = new TDD_MCafe.Vaso(5, 10);
        TDD_MCafe.Vaso vasoGrande = new TDD_MCafe.Vaso(5, 10);
        TDD_MCafe.Azucarero azucarero = new TDD_MCafe.Azucarero(20);
        TDD_MCafe.MaquinaCafe maquinaCafe = new MaquinaCafe();
        [TestInitialize]
        public void ponervariables()
        {
            maquinaCafe.cafetera = cafetera;
            maquinaCafe.vasosPequeños = vasoPequeno;
            maquinaCafe.vasosMedianos = vasoMediano;
            maquinaCafe.vasosGrandes = vasoGrande;
            maquinaCafe.azucarero = azucarero;
        }


        [TestMethod]
        public void deveriaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            Assert.AreEqual(maquinaCafe.vasosPequeños, vaso);
        }
        [TestMethod]
        public void deveriaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinaCafe.vasosMedianos, vaso);
        }
        [TestMethod]
        public void deveriaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinaCafe.vasosGrandes, vaso);
        }
        [TestMethod]
        public void deveriaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            string result = maquinaCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", result);

        }
        [TestMethod]
        public void deveriaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaCafe.setCafetera(cafetera);
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            string result = maquinaCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", result);

        }

        [TestMethod]
        public void deveriaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaCafe.setAzucarero(azucarero);
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            string result = maquinaCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", result);

        }
        [TestMethod]
        public void deveriaRestarCafe()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            maquinaCafe.getVasoDeCafe(vaso, 1, 3);
            int result = maquinaCafe.GetCafetera().getCantidadCafe();
            Assert.AreEqual(40, result);
        } 
        [TestMethod]
        public void deveriaRestarVaso()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            maquinaCafe.getVasoDeCafe(vaso, 1, 3);
            int result = maquinaCafe.getVasoPequeño().getCantidadVasos();
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void deveriaRestarAzucar()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeño");
            maquinaCafe.getVasoDeCafe(vaso, 1, 3);
            int result = maquinaCafe.GetAzucarero().getCantidadDeAzucar();
            Assert.AreEqual( 17,result);
        }



    }
}
