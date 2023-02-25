using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace Road_Safety_Project.Controllers
{
    public class WHT_WeatherController : Controller
    {
        private IConfiguration Configuration;
        public WHT_WeatherController (IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            string str = this.Configuration.GetConnectionString("myConnectionString");
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "WHT_Weather_SelectAll";

            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            return View("WHT_WeatherList", dt);
            conn.Close();
        }
    }
}
