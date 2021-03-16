using NUnit.Framework;

namespace Tests
{
    
    public class CarTests
    {
        private const string MAKE = "2020";
        private const string MODEL = "Porshe";
        private const double FUEL_CONSUMPTION = 10;
        private const double FUEL_CAPACITY = 220;
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car(MAKE, MODEL, FUEL_CONSUMPTION, FUEL_CAPACITY);
        }

        [Test]
        public void ConstructorIsNotNull()
        {
            Assert.IsNotNull(car);
        }
        [Test]
        [TestCase(null, MODEL, FUEL_CONSUMPTION, FUEL_CAPACITY)]
        [TestCase("",MODEL, FUEL_CONSUMPTION,FUEL_CAPACITY)]
        [TestCase(MAKE,null,FUEL_CONSUMPTION,FUEL_CAPACITY)]
        [TestCase(MAKE,"",FUEL_CONSUMPTION,FUEL_CAPACITY)]
        [TestCase(MAKE,MODEL,0,FUEL_CAPACITY)]
        [TestCase(MAKE, MODEL,-1,FUEL_CAPACITY)]
        [TestCase(MAKE, MODEL,FUEL_CONSUMPTION,0)]
        [TestCase(MAKE, MODEL,FUEL_CONSUMPTION,-1)]
        public void IsAnyPropertyInvalid(
            string make,
            string model,
            double fuelCpnsumption,
            double fuelCapacity)
        {
            Assert.That(() => new Car(make, model, fuelCpnsumption, fuelCapacity), Throws.ArgumentException);
        }
        [Test]
        public void IsFuelAmounthValid()
        {
            Assert.AreEqual(0, car.FuelAmount);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]

        public void IsRefuelNegative(double refuel)
        {
            Assert.That(() => car.Refuel(refuel), Throws.ArgumentException);
        }

        [Test]
        [TestCase(150)]

        public void IsRefuelValid(double refuel)
        {
            double expectedResult = refuel;
            car.Refuel(refuel);
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        [TestCase(250)]
        
        public void IsFuelAmountMoreThanCapacity(double refuel)
        {
            double expectedResult = FUEL_CAPACITY;
            car.Refuel(refuel);
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        [TestCase(20)]
        public void IsDistanceCorrectlyCalculated(double distance)
        {
            car.Refuel(100);
            double fuelNeeded = (distance / 100) * FUEL_CONSUMPTION;
            double expectedResult = car.FuelAmount - fuelNeeded;

            car.Drive(distance);
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        [TestCase(550)]
        public void IsDistanceMoreThanFuel(double distance)
        {
            Assert.That(() => this.car.Drive(distance), Throws.InvalidOperationException);
        }
    }
}
