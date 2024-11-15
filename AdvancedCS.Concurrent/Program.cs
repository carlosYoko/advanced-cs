// Task
Console.WriteLine("Inicio programa");

var task = Task.Run(async () =>
{
    Console.WriteLine("Inicio task");

    await Task.Delay(1000);

    Console.WriteLine("Fin task");
});

Console.WriteLine("Algo extra");

await task;

Console.WriteLine("Algo extra despues");


Console.WriteLine("Fin programa");