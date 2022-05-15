using ConsoleChopHouseApi;
using ChopHouse
using System.Net.Http;
using System.Net.Http.Headers;

using var client = new HttpClient();

client.BaseAddress = new Uri("https://localhost:7130/api/CH");

var respose=client.GetAsync("chophouse");
response.wait();

var result = response.Result;
if(result.IsSuccessStatusCode){
    var readTask=result.content.ReadAsAsync<List<ChopHouse>>();
    readTask.Wait();

    var chophouse = readTask.Results;
    foreach (var c in chophouse){
        Console.WriteLine(readTask.name);
    }
}

