using System.Runtime;
using College.Journals;
using College.Subjects;
using College.Persons;

namespace College.Persons;

public class Teacher : Studeble {
    /// <summary> 
    /// Mark's, what is lesson subject lead our teacher.
    /// </summary>
    public Subject? LeadSubject {get; set;}
    public Teacher(DateTime Birthday,
                string FirstName = "Oleg", 
                string SecondName = "Kondratov", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Teacher) {
        // TODO:
    }
    /// <summary>
    /// Set scrote subject for student
    /// </summary> 
    public void SetSubjectScore(Student human, float score) {
        foreach (var subject in human.Expiriences) {
            if (LeadSubject == null)
                return;
                 
            if (subject.GetType() == LeadSubject.GetType())
                subject.Score = score;
        }
    }

    public override bool IsCanWork()
    {
        return (base.IsCanWork() == (LeadSubject != null));
    }
}