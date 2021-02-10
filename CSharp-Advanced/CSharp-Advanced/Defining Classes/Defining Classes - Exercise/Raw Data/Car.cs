namespace DefiningClasses
{
    public class Car
    {

        public Car(string model, Cargo cargo, Engine engine, Tires[] tire)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
            this.Tire = tire;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tire { get; set; }

    }
}
