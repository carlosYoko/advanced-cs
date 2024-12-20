﻿// Task
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
/* Console.WriteLine("Inicio del programa");

var task = Methods.Wait(1000);
Console.WriteLine("Hago algo mas");

await task;
Console.WriteLine("Fin del programa");
*/


// TResult
/* var taskResult = Methods.AddAsync(3, 4);
var number = await taskResult;
Console.WriteLine(number);
*/


// ContinueWith
/* var tasks = Task.Run(() =>
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
*/


// WhenAll
/* List<Task> tasks = new List<Task>()
{
    Methods.Wait(1000),
    Methods.Wait(2000)
};

await Task.WhenAll(tasks);
Console.WriteLine("Fin de todas las tareas con delay");

List<Task<double>> results = new List<Task<double>>()
{
    Methods.AddAsync(2,2),
    Methods.AddAsync(2,6),
    Methods.AddAsync(2,8)
};

Console.WriteLine("Fin de todas las tareas de suma");

double[] resultsTasksDouble = await Task.WhenAll(results);
foreach (double result in resultsTasksDouble)
{
    Console.WriteLine(result);
}
*/


// Thread
/* Thread thread = new Thread(() =>
{
    Console.WriteLine("Inicio");

    Thread.Sleep(5000);

    Console.WriteLine("Fin");
});

Console.WriteLine("Inicio del programa");

thread.Start();

Console.WriteLine("El progrmaa principal hace otra coas");

thread.Join();

Console.WriteLine("Fin del programa");
*/


// Parallel.For
/* int numberOfFiles = 100;

Parallel.For(0, numberOfFiles, i =>
{
    string fileName = $"fichero_{i}.txt";
    string content = $"fichero num: {i}";

    File.WriteAllText(fileName, content);

    Console.WriteLine($"Archivo '{fileName}' creado por el hilo {Task.CurrentId}");
});
*/


// Parallel.ForEach
/*List<int> ids = new List<int>
{
    2, 22, 32, 4, 12, 34, 67, 89, 56, 24
};

Parallel.ForEach(ids, i =>
{
    string fileName = $"fichero_{i}.txt";
    string content = $"fichero numero: {i}";

    File.WriteAllText(fileName, content);

    Console.WriteLine($"Fichero '{fileName} creado por el hilo: {Task.CurrentId}");
});

Console.WriteLine("Se han terminado todos los procesos");
*/


// Parallel.ForEachAsync
List<int> episodes = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
var url = "https://rickandmortyapi.com/api/episode/";
var httpClient = new HttpClient();

await Parallel.ForEachAsync(episodes, async (episode, cancellationToken) =>
{
    try
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;

        HttpResponseMessage response = await httpClient.GetAsync(url + episode);
        string responseBody = await response.Content.ReadAsStringAsync();

        string fileName = $"episode{episode}.txt";
        await File.WriteAllTextAsync(fileName, responseBody);

        Console.WriteLine($"Archivo '{fileName} creado por el hilo: {threadId}'");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al solicitar {url}: {ex.Message}");
    }

});
