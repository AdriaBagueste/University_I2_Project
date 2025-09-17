using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Project_libs
{
    class Libs
    {
        static void Main()
        {
            // Example: adding multiple flights
            AddFlightToFile(new Flight { ID = "F123", Initial_position = 10.5f, Final_position = 25.75f });
            AddFlightToFile(new Flight { ID = "F124", Initial_position = 15.0f, Final_position = 30.5f });

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void AddFlightToFile(Flight newFlight)
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
    }

    public class Flight
    {
        public string ID { get; set; }
        public float Initial_position { get; set; }
        public float Final_position { get; set; }
    }
}