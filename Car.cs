namespace MyWeb
{
    public class Car
    {
        public string Name { get; set; }
    }

    public class CarFactory
    {
        public static Car GetCar()
        {
            Car car1 = new () { Name = "Your Favourit Car" };
            return car1;
        }
        public static IEnumerable<Car> GetCars()
        {
            List<Car> cars = new ()
            {
                new () { Name = "My Car 1" },
                new () { Name = "My Car 2" },
            };
            return cars;
        }

    }
}
