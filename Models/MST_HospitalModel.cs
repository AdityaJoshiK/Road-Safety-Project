using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Road_Safety_Project.Models;

namespace Road_Safety_Project.Models
{
    public class MST_HospitalModel
    {
        public int HospitalID { get; set; }
        public string? HospitalName { get; set; }
        public string? HospitalAddress { get; set; }
        public int CountryID { get; set; }
        public string? CountryName { get; set; }
        public int StateID { get; set; }
        public string? StateName { get; set; }
        public int CiytID { get; set; }
        public string? CityName { get; set; }
        public int AreaID { get; set; }
        public string? AreaName { get; set; }
        public string? HospitalMobileNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
   
