using Road_Safety_Project.Models;

namespace Road_Safety_Project.Models
{
    public class MST_User
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public string? UserEmergencyPersonName { get; set; }
        public string? UserEmergencyPersonNumber { get; set; }
        public int EmergencyContactTypeID { get; set; }
        public string? EmergencyType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
