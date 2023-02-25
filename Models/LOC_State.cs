namespace Road_Safety_Project.Models
{
    public class LOC_State
    {
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string? StateName { get; set; }
        public string? StateCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}

