namespace CsharpDemo
{
    public class Car
    {
        public string Name { get; set; }
    }

    public class CarFactory
    {
        public static Car GetCar()
        {
            Car car1 = new Car() { Name = "Your Favourit Car" };
            return car1;
        }
        public static IEnumerable<Car> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { Name = "My Car 1" },
                new Car() { Name = "My Car 2" },
            };
            return cars;
        }

    }
}
