using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TDD_MCafe;

namespace TDD_MCafe_Test
{
    [TestClass]

    public sealed class TestVaso
    {
        [TestMethod]
        public void deberiaDevolverVerdaderiSiExistenVasos()
        {
          TDD_MCafe.Vaso vaso = new Vaso(2, 10);
          Boolean resultado = vaso.hasVasos(1);

            Assert.AreEqual(true, resultado);
            
        }
        [TestMethod]
        public void deberiaDevolverFalsoiSiNOExistenVasos()
        {
            TDD_MCafe.Vaso vaso = new Vaso(1, 10);
            Boolean resultado = vaso.hasVasos(2);

            Assert.AreEqual(false, resultado);

        }
        [TestMethod]
        public void deberiaRestarCantidadDeVasos()
        {
            TDD_MCafe.Vaso vaso = new Vaso(5, 10);
            vaso.giveVasos(1);

            Assert.AreEqual(4, vaso.getCantidadVasos());

        }
    } 
}


