using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Road_Safety_Project.Controllers
{
    public class ACT_AccidentController : Controller
    {
        private IConfiguration Configuration;
        public ACT_AccidentController(IConfiguration _configuration)
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
            cmd.CommandText = "PR_ACT_Accident_SelectAll";

            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            return View("ACT_AccidentList",dt);
            conn.Close();
        }
    }
}
