// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

List<Car> cars = new List<Car>();
cars.Add(new VW());

cars[0].DoShit();

public class Car
{
    protected int num = 12;
    public virtual void DoShit()
    {
        Console.WriteLine("CAR SHIT");
    }
}

public class VW : Car
{
    public VW()
    {

    }
    public override void DoShit()
    {
        Console.WriteLine("VW SHIT " + this.num);
    }
}
