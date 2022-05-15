using ConsoleChopHouseApi;
using System.Net.Http;
using System.Net.Http.Headers;

using var client = new HttpClient();

client.BaseAddress = new Uri("https://localhost:7130/api/CH");
try{
var respose=client.GetAsync("chophouse");
response.wait();

var result = response.Result;
if(result.IsSuccessStatusCode){
    var readTask=result.Content.ReadAsAsync<List<ChopHouseDraft>>();
    readTask.Wait();

    var chophouse = readTask.Results;
    foreach (var c in chophouse)
    {
        Console.WriteLine(readTask.name);
    }

}
}
catch(System.Net.Http.HttpRequestException ex)
    {
    System.Console.WriteLine(ex.Message);
    }
    