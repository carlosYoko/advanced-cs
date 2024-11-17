// Task
/* Console.WriteLine("Inicio programa");

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
*/


// async & awaint
using AdvancedCS.Concurrent;

Console.WriteLine("Inicio del programa");

var task = Methods.Wait(1000);
Console.WriteLine("Hago algo mas");

await task;
Console.WriteLine("Fin del programa");


// TResult
var taskResult = Methods.AddAsync(3, 4);
var number = await taskResult;
Console.WriteLine(number);


// ContinueWith
var tasks = Task.Run(() =>
{
    Console.WriteLine("Tarea incial secuencial INICIA");

    var resultTask = Methods.AddAsync(4, 4);

    Console.WriteLine("Tarea incial secuencial FINALIZA");

    return resultTask.Result;

}).ContinueWith((resultTask) =>
{
    Console.WriteLine("Segunda tarea secuencial INICIA");
    var result = resultTask.Result;
    Console.WriteLine($"El resultado es {result}");

    Task.Delay(2000).Wait();

    Console.WriteLine("Segunda tarea secuencial FINALIZA");
});

await tasks;

Console.WriteLine("Fin de las tareas secuenciales");