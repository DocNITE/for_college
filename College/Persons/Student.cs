using System.Runtime;
using College.Journals;

namespace College.Persons;

public class Student: Studeble {
    public float Expirience {get; set;}

    public Student(DateTime Birthday,
                string FirstName = "Daniel", 
                string SecondName = "Fedora", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Student) {
        // TODO:
    }
}