using System.Runtime;
using College.Journals;
using College.Subjects;

namespace College.Persons;

public class Teacher : Studeble {
    /// <summary> 
    /// Mark's, what is lesson subject lead our teacher.
    /// </summary>
    public Subject LeadSubject {get; set;}
    public Teacher(DateTime Birthday,
                string FirstName = "Oleg", 
                string SecondName = "Kondratov", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Teacher) {
        // TODO:
    }
}