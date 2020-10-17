using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _3.HW
{
    internal partial class Car
    {
        private static readonly byte s_weelCount = 4;
        private static readonly string s_type = "vehicle";

        private readonly string _model;
        private CarFrame _carFrame;
        private Engine _engine;
        private Transmission _transmission;
        private int _horsePower;

        private List<Passenger> _passengers = new List<Passenger>();
        public CarFrame CarFrame { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }

        static Car()
        {

        }

        public Car(string model)
        {
            _model = model;
        }

        public Car(int horsePower, string model) : this(model)
        {
            _horsePower = horsePower;
        }

        public Car(CarFrame carFrame, Engine engine, Transmission transmission, int horsePower, string model = "none") : this(horsePower, model)
        {
            _carFrame = carFrame         ?? throw new ArgumentNullException(nameof(carFrame));
            _engine = engine             ?? throw new ArgumentNullException(nameof(engine));
            _transmission = transmission ?? throw new ArgumentNullException(nameof(transmission));
        }

        public string GetModelName()
        {
            return _model;
        }

        public int GetHorsePower()
        {
            return _horsePower;
        }

        public void AddPassenger(Passenger passenger)
        {
            _passengers.Add(passenger);
        }

        public bool TryDrive()
        {
            throw new NotImplementedException();
        }

        public bool TryBreak()
        {
            throw new NotImplementedException();
        }

        public bool TryEmetgencyThrowOutThePassengers()
        {
            throw new NotImplementedException();
        }
    }
}
