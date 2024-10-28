using AdvancedCS.Generics;

var box = new Box<int>(7);
Console.WriteLine(box.Get());
box.Set(10);
Console.WriteLine(box.GetContent());

var box2 = new Box<bool>(false);
Console.WriteLine(box2.GetContent());

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