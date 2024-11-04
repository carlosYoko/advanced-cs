// ########
// # Uses #
// ########

// Basic record
var bike = new Bike("HONDA", 600);
Console.WriteLine(bike.Brand);
Console.WriteLine(bike.Engine);

// Comparation
var bike2 = new Bike("YAMAHA", 1000);
Console.WriteLine(bike2 == bike); // False

var bike3 = new Bike("honda", 600);
Console.WriteLine(bike3 == bike); // False

var bike4 = new Bike("HONDA", 600);
Console.WriteLine(bike4 == bike); // True

// Comparation2
var bikeComparation = new BikeComparation("HONDA", 1000, new Model("CBR"));
var bikeComparation2 = new BikeComparation("HONDA", 1000, new Model("CBR"));
Console.WriteLine(bikeComparation == bikeComparation2); // True

// Deconstructing
var (brand, engine, model) = bikeComparation;
Console.WriteLine(brand);
Console.WriteLine(engine);
Console.WriteLine(model.Name);

var (n, _, _) = bikeComparation;
Console.WriteLine(n);

// Records with mutable props
var barcelona = new City("Barcelona") { Population = 1_600_000 };
barcelona.Population = 1_666_000;

// 'with' Expression
var bikeOriginal = new BikeComparation("Yamaha", 1000, new Model("R1"));
var bikeWith = bikeOriginal with { Engine = 1090 };



// ##################
// # Implementation #
// ##################

// Basic record
record Bike(string Brand, double Engine);

// Comparation2
record BikeComparation(string Brand, double Engine, Model model);
record Model(string Name);

// Rcords with mutable props
record City(string Name)
{
    public int Population { get; set; }
}