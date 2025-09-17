using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Project_libs
{
    public class Libs
    {
        static void Main()
        {
            // Example: adding multiple flights
            AddFlightToFile(new Flight { ID = "F123", Company = "Iberia", Initial_position_x = 10.5f, Initial_position_y = 25.75f, Final_position_x = 16.5f, Final_position_y = 65.75f, speed = 10.5f });

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void AddFlightToFile(Flight newFlight)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\flight.json");
            filePath = Path.GetFullPath(filePath);

            List<Flight> flights = new List<Flight>();

            // Read existing flights if file exists
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        // Try reading as a list
                        flights = JsonSerializer.Deserialize<List<Flight>>(existingJson);
                    }
                    catch (JsonException)
                    {
                        try
                        {
                            // If fails, try reading as a single flight object
                            Flight singleFlight = JsonSerializer.Deserialize<Flight>(existingJson);
                            flights = new List<Flight> { singleFlight };
                        }
                        catch (JsonException)
                        {
                            // If even that fails, start with an empty list
                            flights = new List<Flight>();
                        }
                    }
                }
            }

            // Add the new flight
            flights.Add(newFlight);

            // Serialize back to file
            string jsonString = JsonSerializer.Serialize(flights, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine($"Added flight {newFlight.ID} to file: {filePath}");
        }

        public static void Conflict_Detector_Simulation(Flight FLight_1, Flight Flight_2, float SecurityDistance)
        { 
            int Framerate = 60;
        }

        public static Boolean Isthere_Conflict(Flight FLight_1, Flight Flight_2, float SecurityDistance)
        {

        }
    }



    public class Flight
    {
        public string ID { get; set; }
        public string Company { get; set; }
        public float Initial_position_x { get; set; }
        public float Initial_position_y { get; set; }
        public float Final_position_x { get; set; }
        public float Final_position_y { get; set; }
        public float Final_position { get; set; }
        public float speed { get; set; }

       
    }
}
