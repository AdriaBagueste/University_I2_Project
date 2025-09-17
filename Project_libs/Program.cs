using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Project_libs;

namespace Project_libs
{

    public class Main
    {
        static void Mian()
        {
            Project_libs.Libs.AddFlightToFile(new Flight { ID = "F123", Initial_position_x = 10.5f, Initial_position_y = 25.75f, Final_position_x = 16.5f, Final_position_y = 65.75f });

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}