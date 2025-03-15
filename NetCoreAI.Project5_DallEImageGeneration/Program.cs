using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;

class Program
{
   public static async Task Main(string[] args)
    {
        string apikey = "Key buraya";
        Console.WriteLine("Resim Dosyası Yolu: ");
        string prompt;
        prompt = Console.ReadLine();
        using (HttpClient client = new HttpClient()) 
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apikey}");
            var requestBody = new
            {
                prompt = prompt,
                n = 1,
                size = "1024x1024"
            };
            string jsonBody = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/images/generations", content);
            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);

        }
    }
}