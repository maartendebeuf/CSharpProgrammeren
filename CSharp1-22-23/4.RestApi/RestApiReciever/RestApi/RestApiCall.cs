using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using RestApi.ResponseModel;

namespace RestApi
{
    public class RestApiCall
    {
        public static void GetIp()
        {
            HttpClient client = new HttpClient();
            Task<string> urlJson = client.GetStringAsync("https://api.ipify.org?format=json");
            urlJson.Wait();
            Console.WriteLine(urlJson.Result);

            IpResponse? antwoord;

            antwoord = System.Text.Json.JsonSerializer.Deserialize<IpResponse>(urlJson.Result);

            Console.WriteLine("Uw Ip-adres is: " + antwoord.ip);
        }

        internal static void GetPublicAPIs()
        {
            HttpClient client = new HttpClient();
            Task<string> json = client.GetStringAsync("https://api.publicapis.org/entries");
            json.Wait();
            //Console.WriteLine(urlJson.Result);

            PublicAPIResponse? antwoord;

            antwoord = System.Text.Json.JsonSerializer.Deserialize<PublicAPIResponse>(json.Result);
            foreach (var item in antwoord.entries)
            {
                Console.WriteLine(  "API:         " + item.API+ "\n" +
                                    "Description: " + item.Description + "\n" +
                                    "Auth:        " + item.Auth + "\n" +
                                    "HTTPS:       " + item.HTTPS + "\n" +
                                    "Cors:        " + item.Cors + "\n" +
                                    "Link:        " + item.Link + "\n" + "\n");
            }

        }

        public static void GetCatList()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://catfact.ninja/");
            Task<HttpResponseMessage> httpResponseMessage = client.GetAsync("breeds");

            httpResponseMessage.Wait();

            var result = httpResponseMessage.Result;
            if (result.IsSuccessStatusCode)
            {
                Task<CatResponse?> breedask = result.Content.ReadFromJsonAsync<CatResponse>();
                breedask.Wait();

                CatResponse? catResponse = breedask.Result;

                Console.WriteLine("Pagina: " + catResponse.current_page);
                foreach (var item in catResponse.data.ToList())
                {
                    Console.WriteLine("Breed: " + item.breed);
                    Console.WriteLine("Country: " + item.country);
                    Console.WriteLine("Origin: " + item.origin);
                    Console.WriteLine("Coat: " + item.coat);
                    Console.WriteLine("Pattern: " + item.pattern);
                    Console.WriteLine("");
                }

                client = new HttpClient();

                Task<HttpResponseMessage> httpResponseMessage2 = client.GetAsync(catResponse.next_page_url);
                httpResponseMessage2.Wait();
                
                var httpResponse2 = httpResponseMessage2.Result;

                Task<CatResponse?> catResponse1 = httpResponse2.Content.ReadFromJsonAsync<CatResponse>();
                catResponse1.Wait();

                CatResponse antw = catResponse1.Result;
                Console.WriteLine("Pagina: " + antw.current_page);
                
            }
        }

        public static void postTest()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://httpbin.org/");

            string sendMessage = "{{\"ParameterTest\": \"WaardeTest\"}}";
            StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync("anything", data);
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
            Console.WriteLine("Result: \n" + httpResponseMessage.Result.ToString());
            Console.WriteLine("Content: \n" + Inhoud.Result);

        }
        public static void DeleteAnythingTest()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://httpbin.org/");

            Task<HttpResponseMessage> httpResponseMessage = httpClient.DeleteAsync("anything");
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
            Console.WriteLine("Result: \n" + httpResponseMessage.Result.ToString());
            Console.WriteLine("Content: \n" + Inhoud.Result);

        }
        public static void DeleteTest()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://httpbin.org/");

            Task<HttpResponseMessage> httpResponseMessage = httpClient.DeleteAsync("Delete");
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
            Console.WriteLine("Result: \n" + httpResponseMessage.Result.ToString());
            Console.WriteLine("Content: \n" + Inhoud.Result);

        }

        public static void ApiSenderGet()
        {
            HttpClient client = new HttpClient();
            Task<string> urlJson = client.GetStringAsync("https://localhost:7126/api/Oefening");
            urlJson.Wait();
            Console.WriteLine(urlJson.Result);

            ApiSenderResponse? antwoord;
            //antwoord = System.Text.Json.JsonSerializer.Deserialize<ApiSenderResponse>(urlJson.Result);

            //Console.WriteLine("Test: " + antwoord.Result);
            
        }

        public static void ApiSenderGetWithToken()
        {
            HttpClient client = new HttpClient();
            Task<string> urlJson = client.GetStringAsync("https://localhost:7126/api/Oefening/GetWithToken?id=1&token=5555");
            urlJson.Wait();
            Console.WriteLine(urlJson.Result);

            ApiSenderResponse? antwoord;
            //antwoord = System.Text.Json.JsonSerializer.Deserialize<ApiSenderResponse>(urlJson.Result);

            //Console.WriteLine("Test: " + antwoord.Result);
        }

        public static void ApiSenderGetWithToken(string? id, string? token)
        {
            HttpClient client = new HttpClient();
            
            Task<string> urlJson = client.GetStringAsync("https://localhost:7126/api/Oefening/GetWithToken?id=" + id + "&token=" + token);
            urlJson.Wait();
            Console.WriteLine(urlJson.Result);

            ApiSenderResponse? antwoord;
        }

        internal static void ApiSenderPost()
        {
            HttpClient httpClient = new HttpClient();

            //httpClient.BaseAddress = new Uri();

            //string sendMessage = "{{\"ParameterTest\": \"WaardeTest\"}}";
            //StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync("https://localhost:7126/api/Oefening",null);
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
        }

        internal static void ApiSenderPost2(string v)
        {
            HttpClient httpClient = new HttpClient();

            //httpClient.BaseAddress = new Uri();

            //string sendMessage = "{{\"ParameterTest\": \"WaardeTest\"}}";
            //StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json")

            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync("https://localhost:7126/api/Oefening/PostFromBody", JsonContent.Create(v));
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
        }
        internal static void ApiSenderPostActionResult(Tekst v)
        {
            HttpClient httpClient = new HttpClient();

            //httpClient.BaseAddress = new Uri();

            //string sendMessage = "{{\"ParameterTest\": \"WaardeTest\"}}";
            //StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json")



            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync("https://localhost:7126/api/Oefening/PostActionResult", JsonContent.Create(v));
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();

            Tekst? antwoord;

            antwoord = System.Text.Json.JsonSerializer.Deserialize<Tekst>(Inhoud.Result);

            Console.WriteLine("Message: " + antwoord.message);
        }

        internal static void ApiSenderPostActionResultStringContent(Tekst tekst)
        {
            HttpClient httpClient = new HttpClient();

            //httpClient.BaseAddress = new Uri();

            string sendMessage = $"{{\"message\": \"{tekst.message}\"}}";
            StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json");



            Task<HttpResponseMessage> httpResponseMessage = httpClient.PostAsync("https://localhost:7126/api/Oefening/PostActionResult", data);
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();

            Tekst? antwoord;

            antwoord = System.Text.Json.JsonSerializer.Deserialize<Tekst>(Inhoud.Result);

            Console.WriteLine("Message: " + antwoord.message);
        }

        internal static void ApiSenderPut()
        {
            HttpClient httpClient = new HttpClient();

            //httpClient.BaseAddress = new Uri();

            //string sendMessage = "{{\"ParameterTest\": \"WaardeTest\"}}";
            //StringContent data = new StringContent(sendMessage, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> httpResponseMessage = httpClient.PutAsync("https://localhost:7126/api/Oefening", null);
            httpResponseMessage.Wait();

            Task<string> Inhoud = httpResponseMessage.Result.Content.ReadAsStringAsync();
            Inhoud.Wait();
        }
    }
}
