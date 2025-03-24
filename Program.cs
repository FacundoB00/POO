using System;
using System.Runtime.CompilerServices;

namespace EjercicioAbstraccionEjemplo 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            televisor modelo1 = new televisor();
            modelo1.marca = "LG";
            modelo1.pantalla = "OLED";
            modelo1.pulgadas = 55;
            
               
            Console.WriteLine("Nueva television agregada " + "Marca " + modelo1.marca + ", Pantalla " + modelo1.pantalla + ", Pulgadas " + modelo1.pulgadas );

            modelo1.encenderTelevisor();

            Console.WriteLine("ingrese 0 si quiere apagar la television ",modelo1.marca);
            int numero = int.Parse(Console.ReadLine());
            if (numero != 0 ) {
            do
            {
                Console.WriteLine("ingrese 0 si quiere apagar la television");
                numero=int.Parse(Console.ReadLine());

            } while (numero != 0);

            }
            modelo1.apagarTelevisor();


            indumentaria Buzo = new indumentaria();
            Buzo.marca = "Nike";
            Buzo.talle = "M";
            Buzo.material = "algodon";
            Buzo.precio = 30000;

            Buzo.listarPrenda();

            Console.WriteLine("si quiere eliminar la prenda presione 0");
            int aux=int.Parse(Console.ReadLine());
            if(aux != 0 ) {
            do {
                Console.WriteLine("si quiere eliminar la prenda presione 0");
                aux = int.Parse(Console.ReadLine());





            } while (aux != 0);
            
            }
            Buzo.eliminarPrenda();
        }

        public class indumentaria
        {
            public string marca;
            public string talle;
            public string material;
            public int precio;

            public void listarPrenda()
            {
                Console.WriteLine("la prenda fue listada exitosamente " +" Marca " +  marca +", Talle " + talle + ", Material " + material +", Precio " + precio);
            }


            public void eliminarPrenda()
            {
                Console.WriteLine("la prenda fue eliminada exitosamente" );
            }
        }

        
        
        
        public class televisor{

            public string marca;
            public string pantalla;
            public int pulgadas;

            public void encenderTelevisor()
            {
                Console.WriteLine("la television se encendio");
            }
            public void apagarTelevisor()
            {
                Console.WriteLine("la television se apago");
            }

        }
        
    }


    }


