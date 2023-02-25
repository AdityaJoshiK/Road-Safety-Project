using Road_Safety_Project.Models;

namespace Road_Safety_Project.Models
{
    public class MST_EmergencyContactType
    {
        public int EmergencyContactTypeID { get; set; }
        public string? EmergencyContactType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}