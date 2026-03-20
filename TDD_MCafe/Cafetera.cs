using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MCafe
{
    public class Cafetera
    {
       private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public void setCantidadCafe(int uni) {
            cantidadCafe = uni;
        }
        public int getCantidadCafe()
        {
            return cantidadCafe;
        }
        public bool  hasCafe(int cantidadCafeComparar) {
            return cantidadCafeComparar < cantidadCafe ? true : false;
        }
        public void giveCafe(int cantidadCafeADar) {
            cantidadCafe -= cantidadCafeADar;
        
        
        }
    }
}
