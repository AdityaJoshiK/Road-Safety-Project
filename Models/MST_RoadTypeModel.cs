using Road_Safety_Project.Models;

namespace Road_Safety_Project.Models
{
    public class MST_RoadTypeModel
    {
        public int RoadID { get; set; }
        public string? RoadType { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public int AreaID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}
