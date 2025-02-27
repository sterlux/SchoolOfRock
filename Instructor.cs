namespace SoR{
    public class Instructor:Person{ // Asi heredamos de Person
        public List<Instrument> Instruments {get ; set; }
        public int Experience { get; set; }
        public double Rate { get; set; }    
        public int EmployeeNo { get; set; }

    public Instructor(){
        Instruments = new List<Instrument>();
       
    }
    }

}