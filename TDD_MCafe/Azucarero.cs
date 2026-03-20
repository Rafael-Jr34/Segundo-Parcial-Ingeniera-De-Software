using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MCafe
{
   public class Azucarero
    {
     private  int cantidadDeAzucar;
        public Azucarero (int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }
        public void setCantidadDeAzucar(int uni) {
            cantidadDeAzucar = uni;
        
        }
        public int getCantidadDeAzucar()
        {
            return cantidadDeAzucar;
        }
        public bool hasAzucar(int cantidadDeAzucarComparar) {
            return cantidadDeAzucarComparar < cantidadDeAzucar ? true : false;
         
        }
        public void giveAzucar(int cantidadDeAzucarDar) {
            cantidadDeAzucar -= cantidadDeAzucarDar;
        
        }




    }
}
