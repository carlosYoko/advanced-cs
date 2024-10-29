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