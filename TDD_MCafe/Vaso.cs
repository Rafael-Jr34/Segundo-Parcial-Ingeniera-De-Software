using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_MCafe
{
  public  class Vaso
    {
        private int cantidadVasos;
        private int contenido;
        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int uni) {
            cantidadVasos = uni;
        }
        public int  getCantidadVasos(){
            return cantidadVasos;
         }
        public void setContenido(int uni) {
            contenido = uni;
        }
        public int getContenido() {
            return contenido;
        }
        public bool hasVasos(int cantidadVasosComparar) {
            return cantidadVasosComparar < cantidadVasos ?  true : false;
        
        }
        public void giveVasos(int cantidadVasosAdar) {

            cantidadVasos -= cantidadVasosAdar;
        
        }



    }
}
