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
            return new () { Name = "My car" };
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
