using System.Net.Security;

namespace Road_Safety_Project.Models
{
    public class LOC_City
    {
        public int CityID { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string? CityName { get; set; }
        public string? CityCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
