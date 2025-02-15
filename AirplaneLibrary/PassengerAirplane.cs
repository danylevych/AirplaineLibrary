namespace AirplaneLibrary;


public class PassengerAirplane : Airplane
{
    public int PassengerCapacity { get; }

    public PassengerAirplane(string model, double wingSpan, string company, double maxAltitude, double maxSpeed, int passengerCapacity)
        : base(model, wingSpan, company, maxAltitude, maxSpeed)
    {
        PassengerCapacity = passengerCapacity;
    }
}
