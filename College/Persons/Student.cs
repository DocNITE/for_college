using System.Runtime;
using College.Journals;
using College.Subjects;

namespace College.Persons;

public class Student: Studeble {
    private List<Subject> _expiriences = new();

    /// <summary>
    /// Subjects, where we contain some school/college perfomans for marked lesson subject
    /// </summary>
    public List<Subject> Expiriences {
        get {
            return _expiriences;
        }
        set {
            //TODO: Maybe i make some feature in... future?
            if (value != null)
                _expiriences = value;
        }
    }
    /// <summary>
    /// Can work student, or he will drop that shit ah?
    /// </summary>
    public int Motivation {get; set;}

    public Student(DateTime Birthday,
                string FirstName = "Daniel", 
                string SecondName = "Fedora", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Student) {
        // TODO:
    }

    public override bool IsCanWork()
    {
        return (base.IsCanWork() == (Motivation > 0));
    }
}