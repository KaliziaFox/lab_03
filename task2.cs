//public class Car : IEquatable<Car>
//{
//    private string _name, _engine;
//    private int _maxspeed;

//    public Car(string name, string engine, int maxspeed)
//    {
//        _name = name;
//        _engine = engine;
//        _maxspeed = maxspeed;
//    }

//    public string Name
//    {
//        get { return _name; }
//    }
//    public string Engine
//    {
//        get { return _engine; }
//    }
//    public int MaxSpeed
//    {
//        get { return _maxspeed; }
//    }
//    public override string ToString()
//    {
//        return this.Name;
//    }
//    public bool Equals(Car? other)
//    {
//        return other.Name == this.Name && other.Engine == this.Engine && other.MaxSpeed == this.MaxSpeed;
//    }
//}
//class CarsCatalog
//{
//    private List<Car> cars = new List<Car>();

//    public string this[int index]
//    {
//        get { return $"{cars[index].Name} - {cars[index].Engine}"; }
//        set { cars[index] = new Car ( value, "", 0 ); }
//    }

//    public void AddCar(Car car)
//    {
//        cars.Add(car);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car1 = new Car("BMW", "3,5", 200);
//        Car car2 = new Car("Lexus", "1,8", 180);

//        Console.WriteLine(car1);
//        Console.WriteLine(car2);

//        Console.WriteLine(car1.Equals(car2));

//        CarsCatalog catalog = new CarsCatalog();
//        catalog.AddCar(car1);
//        catalog.AddCar(car2);

//        Console.WriteLine(catalog[0]);
//        Console.WriteLine(catalog[1]);

//        catalog[0] = "Mersedes";
//        Console.WriteLine(catalog[0]);
//    }
//}
