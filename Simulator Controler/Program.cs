using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightLib;

namespace SimulatorConsole
{
    public class Program
    {

        static void Main(string[] args)
        {
            FlightPlanList lista = new FlightPlanList();

            // Tratar excepciones de formato incorrecto. Este error de ejecución ocurre cuando el usuario entra datos no correctos.
            try
            {
                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                string identificador = Console.ReadLine(); ;

                Console.WriteLine("Escribe la velocidad");
                double velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                string linea = Console.ReadLine();
                string[] trozos = linea.Split(' ');
                double ix = Convert.ToDouble(trozos[0]);
                double iy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                double fx = Convert.ToDouble(trozos[0]);
                double fy = Convert.ToDouble(trozos[1]);

                FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);


                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                identificador = Console.ReadLine(); ;

                Console.WriteLine("Escribe la velocidad");
                velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                ix = Convert.ToDouble(trozos[0]);
                iy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                fx = Convert.ToDouble(trozos[0]);
                fy = Convert.ToDouble(trozos[1]);

                FlightPlan plan_b = new FlightPlan(identificador, ix, iy, fx, fy, velocidad);

                lista.AddFlightPlan(plan_a);
                lista.AddFlightPlan(plan_b);

                // Hacer un bucle de simulación.
                int i = 0;
                int ciclos = 20;
                int tiempoCiclo = 10;
                double distanciaSeguridad = 10;

                while (i < ciclos)
                {
                    lista.Mover(tiempoCiclo);
                    lista.EscribeConsola();
                    //ahora quiero ver la distancia entre los vuelos
                    Console.WriteLine("Distancia entre vuelos: {0}", plan_a.Distancia(plan_b));
                    if (plan_a.Conflicto(plan_b, distanciaSeguridad))
                        Console.WriteLine("Conflicto!!!);");
                    i++;
                }

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");
                Console.ReadLine();
            }
        }
    }
}
