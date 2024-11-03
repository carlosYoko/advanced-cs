using AdvancedCS.Generics;

// Generics in classes
var box = new Box<int>(7);
Console.WriteLine(box.Get());
box.Set(10);
Console.WriteLine(box.GetContent());

var box2 = new Box<bool>(false);
Console.WriteLine(box2.GetContent());


// Generics in methods
BikeRepository bikeRepository = new BikeRepository();
bikeRepository.Add("Honda");
bikeRepository.Add("Yamaha");

Show(bikeRepository);

void Show<T>(IRepository<T> repository)
{
    foreach (var item in repository.GetAll())
    {
        if (item == null) continue;
        Console.WriteLine(item);
    }
}


// Restriction classes and interfaces
var vehicle = new Vehicle(1000);
var bike = new Bike("Honda", 600);
ShowEngine(vehicle);
ShowEngine(bike);
ShowInfo(bike);

void ShowEngine<T>(T vehicle) where T : Vehicle
{
    Console.WriteLine(vehicle.Engine);
}

void ShowInfo<T>(T element) where T : IInfo
{
    Console.WriteLine(element.GetInfo());
}


// Restriction in constructor
var pool = new ObjectPool<Clock>(3);

while (pool.Count > 0)
{
    var clock = pool.Get();
    Console.WriteLine(clock.Date);
}

var pool2 = new ObjectPool<RandomCustom>(3);
while (pool2.Count > 0)
{
    var random = pool2.Get();
    Console.WriteLine(random.Number);
}


// Multiple restrictions
ShowInfoAndEngine(bike);

void ShowInfoAndEngine<T>(T element) where T : Bike, IInfo
{
    Console.WriteLine("ShowInfoAndEngine: " + element.GetInfo());
    Console.WriteLine("ShowInfoAndEngine: " + element.Engine);
}


// Covariance
IVehicleCreator<Vehicle> bikeCreator = new NakedCreator();
var ducati = bikeCreator.Create(1000);


// Generics in delegates
Operation<string> concat = (a, b) => a + " " + b;
Console.WriteLine(concat("Hello", "World"));

Operation<int> add = (a, b) => a + b;
Console.WriteLine(add(5, 2));

Operation<double> addDouble = (a, b) => a + b;
Console.WriteLine(addDouble(5.3, 2.4));

delegate T Operation<T>(T a, T b);


// Restriction type in generics
delegate T Operation2<T>(T a, T b) where T : struct;
delegate T Operation3<T>(T a, T b) where T : class;