using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Road_Safety_Project.Models;

namespace Road_Safety_Project.Models
{
    public class MST_Hospital
    {
        public int HospitalID { get; set; }
        public string? HospitalName { get; set; }
        public string? HospitalAddress { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CiytID { get; set; }
        public int AreaID { get; set; }
        public string? HospitalMobileNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
   
