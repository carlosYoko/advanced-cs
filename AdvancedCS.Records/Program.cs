// ########
// # Uses #
// ########

// Basic record
var beer = new Bike("CBF", 600);
Console.WriteLine(beer.Brand);
Console.WriteLine(beer.Engine);


// ##################
// # Implementation #
// ##################

// Basic record
record Bike(string Brand, double Engine);