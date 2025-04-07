using System;
using System.Reflection.Metadata;


namespace ejerciciosPOO2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public class autobus : vehiculo
        {
            public int capacidadPasajeros;
            public int numerodePuertas;
            public int numerodeAsientos;

        }

        public class coupe : vehiculo
        {
            public int numerodePuertas;
            public int numeroAsientos;
            public string color;


        }

        public class SUV : vehiculo
        {
            public int numerodePuertas;
            public int numeroAsientos;
            public string color;
        }
        public class vehiculo
        {
            public string marca;
            public string modelo;
            public int año;
            public int numeroDeSerie;


            public void arrancar()
            {
                Console.WriteLine("arrancando...");
            }
            public void detener()
            {
                Console.WriteLine("deteniendo...");
            }
            public void acelerar()
            {
                Console.WriteLine("acelerando...");
            }
            public void frenar()
            {
                Console.WriteLine("arrancando...");
            }
        }

        public class animal
        {
            public string especie;
            public int edad;
            public string genero;


            public void alimentarse()
            {
                Console.WriteLine("alimentandose....");
            }
            public void sonidos()
            {
                Console.WriteLine("reproduciendo sonidos....");
            }
        }
        public class gato : animal
        {
            public string color;
            public string raza;

            public void ronroneo()
            {
                Console.WriteLine("ronroneando.....");
            }

            public void rascarse()
            {
                Console.WriteLine("rascandose...");
            }

        }

        public class perro : animal
        {
            public string color;
            public string raza;

            public void ladrando()
            {
                Console.WriteLine("ladrando.....");
            }

            public void lamiendo()
            {
                Console.WriteLine("lamiendo....");
            }
        }

        public class Libro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public bool Prestado { get; set; }

            public Libro(string titulo, string autor)
            {
                Titulo = titulo;
                Autor = autor;
                Prestado = false;
            }
        }

        public class Biblioteca
        {
            public string Nombre { get; set; }
            public string Ubicacion { get; set; }
            public int HorarioApertura { get; set; }
            public int HorarioCierre { get; set; }

            private Libro[] libros = new Libro[15];
            private int contador = 0;

            public void AgregarLibro(string titulo, string autor)
            {
                if (contador < libros.Length)
                {
                    libros[contador] = new Libro(titulo, autor);
                    contador++;
                }
                else
                {
                    Console.WriteLine("Se llegó al límite de libros.");
                }
            }

            public void BuscarLibro(string tituloBuscado)
            {
                bool bandera= false;

                for (int i = 0; i < contador; i++)
                {
                    if (libros[i].Titulo.ToLower().Contains(tituloBuscado.ToLower()))
                    {
                        Console.WriteLine($"El libro '{libros[i].Titulo}' fue encontrado en la posición {i}.");
                        bandera = true;
                    }
                }

                if (!bandera)
                {
                    Console.WriteLine("El libro no fue encontrado.");
                }
            }
        }

        public class cajeroautomatico
        {
            public string ubicacion;
            public int numeroDeSerie;
            public float saldo=0;


            public void agregarDinero(float saldo)
            {
                Console.WriteLine("indicar monto a ingresar");
                saldo = float.Parse(Console.ReadLine());
                Console.WriteLine("su saldo es de " + saldo);
            }

            public void consultarSaldo(float saldo)
            {
                Console.WriteLine("su saldo es  " + saldo);
            }

            public void retirarDinero(float saldo)
            {
                float monto;
                Console.WriteLine("ingrese un monto");
                monto= float.Parse(Console.ReadLine());
               
                    
                do
                {
                    Console.WriteLine("el monto ingresado es mayor al saldo, ingrese otro valor");
                    monto = float.Parse(Console.ReadLine());
                }while(monto >saldo);


                saldo = saldo - monto;

             } 

        }

        public class Rol
        {
            public string Nombre { get; set; }
            public decimal SalarioBase { get; set; }

            public Rol(string nombre, decimal salarioBase)
            {
                Nombre = nombre;
                SalarioBase = salarioBase;
            }
        }

        public class Departamento
        {
            public string Nombre { get; set; }

            public Departamento(string nombre)
            {
                Nombre = nombre;
            }
        }

        public class Empleado
        {
            public string Nombre { get; set; }
            public Rol Rol { get; private set; }
            public Departamento Departamento { get; private set; }

            public Empleado(string nombre)
            {
                Nombre = nombre;
            }

            public void AsignarRol(Rol rol)
            {
                Rol = rol;
            }

            public void AsignarDepartamento(Departamento depto)
            {
                Departamento = depto;
            }

            public decimal CalcularSalario()
            {
                return Rol != null ? Rol.SalarioBase : 0;
            }
        }

        public class SistemaGestionEmpleados
        {
            public Empleado[] empleados = new Empleado[100];
            public int contadorEmpleados = 0;

            public void AgregarEmpleado(string nombre)
            {
                if (contadorEmpleados < empleados.Length)
                {
                    empleados[contadorEmpleados] = new Empleado(nombre);
                    contadorEmpleados++;
                }
                else
                {
                    Console.WriteLine("No se pueden agregar más empleados.");
                }
            }

            public void AsignarRolAEmpleado(string nombreEmpleado, Rol rol)
            {
                for (int i = 0; i < contadorEmpleados; i++)
                {
                    if (empleados[i].Nombre == nombreEmpleado)
                    {
                        empleados[i].AsignarRol(rol);
                        return;
                    }
                }
            }

            public void AsignarDepartamentoAEmpleado(string nombreEmpleado, Departamento depto)
            {
                for (int i = 0; i < contadorEmpleados; i++)
                {
                    if (empleados[i].Nombre == nombreEmpleado)
                    {
                        empleados[i].AsignarDepartamento(depto);
                        return;
                    }
                }
            }

            public decimal CalcularSalarioEmpleado(string nombreEmpleado)
            {
                for (int i = 0; i < contadorEmpleados; i++)
                {
                    if (empleados[i].Nombre == nombreEmpleado)
                    {
                        return empleados[i].CalcularSalario();
                    }
                }
                return 0;
            }
        }



    }
}