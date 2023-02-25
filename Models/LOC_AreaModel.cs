namespace Road_Safety_Project.Models
{
    public class LOC_AreaModel
    {
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }

        public string CountryName { get; set; }
        public string StateName { get; set; }
       
        public string CityName { get; set; }

        public string AreaName { get; set; }
        public string PinCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}


