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
            return new Car() { Name = "My car" };
        }
        public static IEnumerable<Car> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { Name = "My car 1" },
                new Car() { Name = "My car 2" },
            };
            return cars;
        }

    }
}
