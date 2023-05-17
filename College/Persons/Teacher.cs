using System.Runtime;
using College.Journals;

namespace College.Persons;

public class Teacher: Studeble {
    public Teacher(DateTime Birthday,
                string FirstName = "Oleg", 
                string SecondName = "Kondratov", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Teacher) {
        // TODO:
    }
}