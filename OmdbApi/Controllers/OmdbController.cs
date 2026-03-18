using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System.Data;

namespace OmdbApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmdbController : ControllerBase
    {           
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;        

        public OmdbController(IConfiguration configuration)
        {                 
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqliteConnection")!;            
        }

        [HttpGet]
        public string Get()
        {            
            string retorno = string.Empty;

            using (IDbConnection db = new SqliteConnection(_connectionString))
            {
                db.Open();

                var selectCmd = db.CreateCommand();
                selectCmd.CommandText = "SELECT InformacaoFilme FROM Omdb";                
                var reader = selectCmd.ExecuteReader();
                
                while (reader.Read())
                {
                    retorno = retorno + reader.GetString(0) + "\n\n\n";
                }
            }

            return retorno;

        }
    }
}
