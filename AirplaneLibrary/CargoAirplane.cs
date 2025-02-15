namespace AirplaneLibrary;


public class CargoAirplane : Airplane
{
    public double CargoCapacity { get; }

    public CargoAirplane(string model, double wingSpan, string company, double maxAltitude, double maxSpeed, double cargoCapacity)
        : base(model, wingSpan, company, maxAltitude, maxSpeed)
    {
        CargoCapacity = cargoCapacity;
    }
}
