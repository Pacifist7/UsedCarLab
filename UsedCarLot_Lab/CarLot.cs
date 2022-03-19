namespace UsedCarLot_Lab
{
    public class CarLot
    {
        //Initial list
        private List<Car> _currentInventory { get; set; }

        public CarLot()
        {
            _currentInventory = new List<Car>()
            {
                new Car("Honda", "Accord", 2022, 26120),
                new Car("Mazda", "Mazda6", 2021, 24475),
                new Car("Toyota", "Camry", 2022, 25395),
                new UsedCar("Ford", "Fusion", 2010,6400, 100000),
                new UsedCar("Mercury", "Milan", 2010, 7700, 110000),
                new UsedCar("Saturn", "Aura", 2009, 6000, 120000)

            };
        }

        public void AddCars(UsedCar car)
        {
            _currentInventory.Add(car);
        }

        public void RemoveCars(string make)
        {
            var carPurchased = _currentInventory.FirstOrDefault(x => x.Make == make);

            _currentInventory.Remove(carPurchased);
        }


        public void ListCars()
        {
            foreach (var car in _currentInventory)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
