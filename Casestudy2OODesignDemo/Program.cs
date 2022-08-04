
//Hybridcar car = new Hybridcar();
//PetrolEngine pe = new PetrolEngine();
//DieselEngine de = new DieselEngine();
//GasEngine ge = new GasEngine();
//HydrogenEngine hye = new HydrogenEngine();
////car.PEngine = pe;
////car.DEngine = de;
////car.GEngine = ge;
//car.Engines.Add(pe);
//car.Engines.Add(de);
//car.Engines.Add(ge);
//car.Engines.Add(hye);

//car.Go();


//public interface Engine
//{
//    void Run();

//}

//class PetrolEngine : Engine //borrowed only abstraction 
//{
//    public void Run()
//    {
//        Console.WriteLine("Running with Petrol");
//    }    
//}
//class DieselEngine : Engine
//{
//    public void Run()
//    {
//        Console.WriteLine("Running with Diesel");
//    }
//}
//class GasEngine : Engine
//{
//    public void Run()
//    {
//        Console.WriteLine("Running with Gas");
//    }
//}
//class HydrogenEngine : Engine
//{
//    public void Run()
//    {
//        Console.WriteLine("Running with Hydrogen");
//    }
//}
//class Hybridcar //modify once for all like how it shpuld work even if something new added it should work.
//                //should have collectio of engine. it should work with any type of engine it is called program to a contract.
//{
//    //public PetrolEngine PEngine { get; set; }   
//    //public DieselEngine DEngine { get; set; }
//    //public GasEngine GEngine { get; set; }
//    public List <Engine> Engines { get; set; } = new List<Engine>();
//    public void Go()
//    {
//        //if(PEngine != null) PEngine.Run();
//        //if(DEngine != null) DEngine.Run();
//        //if(GEngine != null) GEngine.Run();

//        //to work with any type of engine create a contract of program.
//        foreach(Engine engine in Engines)
//        {
//            engine.Run();
//        }
//    }
//}

//---------------------------------------------------------------------------------------------
//------------------------------------Master Code-----------------------------------------------
//----------------------------------------------------------------------------------------------
HybridCar car = new HybridCar();
PetrolEngine pe = new PetrolEngine();
DieselEngine de = new DieselEngine();
GasEngine ge = new GasEngine();
HydrogenEngine he = new HydrogenEngine();

car.Engines.Add(pe);
car.Engines.Add(de);
car.Engines.Add(ge);
car.Engines.Add(he);
car.Go();


public interface Engine
{
    void Run();

}

class PetrolEngine : Engine
{
    public void Run()
    {
        Console.WriteLine("Running with Petrol");
    }
}

class DieselEngine : Engine
{
    public void Run()
    {
        Console.WriteLine("Running with Diesel");
    }
}

class GasEngine : Engine
{
    public void Run()
    {
        Console.WriteLine("Running with Gas");
    }
}

class HydrogenEngine : Engine
{
    public void Run()
    {
        Console.WriteLine("Running with H2");
    }
}

class HybridCar
{
    //public PetrolEngine PEngine { get; set; }
    //public DieselEngine DEngine { get; set; }
    public List<Engine> Engines { get; set; } = new List<Engine>();

    public void Go()
    {
        //if (PEngine != null) PEngine.Run();
        //if (DEngine != null) DEngine.Run();

        foreach (Engine engine in Engines)
        {
            engine.Run();
        }
    }
}