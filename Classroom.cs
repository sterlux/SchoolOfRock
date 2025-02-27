namespace SoR{
    public class Classroom{
        public Instrument Instrument {get ; set; }
        public int capacity {get ; set; }
        public int InstructorEmployeeNo { get; set; }
        public Level Level { get; set; }
        public DateTime Hour { get; set; }
        public int Classtime { get; set; }
        public string Passkey { get; set; }
        public bool IsGroup { get; set; }
    }
}