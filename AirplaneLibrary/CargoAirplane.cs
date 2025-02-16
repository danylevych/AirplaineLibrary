namespace AirplaneLibrary;


public class CargoAirplane : Airplane
{
    private double cargoCapacity;
    public double CargoCapacity {
        get => cargoCapacity;

        set {
            if (value < 0) {
                throw new ArgumentException("Cargo capacity cannot be negative");
            }
            cargoCapacity = value;
        }
    }

    public CargoAirplane(string model, double wingSpan, string company, double maxAltitude, double maxSpeed, double cargoCapacity)
        : base(model, wingSpan, company, maxAltitude, maxSpeed)
    {
        CargoCapacity = cargoCapacity;
    }
}
