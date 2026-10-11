//using LLDPractice.Vehicle.Classes;
//using LLDPractice.Vehicle.Interfaces;

//Strategy DP
using LLDPractice.AbstractFactoryPattern;
using LLDPractice.ChainResponsibilityLoggerSystem;
using LLDPractice.DecoratorPattern;
using LLDPractice.FactoryPattern;
using LLDPractice.ObserverPattern;
using LLDPractice.StrategyPattern;

public class Program
{
    public static void Main()
    {

        //Liskov
        //List<Vehicle> vehicles = new List<Vehicle>();
        //vehicles.Add(new Car());
        //vehicles.Add(new Bicycle());

        //foreach(Vehicle vehicle in vehicles)
        //{
        //    MoveVehicle(vehicle);

        //}

        //Strategy Pattern

        //List<Vehicle> vehicleList = new List<Vehicle>();
        //vehicleList.Add(new Waganor());
        //vehicleList.Add(new I20Sports());

        //foreach(Vehicle v in vehicleList)
        //{
        //    v.driveVehicle();
        //}

        //Observer Pattern

        Store.main();

        //Decorator Pattern

        DecoratorClass.main();

        //Factory Pattern

        FactoryPattern.main();

        //Abstract Factory Pattern

        AbstractFactoryPattern afp = new AbstractFactoryPattern("WINDOWS");
        afp.main();

        //Chain Responsibility Pattern

        ChainResponsibilityProcessor.main();
        
    }


    // Liskov
    //public static void MoveVehicle(Vehicle vehicle)
    //{
    //    vehicle.Move();
    //}

    //public static void StartEngine(IEngineVehicle vehicle)
    //{
    //    vehicle.StartEngine();
    //}
}