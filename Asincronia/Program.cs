

using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
string url1 = "https://jsonplaceholder.typicode.com/posts";
string url2 = "https://jsonplaceholder.typicode.com/photos";


string path1 = "file1.json";
string path2 = "file2.json";


var stopwatch = new Stopwatch();
var client = new HttpClient();

stopwatch.Start();


var task = Task.Run(() =>
{
  Thread.Sleep(2000);
  Console.WriteLine("Tarea interna completada");
});

var response1 = await client.GetAsync(url1);
var response2 = await client.GetAsync(url2);

var content1 = await response1.Content.ReadAsStringAsync();
var content2 = await response2.Content.ReadAsStringAsync();


var fileTask = File.WriteAllTextAsync(path1, content1);
var fileTask2 = File.WriteAllTextAsync(path2, content2);

await fileTask;
await fileTask2;

await task;
stopwatch.Stop();

Console.WriteLine("Tiempo: " + stopwatch.Elapsed);