using EntiryOracleNET6Test.DBModels;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;

namespace EntiryOracleNET6Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ModelContext _context;
        private readonly ILogger<WeatherForecastController> _logger;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ModelContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

            var dataSet = new DataSet();
            using (var conn = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = grimspukuora1.grimsp.com)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = UATFOUS)));User Id=fordus;Password=devil;"))
            {
                conn.Open();
                var com = new OracleCommand("select * from people where USER_ID= :userid");
                var param =
                        new OracleParameter(":userid", 267);
                com.Connection = conn;
                com.Parameters.Add(param);
                var dataAdapter = new OracleDataAdapter(com);
                dataAdapter.Fill(dataSet);
                conn.Close();
            }
            return Ok(dataSet.Tables[0].Rows[0]["USER_ID"]);
        }
    }
}