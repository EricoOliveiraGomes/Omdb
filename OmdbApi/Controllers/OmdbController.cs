using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OmdbApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmdbController : ControllerBase
    {
        //private static readonly string[] Summaries =
        //[
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //];

        private readonly ILogger<OmdbController> _logger;        
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;        

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    //{
        //    //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //    //    TemperatureC = Random.Shared.Next(-20, 55),
        //    //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    //})
        //    //.ToArray();

        //}

        public OmdbController(ILogger<OmdbController> logger, IConfiguration configuration)
        {
            _logger = logger;            
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqliteConnection")!;            
        }


        [HttpGet]
        public string Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

            string retorno = string.Empty;

            using (IDbConnection db = new SqliteConnection(_connectionString))
            {
                db.Open();

                var selectCmd = db.CreateCommand();
                selectCmd.CommandText = "SELECT 1 FROM Omdb";                
                var reader = selectCmd.ExecuteReader();
                
                while (reader.Read())
                {
                    retorno = retorno + reader.GetString(2) + "\n";
                }
            }

            return retorno;

        }
    }
}
