namespace SoR{
    public class Student:Person{
        public Level Level { get; set; }
        public List<string> SignedClasses { get; set; }
        public DateOnly StartDate { get; set; }
    }
}