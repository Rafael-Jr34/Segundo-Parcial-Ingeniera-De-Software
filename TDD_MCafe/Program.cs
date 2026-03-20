namespace TDD_MCafe
{
   internal  class Program
    {
        static void Main()
        {
            Cafetera cafetera = new Cafetera(20);
            Vaso vasoPequeno = new Vaso(10, 3);
            Vaso vasoMediano = new Vaso(10, 5);
            Vaso vasoGrande = new Vaso(10, 7);
            Azucarero azucarero = new Azucarero(50);
            MaquinaCafe maquinaCafe = new MaquinaCafe();

            maquinaCafe.cafetera = cafetera;
            maquinaCafe.vasosPequeños = vasoPequeno;
            maquinaCafe.vasosMedianos = vasoMediano;
            maquinaCafe.vasosGrandes = vasoGrande;
            maquinaCafe.azucarero = azucarero;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Estado actual:");
                Console.WriteLine($"Café disponible: {maquinaCafe.GetCafetera().getCantidadCafe()}");
                Console.WriteLine($"Azúcar disponible: {maquinaCafe.GetAzucarero().getCantidadDeAzucar()}");
                Console.WriteLine($"Vasos pequeños: {maquinaCafe.vasosPequeños.getCantidadVasos()} (contenido {maquinaCafe.vasosPequeños.getContenido()})");
                Console.WriteLine($"Vasos medianos: {maquinaCafe.vasosMedianos.getCantidadVasos()} (contenido {maquinaCafe.vasosMedianos.getContenido()})");
                Console.WriteLine($"Vasos grandes: {maquinaCafe.vasosGrandes.getCantidadVasos()} (contenido {maquinaCafe.vasosGrandes.getContenido()})");
                Console.WriteLine();
                Console.WriteLine("Seleccione tipo de vaso:");
                Console.WriteLine("1 - pequeño");
                Console.WriteLine("2 - mediano");
                Console.WriteLine("3 - grande");
                Console.WriteLine("0 - salir");
                string opcion = Console.ReadLine();
                if (opcion == "0") break;

                Vaso tipoVaso = null;
                string nombreVaso = "";
                if (opcion == "1") { tipoVaso = maquinaCafe.vasosPequeños; nombreVaso = "pequeño"; }
                else if (opcion == "2") { tipoVaso = maquinaCafe.vasosMedianos; nombreVaso = "mediano"; }
                else if (opcion == "3") { tipoVaso = maquinaCafe.vasosGrandes; nombreVaso = "grande"; }
                else { Console.WriteLine("Opción no válida."); continue; }

                Console.WriteLine($"Cuántos vasos {nombreVaso} desea?");
                if (!int.TryParse(Console.ReadLine(), out int cantidadVasos) || cantidadVasos <= 0) { Console.WriteLine("Cantidad inválida."); continue; }

                if (cantidadVasos > tipoVaso.getCantidadVasos())
                {
                    Console.WriteLine("No hay Vasos");
                    continue;
                }
                int contenidoPorVaso = tipoVaso.getContenido();
                int totalCafeNecesario = contenidoPorVaso * cantidadVasos;
                if (totalCafeNecesario > maquinaCafe.GetCafetera().getCantidadCafe())
                {
                    Console.WriteLine("No hay Cafe");
                    continue;
                }
                Console.WriteLine("Cuánta azúcar por vaso (un número entero)?");
                if (!int.TryParse(Console.ReadLine(), out int azucarPorVaso) || azucarPorVaso < 0) { Console.WriteLine("Cantidad de azúcar inválida."); continue; }

                int totalAzucarNecesaria = azucarPorVaso * cantidadVasos;
                if (totalAzucarNecesaria > maquinaCafe.GetAzucarero().getCantidadDeAzucar())
                {
                    Console.WriteLine("No hay Azucar");
                    continue;
                }

               

                tipoVaso.giveVasos(cantidadVasos);
                maquinaCafe.GetCafetera().giveCafe(totalCafeNecesario);
                maquinaCafe.GetAzucarero().giveAzucar(totalAzucarNecesaria);

                Console.WriteLine("Felicitaciones");
            }
        }
    }
}
