using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[10]; //inicialmente puede almacenar 10 vuelos de clase FlightPlan
        int number = 0;

        public int AddFlightPlan(FlightPlan p) //ingresas un vuelo
        {
            if (number == 10) // si el vector está lleno
            { return -1; }
            else
            {
                vector[number] = p;
                number++;
                return 0;
            }
        }

        public FlightPlan GetFlightPlan(int i)
        {
            if (i < 0 || i >= number)
            { return null; }
            else
                return vector[i];
        }

        public void Mover(double tiempo) //mueve todos los vuelos el tiempo que se recibe como parámetro
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(tiempo);
                i++;
            }
        }

        public int DameNum()
        { return this.number; }

        public void EscribeConsola()
        {
            int i = 0;
            while (i < number)
            {
                vector[i].EscribeConsola();
                i++;
            }
        }

        public bool[,] Conflicto(double distanciaSeguridad)
        {
            bool[,] pareja = new bool[number, number]; //son paquetillos de parejitas de planes

            for (int i = 0; i < number - 1; i++)
                for (int j = i + 1; j < number; j++)
                    if (vector[i].Conflicto(vector[j], distanciaSeguridad))
                    {
                        pareja[i, j] = true;
                        pareja[j, i] = true; // porque es mas de lo mismo
                    }

            return pareja;
        }
    }
}
