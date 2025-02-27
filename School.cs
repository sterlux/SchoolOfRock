namespace SoR{

public class School{
    public List <Instructor> Instructors {get; set;}
    public List <Student> Students {get; set;}

    public List <Classroom> Classes {get; set;}

    public string Name {get; set;}

    public School(){
        
        Instructors = new List<Instructor>();
        Students = new List<Student>();
        Classes = new List<Classroom>();

    }
    public Classroom SearchClass (Instrument instrument, Level level){
        Classroom Result = Classes.First(c => c.Instrument == instrument && c.Level == level);
        return Result;
    }
}
}