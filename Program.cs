//---------------------------- Task 1 -------------------------------

// var newList = new List<string>();
// var genList = new GenericClass<string>(newList);


// genList.AddElement("Paul");
// genList.AddCoupleElements(new [] {"Ann","Drake","Kate"});
// genList.AddElement("Yan");

// genList.GetMyList();
// Console.WriteLine();

// genList.DeleteElement("Yan");
// genList.GetGenericListLength();
// genList.DeleteElementByIndex(3);
// genList.GetElementByIndex(2);

// genList.GetMyList();


//---------------------------- Task 2 -------------------------------

// var newPoint = new Point(23.96,103.54); 
// newPoint.PrintCoords();


//---------------------------- Task 3 -------------------------------

using Homework__11;

Console.WriteLine("Choose your engine: \n(1) - Diesel\n(2) - Gas\n(3) - Electric\n");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();
Engine newEngine = new Engine(a)
{
};

newEngine.AddCar();
