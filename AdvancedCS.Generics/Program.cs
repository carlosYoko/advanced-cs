using AdvancedCS.Generics;

var box = new Box<int>(7);
Console.WriteLine(box.Get());
box.Set(10);
Console.WriteLine(box.GetContent());

var box2 = new Box<bool>(false);
Console.WriteLine(box2.GetContent());
