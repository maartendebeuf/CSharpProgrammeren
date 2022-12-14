using MVC_Klas.Models;
using System.Text.Json;

namespace MVC_Klas.Services
{
    public class JsonDierenartsService
    {

        public JsonDierenartsService(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonDataFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "dierenartsen.json");
            }
        }

        public IEnumerable<Dierenarts> GetDierenartsen()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonDataFileName))
            {
                Dierenarts[] Lijst;
                Lijst = JsonSerializer.Deserialize<Dierenarts[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return Lijst;
            }
        }

        public Dierenarts GetDierenartsByName(string name)
        {
            List<Dierenarts> lijst = GetDierenartsen().ToList();
            return lijst.First(e => e.Naam == name);

        }

    }
}
