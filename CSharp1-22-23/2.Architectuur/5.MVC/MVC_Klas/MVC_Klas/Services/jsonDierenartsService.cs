namespace MVC_Klas.Services
{
    public class jsonDierenartsService
    {
        public jsonDierenartsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonDataFileName
        {
            get
            {
                return Path.Combine(
            }
        }
    }
}
