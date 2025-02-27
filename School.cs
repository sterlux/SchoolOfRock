// Cuando definimos clases, tienen que vivir en un namespace
namespace SoR{ // tiene que estar dentro de las llaves o se muere

public class School{

    // Todas las propiedades llevan get set
    public List <Instructor> Instructors {get; set;}
    public List <Student> Students {get; set;}

    public List <Classroom> Classes {get; set;}

    public string Name {get; set;}

    // Este es el constructor
    // Es como un metodo, pero no tiene void ni tipo de retorno
    // Aqui inicializamos las listas
    // Se llama igual que la clase SIEMPRE
    public School(){
        
        Instructors = new List<Instructor>();
        Students = new List<Student>();
        Classes = new List<Classroom>();

    }
    // Si el metodo tiene que regresar algo, no se usa void
    // Se pone el tipo de dato que va a regresar
    // Por ejemplo aqui es "Classroom"
    public Classroom SearchClass (Instrument instrument, Level level){

        Classroom Result = Classes.First(c => c.Instrument == instrument && c.Level == level);
        return Result; // Para regresar se usa return y el objeto o variable
    }
}
}