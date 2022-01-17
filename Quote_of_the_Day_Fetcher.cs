```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("https://quotes.rest/qod");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var data = JObject.Parse(responseBody);
            var quote = data["contents"]["quotes"][0]["quote"].ToString();
            var author = data["contents"]["quotes"][0]["author"].ToString();

            Console.WriteLine($"Quote of the Day: {quote}");
            Console.WriteLine($"Author: {author}");
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ",e.Message);
        }
    }
}
```