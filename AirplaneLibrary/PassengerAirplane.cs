namespace AirplaneLibrary;


public class PassengerAirplane : Airplane
{
    private int passengerCapacity;
    public int PassengerCapacity {
        get => passengerCapacity;

        set {
            if (value < 0) {
                throw new ArgumentException("Passenger capacity cannot be negative");
            }
            passengerCapacity = value;
        }
    }


    public PassengerAirplane(string model, double wingSpan, string company, double maxAltitude, double maxSpeed, int passengerCapacity)
        : base(model, wingSpan, company, maxAltitude, maxSpeed)
    {
        PassengerCapacity = passengerCapacity;
    }
}
