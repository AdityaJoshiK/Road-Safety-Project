namespace Road_Safety_Project.Models
{
    public class ACT_AccidentModel
    {
        public int AccidentID { get; set; }
        public DateTime AccidentDateTime { get; set; }
        public string? AccidentDescription { get; set; }
        public string? CauseOfAccident { get; set; }
        public int NumberOfCausalties { get; set; }
        public int RoadID { get; set; }
        public int HospitalID { get; set; }
        public int VehicalID { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
