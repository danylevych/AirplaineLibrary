using AirplaneLibrary;


namespace AirplaneTests
{
    [TestFixture]
    public class AirplaneTests
    {
        private Airplane _plane;
        private CargoAirplane _cargo;
        private PassengerAirplane _passenger;

        [SetUp]
        public void Init()
        {
            _plane = new Airplane("Boeing 747", 68.5, "Boeing", 13000, 900);
            _cargo = new CargoAirplane("Antonov An-225", 88.4, "Antonov", 12000, 850, 250);
            _passenger = new PassengerAirplane("Airbus A380", 79.8, "Airbus", 13100, 1020, 850);
        }

        [Test]
        public void Airplane_Initialization_SetsPropertiesCorrectly()
        {
            Assert.That(_plane.Model, Is.EqualTo("Boeing 747"));
            Assert.That(_plane.WingSpan, Is.EqualTo(68.5));
            Assert.That(_plane.Company, Is.EqualTo("Boeing"));
            Assert.That(_plane.MaxAltitude, Is.EqualTo(13000));
            Assert.That(_plane.MaxSpeed, Is.EqualTo(900));
            Assert.That(_plane.GetCurrentSpeed(), Is.EqualTo(0));
        }

        [Test]
        public void Airplane_ChangeSpeed_IncreasesSpeedCorrectly()
        {
            _plane.ChangeSpeed(400);
            Assert.That(_plane.GetCurrentSpeed(), Is.EqualTo(400));
        }

        [Test]
        public void Airplane_ChangeSpeed_DoesNotExceedMaxSpeed()
        {
            _plane.ChangeSpeed(1000);
            Assert.That(_plane.GetCurrentSpeed(), Is.EqualTo(900));
        }

        [Test]
        public void Airplane_ChangeSpeed_DoesNotGoBelowZero()
        {
            _plane.ChangeSpeed(-50);
            Assert.That(_plane.GetCurrentSpeed(), Is.EqualTo(0));
        }

        [Test]
        public void Airplane_ChangeSpeed_DecreasesSpeedCorrectly()
        {
            _plane.ChangeSpeed(500);
            _plane.ChangeSpeed(-200);
            Assert.That(_plane.GetCurrentSpeed(), Is.EqualTo(300));
        }

        [Test]
        public void CargoAirplane_Initialization_SetsPropertiesCorrectly()
        {
            Assert.That(_cargo.Company, Is.EqualTo("Antonov"));
            Assert.That(_cargo.CargoCapacity, Is.EqualTo(250));
        }

        [Test]
        public void PassengerAirplane_Initialization_SetsPropertiesCorrectly()
        {
            Assert.That(_passenger.Company, Is.EqualTo("Airbus"));
            Assert.That(_passenger.PassengerCapacity, Is.EqualTo(850));
        }

        [Test]
        public void CargoAirplane_NegativeCapacity_ThrowsException()
        {
            var ex = Assert.Throws<System.ArgumentException>(() =>
                new CargoAirplane("Test Cargo", 70.0, "TestCompany", 10000, 800, -5));
            Assert.That(ex.Message, Does.Contain("Cargo capacity cannot be negative"));
        }

        [Test]
        public void PassengerAirplane_NegativePassengerCount_ThrowsException()
        {
            var ex = Assert.Throws<System.ArgumentException>(() =>
                new PassengerAirplane("Test Passenger", 70.0, "TestCompany", 10000, 800, -3));
            Assert.That(ex.Message, Does.Contain("Passenger capacity cannot be negative"));
        }
    }
}
