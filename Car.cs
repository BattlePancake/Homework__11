using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__11
{
    //---------------------------- Task 3 -------------------------------


    public class Car
    {
        internal string EngineType { get; }
        public void PrintCar()
        {
            Console.WriteLine($"Your car's Engine Type is: {EngineType}");
        }
        internal Car(string engineT)
        {
            EngineType = engineT;
        }
    }

    internal class Engine
    {
        public int EngineCode { get; set; }
        public virtual void Driving()
        {

        }

        public void AddCar()
        {
            if (EngineCode == (int)TypeOfEngine.Diesel)
            {
                var a = new Car("Diesel");
                a.PrintCar();
                DrivingCar(new DieselEngine(1));
            }
            else if (EngineCode == (int)TypeOfEngine.Gas)
            {
                var b = new Car("Gas");
                b.PrintCar();
                DrivingCar(new GasEngine(2));
            }
            else if (EngineCode == (int)TypeOfEngine.Electric)
            {
                var c = new Car("Electric");
                c.PrintCar();
                DrivingCar(new ElectricEngine(3));
            }
            else
            {
                Console.WriteLine("Incorrect code of engine.");
                return;
            }
        }
        internal Engine(int engineCodeConstructor)
        {
            EngineCode = engineCodeConstructor;
        }

        internal void DrivingCar(Engine drv)
        {
            drv.Driving();
        }

        enum TypeOfEngine : int
        {
            Diesel = 1,
            Gas,
            Electric
        }
    }
    internal class DieselEngine : Engine
    {
        // internal string _dieselEngine {get;init;} = "Diesel";
        public override void Driving()
        {
            Console.WriteLine("Diesel car is driving");
        }
        internal DieselEngine(int engineCodeConstructor) : base(engineCodeConstructor)
        {
        }

    }
    internal class GasEngine : Engine
    {
        // internal string _gasEngine {get;init;} = "Gas";
        public override void Driving()
        {
            Console.WriteLine("Gas car is driving");
        }
        internal GasEngine(int engineCodeConstructor) : base(engineCodeConstructor)
        {
        }
    }
    internal class ElectricEngine : Engine
    {
        // internal string _electricEngine {get;init;} = "Electric";
        public override void Driving()
        {
            Console.WriteLine("Electric car is driving");
        }
        internal ElectricEngine(int engineCodeConstructor) : base(engineCodeConstructor)
        {
        }
    }
}
