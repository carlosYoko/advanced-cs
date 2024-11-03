// ##########
// ## Uses ##
// ##########

// Inmutability 
var calculator = new Calculator(15);
Console.WriteLine(Calculator.PI); ;

// Inmutability with props readonly
var brand = new Brand("Honda");
var brandName = brand.Name;

// Inmutable list
List<string> bikeList = new List<string>() { "CBR", "CBF" };
var bikes = new Bike(bikeList);

// With pattern
var carlos = new Person("Carlos");
var carlos2 = carlos.With("Pepe");
Console.WriteLine(carlos2.Name);

// Anonim objects
var people = new
{
    Name = "Carlos",
    Age = 38,
    Country = "Spain"
};


// #####################################
// ## Definitions and implementations ##
// #####################################

// Inmutability
public class Calculator
{
    public const double PI = 3.1416;
    public readonly int Value;

    public Calculator(int value)
    {
        Value = value;
    }
}

// Inmutability with props readonly
public class Brand
{
    public string Name { get; }

    public Brand(string name)
    {
        Name = name;
    }
}

// Inmutable list
public class Bike
{
    public IReadOnlyList<string> Model { get; }

    public Bike(List<string> model)
    {
        Model = model;
    }
}

// With pattern
public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public Person With(string? name = null)
    {
        return new Person(name ?? this.Name);
    }
}
