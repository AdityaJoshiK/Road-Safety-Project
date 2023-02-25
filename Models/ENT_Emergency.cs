using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Road_Safety_Project.Models
{
    public class ENT_Emergency
    {
        public int EmergencyNumberID { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public int AreaID { get; set; }
        public int EmergencyTypeID { get; set; }
        public int UserID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}

