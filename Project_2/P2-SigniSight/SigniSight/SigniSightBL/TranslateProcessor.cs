using System.Text;
using Newtonsoft.Json;

namespace SigniSightBL
{
    public class TranslateProcessor
    {
        static string subscriptionKeyFilePath = "../SigniSightBL/TranslateKey.txt";
        static string key = File.ReadAllText(subscriptionKeyFilePath);
        static string endpointFilePath = "../SigniSightBL/TranslateLocation.txt";
        static string location = File.ReadAllText(endpointFilePath);
        private static readonly string endpointTranslate = "https://api.cognitive.microsofttranslator.com/";
       // private static string route = "/translate?api-version=3.0&to=en"; //change it to variable
        public static async Task<string> TranslateText(string textToTranslate, string language)
        {
            string route = $"/translate?api-version=3.0&to={language}";
            //language += "&to="; 
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);
            var client2 = new HttpClient();
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(endpointTranslate + route);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("Ocp-Apim-Subscription-Key", key);
            request.Headers.Add("Ocp-Apim-Subscription-Region", location);

            HttpResponseMessage response = await client2.SendAsync(request).ConfigureAwait(false);
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
