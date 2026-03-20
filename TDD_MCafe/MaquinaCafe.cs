using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MCafe
{
  public  class MaquinaCafe
    {
        public Cafetera cafetera { get; set; }
        public Vaso vasosPequeños { get; set; }
        public Vaso vasosMedianos { get; set; }
        public Vaso vasosGrandes { get; set; }
        public Azucarero azucarero  { get; set; }
        public Cafetera GetCafetera()
        {
            return cafetera;
        }
        public Azucarero GetAzucarero()
        {
            return azucarero;
        }
        public Vaso getTipoVaso(string tipoDeVaso) {
              
            if (tipoDeVaso == "pequeño")
            {
                vasosPequeños.giveVasos(1);
                return vasosPequeños; 
                
            }
            else if (tipoDeVaso == "mediano")
            {
                vasosMedianos.giveVasos(1);
                return vasosMedianos;

            } else
            
            {
                vasosGrandes.giveVasos(1);
                return vasosGrandes;

            }
        }
        public string getVasoDeCafe(Vaso tipoDeVaso, int CantidaDeVaso, int CantidadDeAzucar) {
            /*Vaso pequeño -> 3 Oz de café.
            Vaso Mediano -> 5 Oz de café.
            Vaso Grande -> 7 Oz de café.*/

            if (CantidaDeVaso > tipoDeVaso.getCantidadVasos()) return "No hay Vasos";
            if (!azucarero.hasAzucar(CantidadDeAzucar * CantidaDeVaso)) return "No hay Azucar";
            if (vasosPequeños == tipoDeVaso)
            {
                if (!cafetera.hasCafe(3*CantidaDeVaso)) return "No hay Cafe";
               

            }
            else if (vasosMedianos == tipoDeVaso)
            {
                if (!cafetera.hasCafe(5*CantidaDeVaso)) return "No hay Cafe";
               
            } 
            else
            {
                if (!cafetera.hasCafe(7*CantidaDeVaso)) return "No hay Cafe";
                
            }
            cafetera.giveCafe(tipoDeVaso.getContenido());
            azucarero.giveAzucar(CantidadDeAzucar * CantidaDeVaso);
            return "Felicitaciones";


        }
        public Vaso getVasoPequeño() {
            return vasosPequeños;
        
        
        }

        public void setCafetera (Cafetera obj)
        {
            cafetera.setCantidadCafe(obj.getCantidadCafe());
            
        }
        public void setVasosPqueños(Vaso obj)
        {
            vasosPequeños.setCantidadVasos(obj.getCantidadVasos());
            vasosPequeños.setContenido(obj.getContenido());
        }
        public void setVasosMedianos(Vaso obj)
        {
            vasosMedianos.setCantidadVasos(obj.getCantidadVasos());
            vasosMedianos.setContenido(obj.getContenido());
        }
        public void setVasosGrandes(Vaso obj)
        {
            vasosGrandes.setCantidadVasos(obj.getCantidadVasos());
            vasosGrandes.setContenido(obj.getContenido());
        }
        public void setAzucarero(Azucarero obj)
        {
            azucarero.setCantidadDeAzucar(obj.getCantidadDeAzucar());
        }


    }
}
