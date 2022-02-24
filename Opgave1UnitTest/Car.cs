using System;

namespace Opgave1UnitTest
{
    public class Car
    {
        private string _model;
        private int _price;
        private string _licensePlate;

        public int Id { get; set; }

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length < 4) throw new ArgumentException(message: "Model name must be at least 4 characters");
                _model = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException( "Price", value, "Lets make some moneeeyz");
                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length < 2 || value.Length < 7) throw new ArgumentOutOfRangeException(nameof(value));
                _licensePlate = value;
            }
        }

        public Car(int id, string model, int price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }
    }
}
