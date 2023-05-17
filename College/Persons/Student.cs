using System.Runtime;
using College.Journals;
using College.Subjects;

namespace College.Persons;

public class Student: Studeble {
    /// <summary>
    /// Subjects, where we contain some school/college perfomans for marked lesson subject
    /// </summary>
    public List<Subject> Expiriences = new();

    public Student(DateTime Birthday,
                string FirstName = "Daniel", 
                string SecondName = "Fedora", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Student) {
        // TODO:
    }
}