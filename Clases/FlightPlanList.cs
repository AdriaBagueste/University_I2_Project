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
            if (number == 10) return -1;// si el vector está lleno
            else
            {
                vector[number] = p;
                number++;
                return 0;
            }
        }

        public FlightPlan GetFlightPlan(int index)
        {
            if (index < 0 || index >= number) return null;
            else return vector[index];
        }
      
        public void Move(double Time) //mueve todos los vuelos el tiempo que se recibe como parámetro
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(Time);
                i++;
            }
        }

        public int GetNum()
        { return this.number; }

        public void WriteConsole()
        {
            int i = 0;
            while (i < number)
            {
                vector[i].EscribeConsola();
                i++;
            }
        }

        public void Restart_Flights()
        {
            for(int i = 0; i < number; i++)
            { vector[i].Restart(); }
        }

        public bool[,] Conflict(double distanciaSeguridad)
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
