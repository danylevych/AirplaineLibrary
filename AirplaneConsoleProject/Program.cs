using System;
using AirplaneLibrary;

class Program
{
    static void Main()
    {
        Airplane boeing = new Airplane("Boeing 747", 68.5, "Boeing", 13000, 988);
        CargoAirplane cargoPlane = new CargoAirplane("C-130 Hercules", 40.4, "Lockheed", 10000, 540, 20000);
        PassengerAirplane passengerPlane = new PassengerAirplane("Airbus A380", 79.8, "Airbus", 13100, 1020, 850);

        Console.WriteLine($"Model: {boeing.Model}, Current Speed: {boeing.GetCurrentSpeed()} km/h");
        boeing.ChangeSpeed(500);
        Console.WriteLine($"New Speed: {boeing.GetCurrentSpeed()} km/h");

        Console.WriteLine($"Cargo Plane Capacity: {cargoPlane.CargoCapacity} kg");
        Console.WriteLine($"Passenger Plane Capacity: {passengerPlane.PassengerCapacity} people");
    }
}
