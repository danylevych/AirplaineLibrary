namespace AirplaneLibrary;

public class Airplane
{
    public string Model { get; }
    public double WingSpan { get; }
    public string Company { get; }
    public double MaxAltitude { get; }
    public double MaxSpeed { get; }
    public string FlightNumber { get; set; }
    private double currentSpeed;

    public Airplane(string model, double wingSpan, string company, double maxAltitude, double maxSpeed)
    {
        Model = model;
        WingSpan = wingSpan;
        Company = company;
        MaxAltitude = maxAltitude;
        MaxSpeed = maxSpeed;
        currentSpeed = 0;
    }

    public double GetCurrentSpeed() => currentSpeed;

    public void ChangeSpeed(double delta)
    {
        currentSpeed = Math.Clamp(currentSpeed + delta, 0, MaxSpeed);
    }
}
