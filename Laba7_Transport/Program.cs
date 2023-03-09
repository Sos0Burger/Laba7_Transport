internal class Program
{
    private static void Main(string[] args)
    {
        CarImpl car = new CarImpl("Корыто", 70, 300, 150);
        AirplaneImpl airplane = new AirplaneImpl("Летающие корыто", 100, 5000, 7000);
        ShipImpl ship = new ShipImpl("Плавающее корыто", 50, 10000, 1000);

        car.Print();
        airplane.Print();
        ship.Print();
    }
}

abstract class Transport
{
    public abstract string Name { get; set; }
    public abstract int speed { get; set; }
    public abstract int weightCapacity { get; set; }
    public abstract int range { get; set; }
    public abstract void Print();
}
abstract class Car : Transport
{
    public override string Name { get; set; }
    public override int speed { get; set; }
    public override int weightCapacity { get; set; }
    public override int range { get; set; }
}
abstract class Airplane : Transport
{
    public override string Name { get; set; }
    public override int speed { get; set; }
    public override int weightCapacity { get; set; }
    public override int range { get; set; }
}
abstract class Ship : Transport
{
    public override string Name { get; set; }
    public override int speed { get; set; }
    public override int weightCapacity { get; set; }
    public override int range { get; set; }
}
class CarImpl : Car
{

    public override void Print()
    {
        Console.WriteLine($"Машина {Name} грузоподъемностью в {weightCapacity} кг может проехать {range} км со скоростью {speed}");
    }

    public CarImpl(string name, int speed, int weightCapacity, int range)
    {
        Name = name;
        this.speed = speed;
        this.weightCapacity = weightCapacity;
        this.range = range;
    }
}
class AirplaneImpl : Airplane
{
    public override void Print()
    {
        Console.WriteLine($"Самолет {Name} грузоподъемностью в {weightCapacity} кг может проехать {range} км со скоростью {speed}");
    }

    public AirplaneImpl(string name, int speed, int weightCapacity, int range)
    {
        Name = name;
        this.speed = speed;
        this.weightCapacity = weightCapacity;
        this.range = range;
    }
} 
class ShipImpl : Ship
{
    public override void Print()
    {
        Console.WriteLine($"Корабль {Name} грузоподъемностью в {weightCapacity} кг может проехать {range} км со скоростью {speed}");
    }

    public ShipImpl(string name, int speed, int weightCapacity, int range)
    {
        Name = name;
        this.speed = speed;
        this.weightCapacity = weightCapacity;
        this.range = range;
    }
}